namespace TonLibDotNet.Types.Overlay
{
    [TLSchema("overlay.broadcastList hashes:(vector int256) = overlay.BroadcastList")]
    public class BroadcastList : TypeBase
    {
        public List<string>? Hashes { get; set; }
    }
}
