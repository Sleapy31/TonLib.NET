using System.Text.Json.Serialization;

namespace TonLibDotNet.Types.Blocks
{
    [TLSchema("blocks.transactions id:ton.blockIdExt req_count:int32 incomplete:Bool transactions:vector<blocks.shortTxId> = blocks.Transactions")]
    public class Transactions : TypeBase
    {
        public Transactions(Ton.BlockIdEx id, List<Types.LiteServer.TransactionId> transactions)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            TransactionsList = transactions ?? throw new ArgumentNullException(nameof(transactions));
        }
        public Ton.BlockIdEx Id { get; set; } = new();
        public int ReqCount { get; set; } 

        public bool Incomplete { get; set; }
        [JsonPropertyName("transactions")]
        List<Types.LiteServer.TransactionId> TransactionsList { get; set; }
    }
}
