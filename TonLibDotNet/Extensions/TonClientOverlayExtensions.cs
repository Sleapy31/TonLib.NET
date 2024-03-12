using TonLibDotNet.Requests.Overlay;
using TonLibDotNet.Types.Overlay;
using TonLibDotNet.Requests.TonNode;
using TonLibDotNet.Types.TonNode;
using TonLibDotNet.Requests.LiteServer;
using TonLibDotNet.Types.Blocks;

namespace TonLibDotNet.Extensions
{
    public static class TonClientOverlayExtensions
    {
        /// <summary>
        /// Returns <see cref="BroadcastList"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<BroadcastList> GetBroadcastList(this ITonClient client, BroadcastList list)
        {
            return client.Execute(new GetBroadcastList(list));
        }

        /// <summary>
        /// Returns <see cref="Capabilities"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<Types.TypeBase> AwaitMasterchainBlock(this ITonClient client, int seqno, int timeout)
        {
            return client.Execute(new WaitMasterchainSeqno(seqno, timeout));
        }

        /// <summary>
        /// Returns <see cref="Capabilities"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<Capabilities> GetCapabilities(this ITonClient client)
        {
            return client.Execute(new GetCapabilities());
        }

        /// <summary>
        /// Returns <see cref="Capabilities"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<MasterchainInfo> GetMasterchainInfoLiteserver(this ITonClient client)
        {
            return client.Execute(new GetMasterchainInfoLiteServer());
        }
    }
}