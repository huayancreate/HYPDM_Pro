namespace WcfExtension
{
    using System;
    using System.Configuration;
    using System.Runtime.CompilerServices;
    using System.Threading;
    using ServiceStack.Redis;

    public class ConfigUpdateManager
    {
        private static readonly int CHECK_SECONDS = 5;
        private static readonly string HEART_MESSAGE = "heart";
        private static readonly string REDIS_ADDRESS = ConfigurationManager.AppSettings["redis_address"];
        private static readonly string REDIS_MESSAGE_CLIENT_CHANNEL = ConfigurationManager.AppSettings["redis_message_client_channel"];
        private static readonly string REDIS_MESSAGE_SERVICE_CHANNEL = ConfigurationManager.AppSettings["redis_message_service_channel"];
        private static PooledRedisClientManager redisClientManager = new PooledRedisClientManager(REDIS_ADDRESS);

        private static Thread redisHeartThreadForServer;
        private static Thread redisHeartThreadForClient;
        private static Thread redisSubThreadForServer;
        private static Thread redisSubThreadForClient;
        private static DateTime lastCheckMsgTime = DateTime.Now;
        private static Timer redisCheckTimer;

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal static void InitClient()
        {
            CreateRedisSubThreadForClient();
            CreateCheckTimer(CreateRedisSubThreadForClient);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        internal static void InitServer()
        {
            CreateRedisSubThreadForServer();
            CreateCheckTimer(CreateRedisSubThreadForServer);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void InitHeart()
        {
            LocalLogService.Log("InitHeart");
            if (redisHeartThreadForClient == null)
            {
                redisHeartThreadForClient = new Thread(() =>
                {
                    while (true)
                    {
                        using (var redisClient = redisClientManager.GetClient())
                        {
                            redisClient.PublishMessage(REDIS_MESSAGE_CLIENT_CHANNEL, HEART_MESSAGE);
                        }
                        Thread.Sleep(CHECK_SECONDS * 1000);
                    }
                })
                {
                    IsBackground = true,
                    Name = "redisHeartThreadForClient",
                };
                redisHeartThreadForClient.Start();
            }

            if (redisHeartThreadForServer == null)
            {
                redisHeartThreadForServer = new Thread(() =>
                {
                    while (true)
                    {
                        using (var redisClient = redisClientManager.GetClient())
                        {
                            redisClient.PublishMessage(REDIS_MESSAGE_SERVICE_CHANNEL, HEART_MESSAGE);
                        }
                        Thread.Sleep(CHECK_SECONDS * 1000);
                    }
                })
                {
                    IsBackground = true,
                    Name = "redisHeartThreadForServer",
                };
                redisHeartThreadForServer.Start();
            }
        }

        private static void CreateCheckTimer(Action action)
        {
            if (redisCheckTimer == null)
            {
                redisCheckTimer = new Timer(obj =>
                {
                    if (((TimeSpan)(DateTime.Now - lastCheckMsgTime)).Seconds > CHECK_SECONDS *2)
                    {
                        LocalLogService.Log("Recreate redis sub thread");
                        try
                        {
                            redisSubThreadForClient.Abort();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            action();
                        }
                    }
                }, null, 0, 5000);
            }
        }

        private static void CreateRedisSubThreadForClient()
        {
            redisSubThreadForClient = new Thread(() =>
            {
                try
                {
                    using (var subscription = redisClientManager.GetClient().CreateSubscription())
                    {
                        subscription.OnSubscribe = channel =>
                        {
                            LocalLogService.Log("CreateClientRedisSubThread OnSubscribe");
                        };
                        subscription.OnMessage = (channel, msg) =>
                        {
                            try
                            {
                                if (msg == HEART_MESSAGE)
                                {
                                    lastCheckMsgTime = DateTime.Now;
                                }
                                else
                                {
                                    if (WcfServiceClientFactory.TryRemoteChannelFactoryFromCache(msg))
                                    {
                                        LocalLogService.Log("Got redis message, client cache removed, type : " + msg);
                                    }
                                    else
                                    {
                                        LocalLogService.Log("Got redis message, failed to find type client cache, type : " + msg);
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                LocalLogService.Log(ex.ToString());
                            }
                        };

                        subscription.SubscribeToChannels(REDIS_MESSAGE_CLIENT_CHANNEL);
                    }
                }
                catch (Exception ex)
                {
                    LocalLogService.Log(ex.ToString());
                }
            });

            redisSubThreadForClient.Name = "redisSubThreadForClient";
            redisSubThreadForClient.IsBackground = true;
            redisSubThreadForClient.Start();
        }


        private static void CreateRedisSubThreadForServer()
        {
            redisSubThreadForServer = new Thread(() =>
            {
                try
                {
                    using (var subscription = redisClientManager.GetClient().CreateSubscription())
                    {
                        subscription.OnSubscribe = channel =>
                        {
                            LocalLogService.Log("CreateClientRedisSubThread OnSubscribe");
                        };
                        subscription.OnMessage = (channel, msg) =>
                        {
                            try
                            {
                                if (msg == HEART_MESSAGE)
                                {
                                    lastCheckMsgTime = DateTime.Now;
                                }
                                else
                                {
                                    if (ServerManager.TryRestartService(msg))
                                    {
                                        LocalLogService.Log("Got redis message, server restarted, type : " + msg);
                                    }
                                    else
                                    {
                                        LocalLogService.Log("Got redis message, server type is not match, type : " + msg);
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                LocalLogService.Log(ex.ToString());
                            }
                        };

                        subscription.SubscribeToChannels(REDIS_MESSAGE_SERVICE_CHANNEL);
                    }
                }
                catch (Exception ex)
                {
                    LocalLogService.Log(ex.ToString());
                }
            });

            redisSubThreadForServer.Name = "redisSubThreadForServer";
            redisSubThreadForServer.IsBackground = true;
            redisSubThreadForServer.Start();
        }
    }
}
