﻿using System.Text.Json.Serialization;

namespace TonLibDotNet.Types.Blocks
{
    [TLSchema("blocks.transactionsExt id:ton.blockIdExt req_count:int32 incomplete:Bool transactions:vector<raw.transaction> = blocks.TransactionsExt")]
    public class TransactionsExt : TypeBase
    {
        public TransactionsExt(Ton.BlockIdEx id, List<Types.Raw.Transaction> transactions)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            TransactionsList = transactions ?? throw new ArgumentNullException(nameof(transactions));
        }
        public Ton.BlockIdEx Id { get; set; }
        public int ReqCount { get; set; }

        public bool Incomplete { get; set; }
        [JsonPropertyName("transactions")]
        public List<Types.Raw.Transaction> TransactionsList { get; set; }
    }
}
