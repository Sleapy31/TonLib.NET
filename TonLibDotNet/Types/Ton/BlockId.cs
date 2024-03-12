namespace TonLibDotNet.Types.Ton
{
    [TLSchema("ton.blockId workchain:int32 shard:int64 seqno:int32 = internal.BlockId")]
    public class BlockId : TypeBase
    {
        public int Workchain { get; set; }

        public long Shard { get; set; }

        public int Seqno { get; set; }
    }
}
