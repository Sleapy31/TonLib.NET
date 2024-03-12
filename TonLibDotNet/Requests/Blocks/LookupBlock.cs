

namespace TonLibDotNet.Requests.Blocks
{
    [TLSchema("blocks.lookupBlock mode:int32 id:ton.blockId lt:int64 utime:int32 = ton.BlockIdExt")]
    public class LookupBlock : RequestBase<Types.Ton.BlockIdEx>
    {
        public LookupBlock(int mode, Types.Ton.BlockId id, long lt, int utime)
        {
            Mode = mode;
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Lt = lt;
            Utime = utime;
        }

        public int Mode { get; set; }
        public Types.Ton.BlockId Id { get; set; }
        public long Lt { get; set; }
        public int Utime { get; set; }
        
    }
}
