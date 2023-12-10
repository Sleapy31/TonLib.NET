namespace TonLibDotNet.Requests.Blocks
{
    [TLSchema("blocks.getTransactions id:ton.blockIdExt mode:# count:# after:blocks.accountTransactionId = blocks.Transactions")]
    public class GetTransactions : RequestBase<Types.Blocks.Transactions>
    {
        public GetTransactions(Types.Ton.BlockIdEx id, int mode, int count, Types.Blocks.AccountTransactionId after)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Mode = mode;
            Count = count;
            After = after;
        }

        public int Mode { get; set; }
        public int Count { get; set; }
        public Types.Ton.BlockIdEx Id { get; set; }
        public Types.Blocks.AccountTransactionId After { get; set; }
    }
}
