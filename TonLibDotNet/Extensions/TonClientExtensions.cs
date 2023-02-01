﻿using TonLibDotNet.Requests;
using TonLibDotNet.Types;

namespace TonLibDotNet
{
    public static class TonClientExtensions
    {
        public static Task<FullAccountState> GetAccountState(this ITonClient client, AccountAddress accountAddress)
        {
            return client.Execute(new GetAccountState(accountAddress));
        }

        public static Task<FullAccountState> GetAccountState(this ITonClient client, string accountAddress)
        {
            return client.Execute(new GetAccountState(new AccountAddress(accountAddress)));
        }

        public static Task<Types.Ton.BlockIdEx> Sync(this ITonClient client)
        {
            return client.Execute(new Sync());
        }
    }
}
