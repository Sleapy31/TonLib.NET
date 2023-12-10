using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TonLibDotNet.Types.Blocks
{
    [TLSchema("blocks.shards shards:vector<ton.BlockIdExt> = blocks.Shards")]
    public class Shards : TypeBase
    {
        public Shards() { }
        public Shards(List<Ton.BlockIdEx> shards)
        {
            ShardsList = shards ?? throw new ArgumentNullException(nameof(shards));
        }
        [JsonPropertyName("shards")]
        public List<Ton.BlockIdEx> ShardsList { get; set; }
    }
}
