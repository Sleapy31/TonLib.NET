using Microsoft.Extensions.Logging;
using TonLibDotNet.Internal;
using TonLibDotNet.Requests;
using TonLibDotNet.Types;
using TonLibDotNet.Types.Blocks;
using TonLibDotNet.Types.Ton;
using TonLibDotNet.Utils;

namespace TonLibDotNet.Samples
{
    public class LibraryExtensibilityPlayground : ISample
    {
        private readonly ITonClient tonClient;
        private readonly ILogger logger;

        public LibraryExtensibilityPlayground(ITonClient tonClient, ILogger<LibraryExtensibilityPlayground> logger)
        {
            this.tonClient = tonClient ?? throw new ArgumentNullException(nameof(tonClient));
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Run(bool inMainnet)
        {
            await tonClient.InitIfNeeded();

            // This will fail because TonLib does not have this method.
            // This is just a demo how you can add new types/requests without waiting for new package release.
            // To make this happen in your app - call TonClient.RegisterAssembly() early
            try
            {
                BlockIdEx blockId = new BlockIdEx()
                {
                    Workchain = -1,
                    Seqno = 34341609,
                    Shard = 8000000000000000,
                    FileHash = "mop2di1sJ7wUgU1s61vyZcHwAgqLbpZfQbAVyGulyyc=",
                    RootHash = "8KfXh/SMtNyDQqc8oPRY/VrrNjb04WPDQlxIlkMoYS8="
                };
                var truc = await tonClient.SmcLoad(new AccountAddress("-1:3333333333333333333333333333333333333333333333333333333333333333"));
                TransactionsExt? result = await tonClient.GetBlockTransactionsExt(blockId, 0, 100, new TonLibDotNet.Types.Blocks.AccountTransactionId("-1:3333333333333333333333333333333333333333333333333333333333333333", 42754034000001));
            }
            catch (TonClientException ex)
            {
                logger.LogWarning(ex, "Exception ignored");
                // Ignore
            }
        }
    }
}
