namespace TonLibDotNet.Types.Blocks
{
    [TLSchema("blocks.accountTransactionId account:bytes lt:int64 = blocks.AccountTransactionId")]
    public class AccountTransactionId : TypeBase
    {
        public AccountTransactionId(string account, long lt)
        {
            Account = account;
            Lt = lt;
        }
        public string Account { get; set; }
        public long Lt { get; set; }
    }
}
