using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Bson.DefaultSerializer;
using System.EnterpriseServices;
using System.Runtime.CompilerServices;



namespace WcfExtension.LogCenter.Core
{
    /// <summary>
    /// 数据保存在MongoDB中
    /// </summary>
  public  class NoSqlMongoDB
    {

        private static MongoServer MongoDBConn = MongoServer.Create(new MongoUrl(ConfigProvider.Common.MongoConnWcfLog));

        /// <summary>
        /// 获取当前的日期,格式如:yyyyMM:
        /// </summary>
        /// <returns></returns>
        private static string GetCurrentDate()
        {
            return DateTime.Now.ToString("yyyyMM");
        }

        public IDictionary<string, string> GetDatabaseStatus()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();

            string dbName = "WcfLog" + GetCurrentDate();
            try
            {
                //MongoDatabase db = MongoDBConn.GetDatabase(dbName);//数据库名字
                //int count = db.GetCollection<AbstractLogInfo>("AbstractLogInfo").Count();
                //d.Add("DB:" + dbName + " Table:AbstractLogInfo", count.ToString());
                d.Add("Remoting is", "Ok");
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }
            return d;
        }


        /// <summary>
        /// 批量保存数据
        /// </summary>
        /// <param name="data"></param>
        public void SaveData(List<AbstractLogInfo> data)
        {
            try
            {
                string dbName = "WcfLog" + GetCurrentDate();

                MongoDatabase db = MongoDBConn.GetDatabase(dbName);//数据库名字

                foreach (var item in data)
                {
                    string collectionName = "";
                    try
                    {
                        collectionName = item.GetType().Name;
                        MongoCollection<AbstractLogInfo> categories = db.GetCollection<AbstractLogInfo>(collectionName);//列表名字
                        categories.Insert<AbstractLogInfo>(item);
                    }
                    catch (Exception ex)
                    {
                        LogService.Write("库:" + dbName + " 表:" + collectionName + " 出现异常." + ex.ToString());
                    }
                }

                SaveSetting(data);
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }

        }

        /// <summary>
        /// 创建索引
        /// </summary>
        public void CreateIndex()
        {
            LogService.Write("创建索引...");
            try
            {
                //创建索引配置库索引
                MongoDatabase dbWcf = MongoDBConn.GetDatabase("WcfLogServer");//数据库名字
                MongoCollection<BsonDocument> tableInfoSetting = dbWcf["InfoSetting"];
                var indexesWcf = tableInfoSetting.GetIndexes().Select(a => a["name"].ToString()).ToList();
                if (!indexesWcf.Any(index => index.Contains("CollectionName")))
                {
                    tableInfoSetting.CreateIndex(IndexKeys.Descending("CollectionName"), IndexOptions.SetBackground(true).SetUnique(false));
                    LogService.Write("创建库:WcfLogServer 表:InfoSetting 列:CollectionName的索引");
                }

                //创建数据库索引
                string dbName = "WcfLog" + GetCurrentDate();
                string[] orderby = { "CreateTime" };
                List<InfoSetting> list = MongoDBUtil.GetAll<InfoSetting>("WcfLogServer", "InfoSetting", new BsonDocument(), orderby, new BsonDocument());
                if (list != null && list.Count > 0)
                {
                    MongoDatabase db = MongoDBConn.GetDatabase(dbName);//数据库名字
                    foreach (InfoSetting info in list)
                    {
                        if (!string.IsNullOrEmpty(info.IndexName))
                        {
                            MongoCollection<BsonDocument> table = db[info.CollectionName];
                            var indexes = table.GetIndexes().Select(a => a["name"].ToString()).ToList();

                            List<string> listIndexes = info.IndexName.Split(',').ToList();
                            if (listIndexes != null && listIndexes.Count > 0)
                            {
                                foreach (string item in listIndexes)
                                {
                                    if (!indexes.Any(index => index.Contains(item)))
                                    {
                                        table.CreateIndex(IndexKeys.Ascending(item), IndexOptions.SetBackground(true).SetUnique(false));
                                        LogService.Write("创建库:" + dbName + " 表:" + info.CollectionName + " 列:" + item + "的索引");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }
        }


        /// <summary>
        /// 保存日志异常配置信息
        /// </summary>
        /// <param name="logInfo"></param>
        public void SaveSetting(List<AbstractLogInfo> logInfo)
        {
            try
            {
                // 库名：WcfLogServer 表名 InfoSetting 
                // 读出属性，做索引，分库处理
                // 保存到数据库中去，采用批量方式
                List<InfoSetting> listInfo = new List<InfoSetting>();
                InfoSetting infoSetting;
                string temp;
                logInfo.ForEach(log =>
                {
                    Type typeLog = log.GetType();
                    string typeName = typeLog.Name;
                    if (!ConfigProvider.Common.DicInfoSetting.Contains(typeName))//判断索引是否已经创建过
                    {
                        ConfigProvider.Common.DicInfoSetting.Add(typeName);//添加到已创建索引列表中

                        infoSetting = new InfoSetting();
                        string indexes = "";
                        ShardSpan shardSpan = ShardSpan.Month;
                        bool isShard = false;
                        bool isAdd = true;
                        listInfo.ForEach(info =>
                        {
                            if (info.CollectionName == typeName)
                            {
                                isAdd = false;
                            }
                        });
                        if (isAdd)
                        {
                            //通过反射获取属性
                            typeLog.GetProperties().ToList().ForEach(property =>
                            {
                                property.GetCustomAttributes(typeof(PersistenceColumnAttribute), true).Cast<PersistenceColumnAttribute>().ToList().ForEach(pca =>
                                {
                                    if (pca.IsIndex)
                                    {
                                        temp = property.Name + ",";
                                        if (indexes.IndexOf(temp) == -1)
                                        {
                                            indexes += property.Name + ",";
                                        }
                                    }
                                    if (pca.IsShard)
                                    {
                                        isShard = true;
                                        shardSpan = pca.ShardSpan;
                                    }
                                });
                            });
                            infoSetting.CollectionName = typeName;
                            infoSetting.IndexName = indexes.TrimEnd(',');
                            infoSetting.IsShard = isShard;
                            infoSetting.ShardSpan = shardSpan;
                            listInfo.Add(infoSetting);
                        }
                    }
                });

                SaveSettingToMongoDB(listInfo);
            }
            catch (Exception ex)
            {
                LogService.Write(ex);
            }

        }
        /// <summary>
        /// 将配置保存在数据库中
        /// 判断记录是否存在，索引每次重启就行增加操作，分库以首次添加为准。
        /// </summary>
        /// <param name="listInfo"></param>
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void SaveSettingToMongoDB(List<InfoSetting> listInfo)
        {
            MongoDatabase db = MongoDBConn.GetDatabase("WcfLogServer");//数据库名字
            if (db != null)
            {
                //存入mongodb，保存前进行查询
                foreach (InfoSetting item in listInfo)
                {
                    //Console.WriteLine("----------------------------------------------------------");
                    //Console.WriteLine("InfoSetting \r\nCollectionName:{0} \r\nIndexName:{1} \r\nIsShard:{2} \r\nShardSpan:{3}", item.CollectionName, item.IndexName, item.IsShard, item.ShardSpan);
                    string collectionName = "InfoSetting";
                    try
                    {
                        MongoCollection<InfoSetting> categories = db.GetCollection<InfoSetting>(collectionName);//列表名字
                        InfoSetting info = categories.FindOne(new QueryComplete(new BsonDocument("CollectionName", item.CollectionName)));
                        if (info != null)
                        {
                            info.IndexName = item.IndexName;
                            info.ModifyTime = DateTime.Now;
                            categories.Save<InfoSetting>(info);//更新
                        }
                        else
                        {
                            item.ModifyTime = DateTime.Now;
                            item.CreateTime = DateTime.Now;
                            categories.Insert<InfoSetting>(item);//添加
                        }
                    }
                    catch (Exception ex)
                    {
                        LogService.Write("库:WcfLogServer 表:" + collectionName + " 出现异常." + ex.ToString());
                    }
                }
            }
        }

        public void GetTestData()
        {
            string dbName = "WcfLog" + GetCurrentDate();
            string[] orderby = { "Time" };
            List<ClientExceptionInfo> list = MongoDBUtil.GetPaged<ClientExceptionInfo>(dbName, "ClientExceptionInfo", new BsonDocument(), orderby, new BsonDocument(), 1, 100);
            if (list != null && list.Count > 0)
            {
                Console.WriteLine("count:" + list.Count);
                foreach (ClientExceptionInfo ce in list)
                {
                    Console.WriteLine("id:{0} ip:{1} time:{2}", ce.ID, ce.MachineIP, ce.Time);
                }
            }
        }
    }


    /// <summary>
    /// 存储表的关系图  库名：WcfLogServer
    /// </summary>
    [BsonIgnoreExtraElementsAttribute]
    public class InfoSetting
    {
        /// <summary>
        /// 表名称
        /// </summary>
        public string CollectionName { get; set; }

        /// <summary>
        /// 索引字段名称 多个字段请用,分割
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// 是否分库
        /// </summary>
        public bool IsShard { get; set; }

        /// <summary>
        /// 分库类型
        /// </summary>
        public ShardSpan ShardSpan { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime ModifyTime { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
