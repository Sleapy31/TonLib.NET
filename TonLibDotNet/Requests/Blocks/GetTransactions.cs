namespace TonLibDotNet.Requests.Blocks
{
    [TLSchema("blocks.getTransactions id:ton.blockIdExt mode:# count:# after:blocks.accountTransactionId = blocks.Transactions")]
    public class GetTransactions : RequestBase<Types.Blocks.Transactions>
    {
        public GetTransactions(Types.Ton.BlockIdEx id, Types.Blocks.AccountTransactionId after)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            After = after ?? throw new ArgumentNullException(nameof(after));
        }

        public Types.Ton.BlockIdEx Id { get; set; }
        public Types.Blocks.AccountTransactionId After { get; set; }
    }
}
