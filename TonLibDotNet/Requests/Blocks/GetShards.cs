using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonLibDotNet.Requests.Blocks
{
    [TLSchema("blocks.getShards id:ton.blockIdExt = blocks.Shards")]
    public class GetShards : RequestBase<Types.Blocks.Shards>
    {
        public GetShards(Types.Ton.BlockIdEx id)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));         
        }

        public Types.Ton.BlockIdEx Id { get; set; }
    }
}
