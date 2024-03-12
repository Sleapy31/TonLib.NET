using TonLibDotNet.Requests.Log;
using TonLibDotNet.Types.Log;

namespace TonLibDotNet.Extensions
{
    public static class TonClientLogExtensions
    {
        /// <summary>
        /// Returns <see cref="LogTags"/> from current LiteServer.
        /// </summary>
        /// <param name="client">ITonClient instance.</param>
        /// <seealso href="https://github.com/ton-blockchain/ton/blob/v2023.01/tonlib/tonlib/TonlibClient.cpp#L4670"/>
        public static Task<LogTags> GetLogsTags(this ITonClient client)
        {
            return client.Execute(new GetLogsTags());
        }
    }
}
