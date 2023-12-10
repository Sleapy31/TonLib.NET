using TonLibDotNet.Requests.Blocks;
using TonLibDotNet.Types.Blocks;

namespace TonLibDotNet
{
    public static class TonClientBlocksExtensions
    {
        /// <summary>
        /// Returns <see cref="MasterchainInfo"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<MasterchainInfo> GetMasterchainInfo(this ITonClient client)
        {
            return client.Execute(new GetMasterchainInfo());
        }

        /// <summary>
        /// Returns <see cref="Transactions"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<Types.Blocks.Transactions> GetBlockTransactions(this ITonClient client, Types.Ton.BlockIdEx id, int mode, int count, Types.Blocks.AccountTransactionId after)
        {
            return client.Execute(new Requests.Blocks.GetTransactions(id, mode, count, after));
        }

        /// <summary>
        /// Returns <see cref="TransactionsExt"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<Types.Blocks.TransactionsExt> GetBlockTransactionsExt(this ITonClient client, Types.Ton.BlockIdEx id, int mode, int count, Types.Blocks.AccountTransactionId after = null)
        {
            return client.Execute(new Requests.Blocks.GetTransactionsExt(id, mode, count, after));
        }

        /// <summary>
        /// Returns <see cref="Shards"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<Types.Blocks.Shards> GetShards(this ITonClient client, Types.Ton.BlockIdEx id)
        {
            return client.Execute(new Requests.Blocks.GetShards(id));
        }
    }
}
