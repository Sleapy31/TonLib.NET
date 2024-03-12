using TonLibDotNet.Types.Overlay;

namespace TonLibDotNet.Requests.Overlay
{
    [TLSchema("overlay.getBroadcastList list:overlay.broadcastList = overlay.BroadcastList")]
    public class GetBroadcastList : RequestBase<Types.Overlay.BroadcastList>
    {
        public GetBroadcastList(BroadcastList list)
        {
            List = list;
        }
        public BroadcastList? List { get; set; }
    }
}
