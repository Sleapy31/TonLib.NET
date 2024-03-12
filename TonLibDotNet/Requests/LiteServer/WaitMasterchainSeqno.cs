using System.Text.Json.Serialization;

namespace TonLibDotNet.Requests.LiteServer
{
    [TLSchema("liteServer.waitMasterchainSeqno seqno:int timeout_ms:int = Object")]
    public class WaitMasterchainSeqno : RequestBase<Types.TypeBase>
    {
        public WaitMasterchainSeqno(int seqno, int timeoutMs)
        {
            Seqno = seqno;
            TimeoutMs = timeoutMs;
        }

        public int Seqno {get;set; }
        [JsonPropertyName("timeout_ms")]
        public int TimeoutMs { get; set; }
    }

    [TLSchema("liteServer.getMasterchainInfo = liteServer.MasterchainInfo")]
    public class GetMasterchainInfoLiteServer : RequestBase<Types.Blocks.MasterchainInfo>
    {
        // nothing
    }
}
