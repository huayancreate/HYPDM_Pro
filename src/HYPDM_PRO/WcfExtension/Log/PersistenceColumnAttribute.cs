namespace WcfExtension
{
    using System;

    public enum ShardSpan
    {
        Day,
        Week,
        Month,
        Year,
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true, Inherited = true)]
    public class PersistenceColumnAttribute : Attribute
    {
        public bool IsIndex { get; set; }

        public bool IsShard { get; set; }

        public ShardSpan ShardSpan { get; set; }

        public PersistenceColumnAttribute()
        {
            this.IsIndex = this.IsShard = false;
            this.ShardSpan = WcfExtension.ShardSpan.Month;
        }
    }
}
