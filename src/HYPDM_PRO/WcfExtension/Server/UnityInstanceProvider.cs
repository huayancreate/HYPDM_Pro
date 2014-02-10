namespace WcfExtension
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Dispatcher;
    using Microsoft.Practices.Unity;
    using Microsoft.Practices.Unity.Configuration;

    internal class UnityInstanceProvider : IInstanceProvider
    {
        private static UnityContainer Container { set; get; }
        public Type ServiceType { set; get; }

        static UnityInstanceProvider()
        {
            Container = new UnityContainer();
            Container.LoadConfiguration();
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return Container.Resolve(ServiceType);
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
        }
    }
}
