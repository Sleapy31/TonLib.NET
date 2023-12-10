using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Http;
using System.Numerics;
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
            var testa = -4611686018427387904;
            var testb = new BigInteger(-4611686018427387904);
            var teste = Convert.ToHexString(new BigInteger(-9223372036854775808).ToByteArray(false, true));
            var testj = new BigInteger(Convert.FromHexString(teste), false, true);
            var testc = new BigInteger(Convert.FromHexString("8000000000000000"), false, true);
            var testd = new BigInteger(Convert.FromHexString("8000000000000000"));
            // This will fail because TonLib does not have this method.
            // This is just a demo how you can add new types/requests without waiting for new package release.
            // To make this happen in your app - call TonClient.RegisterAssembly() early
            try
            {
                Task.Run(async() =>
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    BlockIdEx last = await tonClient.Sync();

                    while (sw.Elapsed < TimeSpan.FromSeconds(90))
                    {
                        var lastBlock = await tonClient.Sync();
                        if (lastBlock.Seqno != last.Seqno)
                        {
                            last = lastBlock;

                            var shards = await tonClient.GetShards(lastBlock);
                            Console.WriteLine($"### MASTERCHAIN BLOCK N°{lastBlock.Seqno} ###");
                            foreach (var shard in shards.ShardsList)
                            {
                                string readableShard = Convert.ToHexString(new BigInteger(shard.Shard).ToByteArray(false, true));
                                TransactionsExt? result = await tonClient.GetBlockTransactionsExt(shard, 0, 1000, null);
                                Console.WriteLine($"Workchain: {shard.Workchain} | Shard: {shard.Shard} / {readableShard} |Seqno: {shard.Seqno} | Txs: {result.Transactions.Count} - {DateTime.UtcNow.ToString()}");
                            }
                        }
                    }
                    Console.WriteLine("NEW METHOD TERMINEE !!");
                });

                Task.Run(async() =>
                {
                    var sw = new Stopwatch();
                    sw.Start();
                    BlockIdEx last = await tonClient.Sync();
                    var shards = await tonClient.GetShards(last);
                    int seqno = shards.ShardsList[0].Seqno;
                    while (sw.Elapsed < TimeSpan.FromSeconds(90))
                    {
                        var httpClient = new HttpClient();
                        try
                        {
                            var result = await httpClient.GetStringAsync($"http://localhost:8081/v2/blockchain/blocks/(0,8000000000000000,{seqno})/transactions");
                            Console.WriteLine($"New block !: {seqno} - {DateTime.UtcNow.ToString()}");
                            seqno++;
                        }
                        catch { }
                    }
                    Console.WriteLine("OLD METHOD TERMINEE");
                });
                await Task.Delay(90000);
                Console.WriteLine("TOUTE METHODE TERMINEE");
                Console.ReadLine();
                //Transactions? resulta = await tonClient.GetBlockTransactions(blockId, 0, 100, null);
                //foreach (var id in test.ShardsList)
                //{
                //    TransactionsExt? result = await tonClient.GetBlockTransactionsExt(id, 0, 1000, null);
                //    Console.WriteLine($"Workchain: {id.Workchain} -- Shard: {id.Shard} / {Convert.ToHexString(new BigInteger(id.Shard).ToByteArray(false, true))} -- " +
                //        $"Seqno: {id.Seqno} -- TxsCount: {result.Transactions.Count}");
                //}

            }
            catch (TonClientException ex)
            {
                logger.LogWarning(ex, "Exception ignored");
                // Ignore
            }
        }
    }
}
