namespace WcfExtension
{
    internal interface IClientInfo
    {
        string ClientTypeName { get; set; }

        [PersistenceColumn(IsIndex = true)]
        string ContractName { get; set; }
    }
}
