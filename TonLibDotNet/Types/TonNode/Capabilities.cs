using System.Text.Json.Serialization;

namespace TonLibDotNet.Types.TonNode
{
    [TLSchema("tonNode.capabilities version:int capabilities:long = tonNode.Capabilities")]
    public class Capabilities : TypeBase
    {
        public Capabilities(int version, long capabilities)
        {
            Version = version;
            CapabilitiesP = capabilities;
        }
        public int Version { get; set; }
        [JsonPropertyName("capabilities")]
        public long CapabilitiesP { get; set; }
    }
}
