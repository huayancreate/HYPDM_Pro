namespace WcfExtension
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.ServiceModel;
    using System.ServiceModel.Dispatcher;

    internal class OperationInvoker : IOperationInvoker
    {
        IOperationInvoker invoker;
        Stopwatch sw;

        public OperationInvoker(IOperationInvoker oldInvoker)
        {
            invoker = oldInvoker;
        }

        public virtual object[] AllocateInputs()
        {
            return invoker.AllocateInputs();
        }

        protected void PostInvoke(object[] inputs, object returnedValue, object[] outputs, Exception exception)
        {
            try
            {
#if DEBUG
                if (exception == null)
                    Console.WriteLine("End invoke：" + OperationContext.Current.GetCurrentOperationDescription().SyncMethod.Name);
                Console.WriteLine("ElapsedMilliseconds：" + sw.ElapsedMilliseconds);
#endif
                var results = new List<string>();
                results.Add(returnedValue.ToString());
                results.AddRange(outputs.Select(o => o.ToString()).ToList());

                var logSetting = WcfSettingManager.CurrentServerSetting(OperationContext.Current.GetCurrentServiceDescription().ServiceType).WcfLogSetting;
                if (logSetting.Enabled && logSetting.InvokeInfoSetting.Enabled)
                {
                    var log = WcfLogProvider.GetServerInvokeInfo(
                    "OperationInvoker.PostInvoke",
                    sw.ElapsedMilliseconds,
                    exception == null ? true : false,
                    OperationContext.Current.GetCurrentOperationDescription().SyncMethod.Name,
                    ServerApplicationContext.Current,
                    inputs.Select(i => i.ToString()).ToList(), results);
                    WcfServiceLocator.GetLogService().LogWithoutException(log);
                }
            }
            catch (Exception ex)
            {
                LocalLogService.Log(ex.ToString());
            }
        }

        public object Invoke(object instance, object[] inputs, out object[] outputs)
        {
            object returnedValue = null;
            Exception exception = null;

            try
            {
                sw = Stopwatch.StartNew();
                returnedValue = invoker.Invoke(instance, inputs, out outputs);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }

            PostInvoke(inputs, returnedValue, outputs, exception);

            return returnedValue;
        }

        public IAsyncResult InvokeBegin(object instance, object[] inputs, AsyncCallback callback, object state)
        {
            sw = Stopwatch.StartNew();
            return invoker.InvokeBegin(instance, inputs, callback, inputs);
        }

        public object InvokeEnd(object instance, out object[] outputs, IAsyncResult result)
        {
            object returnedValue = null;
            Exception exception = null;

            try
            {
                returnedValue = invoker.InvokeEnd(instance, out outputs, result);
            }
            catch (Exception ex)
            {
                exception = ex;
                throw;
            }

            PostInvoke(result.AsyncState as object[], returnedValue, outputs, exception);

            return returnedValue;
        }

        public bool IsSynchronous
        {
            get
            {
                return invoker.IsSynchronous;
            }
        }
    }
}
