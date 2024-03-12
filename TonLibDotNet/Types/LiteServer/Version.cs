using System.Text.Json.Serialization;

namespace TonLibDotNet.Types.LiteServer
{
    [TLSchema("liteServer.version mode:# version:int capabilities:long now:int = liteServer.Version")]
    public class Version : TypeBase
    {
        public Version(int version, long capabilities, int now)
        {
            VersionP = version;
            Capabilities = capabilities;
            Now = now;
        }
        public int Mode { get; set; }
        [JsonPropertyName("version")]
        public int VersionP { get; set; }
        public long Capabilities { get; set; }

        public int Now { get; set; }
    }
}