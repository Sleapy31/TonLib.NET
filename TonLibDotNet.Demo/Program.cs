using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TonLibDotNet.Types;

namespace TonLibDotNet
{
    public static class Program
    {
        // You will need actual mnemonic and address with some coins to run tests like SendTon, SendJetton etc.
        // These tests have safeguards and will not run on mainnet.
        // But anyway, double check that you are using testnet and what tests are uncommented before putting actual seed phrase here!!!
        public const string TestAddress = "EQAkEWzRLi1sw9AlaGDDzPvk2_F20hjpTjlvsjQqYawVmdT0";
        public const string TestMnemonic = ""; // put space-delimited mnemonic words here

        // Some tests need mainnet (e.g. domains), some will run only in testnet (e.g. sending coins).
        public const bool UseMainnet = true;

        private const string DirectoryForKeys = "C:/Ton/Temp/Keys";

        public static async Task Main(string[] args)
        {
            var builder = Host.CreateDefaultBuilder(args);

            builder.UseConsoleLifetime();
            builder.ConfigureServices((context, services) =>
            {
                services.Configure<TonOptions>(o =>
                {
                    o.UseMainnet = UseMainnet;
                    o.ConfigPathMainnet = new Uri("https://raw.githubusercontent.com/ton-blockchain/ton-blockchain.github.io/4808de0e6f202776f2d43757e0550e3c3cb37942/global.config.json");
                    o.LogTextLimit = 200; // Set to 0 to see full requests/responses
                    o.VerbosityLevel = 0;
                    o.Options.KeystoreType = new KeyStoreTypeDirectory(DirectoryForKeys);
                    //o.Options.KeystoreType = new KeyStoreTypeInMemory();
                    o.LocalPathMainnet = "local.config.json";
                });

                services.AddHostedService<SamplesRunner>();

                services.AddSingleton<ITonClient, TonClient>();

                var samples = typeof(Program).Assembly.GetTypes().Where(x => x.IsClass && x.IsAssignableTo(typeof(ISample))).ToList();
               // var samples = typeof(Program).Assembly.GetTypes().Where(x => x.Name == "LibraryExtensibilityPlayground" && x.IsClass && x.IsAssignableTo(typeof(ISample))).ToList();
                foreach (var sample in samples)
                {
                    services.AddTransient(typeof(ISample), sample);
                }
            });

            /// Add types from current assembly (see <see cref="LibraryExtensibility"/> class for more info).
            TonClient.RegisterAssembly(typeof(Program).Assembly);

            var app = builder.Build();
            await app.RunAsync();
        }
    }
}