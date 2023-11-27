using TonLibDotNet.Utils;

namespace TonLibDotNet.Requests.Blocks
{    
    [TLSchema("blocks.getTransactionsExt id:ton.blockIdExt mode:# count:# after:blocks.accountTransactionId = blocks.TransactionsExt")]
    public class GetTransactionsExt : RequestBase<Types.Blocks.TransactionsExt>
    {       
        public GetTransactionsExt(Types.Ton.BlockIdEx id, int mode, int count, Types.Blocks.AccountTransactionId after)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Mode =  mode;
            Count = count;
            After = after ?? throw new ArgumentNullException(nameof(after));            
        }

        public Types.Ton.BlockIdEx Id { get; set; }
        public int Mode { get; set; }
        public int Count { get; set; }
        public Types.Blocks.AccountTransactionId After { get; set; }        
    }
}
