using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;
using TonLibDotNet.Extensions;
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
            HttpClient httpClient = new();

            try
            {
                
                
                
                var sw = new Stopwatch();
                sw.Start();
                var blockiDd = await tonClient.GetMasterchainInfo();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                return;
                var source = new CancellationTokenSource();
                Console.WriteLine("START METHOD SUBSCRIBE");
                var last = await tonClient.Sync();
                var shards = await tonClient.GetShards(last);
                Console.WriteLine($"### MASTERCHAIN BLOCK N°{last.Seqno} ###");
                Task.Run(async () => { await Task.Delay(60000); source.Cancel(); });
                await Parallel.ForEachAsync(shards.ShardsList, async (shard, token) =>
                {
                    token = source.Token;
                    int current = shard.Seqno;
                    string readableShard = Convert.ToHexString(new BigInteger(shard.Shard).ToByteArray(false, true));
                    while (!token.IsCancellationRequested)
                    {
                        try
                        {
                            var result = await httpClient.GetStringAsync($"http://localhost:8081/v2/blockchain/blocks/({shard.Workchain},{readableShard},{current})/transactions");
                            //var txs = JsonConvert.DeserializeObject<TonApiTransactions>(result);
                            Console.WriteLine($"Workchain: {shard.Workchain} | Shard: {readableShard}  |Seqno: {current} | Txs:  - {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                            current++;
                        }
                        catch { }
                    }
                });

                Console.WriteLine("SUBSCRIBE METHOD TERMINEE !!");

                //Task.Run(async () =>
                //{
                //    Console.WriteLine("START METHOD SUBSCRIBE");
                //    var last = await tonClient.Sync();
                //    var shards = await tonClient.GetShards(last);
                //    Console.WriteLine($"### MASTERCHAIN BLOCK N°{last.Seqno} ###");

                //    await Parallel.ForEachAsync(shards.ShardsList, async (shard, token) =>
                //    {
                //        int current = shard.Seqno;
                //        string readableShard = Convert.ToHexString(new BigInteger(shard.Shard).ToByteArray(false, true));
                //        while (!token.IsCancellationRequested)
                //        {
                //            try
                //            {
                //                var result = await httpClient.GetStringAsync($"http://localhost:8081/v2/blockchain/blocks/({shard.Workchain},{readableShard},{current})/transactions");
                //                //var txs = JsonConvert.DeserializeObject<TonApiTransactions>(result);
                //                Console.WriteLine($"Workchain: {shard.Workchain} | Shard: {readableShard}  |Seqno: {current} | Txs:  - {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                //                current++;
                //            }
                //            catch { }
                //        }
                //    });

                //    Console.WriteLine("SUBSCRIBE METHOD TERMINEE !!");
                //});
                //Task.Run(async () =>
                //{
                //    Console.WriteLine("START OLD METHOD");
                //    var last = await tonClient.Sync();
                //    while (sw.Elapsed < TimeSpan.FromSeconds(90))
                //    {
                //        var lastBlock = await tonClient.Sync();
                //        if (lastBlock.Seqno != last.Seqno)
                //        {
                //            last = lastBlock;

                //            var shards = await tonClient.GetShards(lastBlock);
                //            Console.WriteLine($"### MASTERCHAIN BLOCK N°{lastBlock.Seqno} ###");
                //            foreach (var shard in shards.ShardsList)
                //            {
                //                string readableShard = Convert.ToHexString(new BigInteger(shard.Shard).ToByteArray(false, true));
                //                var result = await httpClient.GetStringAsync($"http://localhost:8081/v2/blockchain/blocks/({shard.Workchain},{readableShard},{shard.Seqno})/transactions");
                //                //var txs = JsonConvert.DeserializeObject<TonApiTransactions>(result);
                //                Console.WriteLine($"Workchain: {shard.Workchain} | Shard: {shard.Shard} / {readableShard} |Seqno: {shard.Seqno} | Txs:  - {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                //            }
                //        }
                //    }
                //    Console.WriteLine("OLD METHOD TERMINEE !!");
                //});
                Task.Run(async () =>
                {
                    var last = await tonClient.Sync();
                    while (sw.Elapsed < TimeSpan.FromSeconds(90))
                    {
                        var lastBlock = await tonClient.Sync();
                        if (lastBlock.Seqno != last.Seqno)
                        {
                            last = lastBlock;

                            var shards = await tonClient.GetShards(lastBlock);
                            Console.WriteLine($"### MASTERCHAIN BLOCK N°{lastBlock.Seqno} ###");
                            Parallel.ForEachAsync(shards.ShardsList, async (shard, token) =>
                            //foreach (var shard in shards.ShardsList)
                            {
                                string readableShard = Convert.ToHexString(new BigInteger(shard.Shard).ToByteArray(false, true));
                                TransactionsExt? result = await tonClient.GetBlockTransactionsExt(shard, 0, 1000, null);
                                Console.WriteLine($"Workchain: {shard.Workchain} | Shard: {shard.Shard} / {readableShard} |Seqno: {shard.Seqno} | Txs: {result.Transactions.Count} - {DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture)}");
                            });
                        }
                    }
                    Console.WriteLine("NEW METHOD TERMINEE !!");
                });

                await Task.Delay(90000);
                Console.WriteLine("TERMINEE");


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
