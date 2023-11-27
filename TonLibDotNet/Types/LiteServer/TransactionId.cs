namespace TonLibDotNet.Types.LiteServer
{
    [TLSchema("blocks.shortTxId mode:# account:mode.0?bytes lt:mode.1?int64 hash:mode.2?bytes = liteServer.TransactionId")]
    public class TransactionId : TypeBase
    {
        public TransactionId(string? account, long? lt, string? hash)
        {
            Account = account;
            Lt = lt;
            Hash = hash;
        }
        public string? Account { get; set; }
        public long? Lt { get; set; }

        public string? Hash { get; set; }
    }
}
