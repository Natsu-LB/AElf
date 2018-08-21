﻿using AElf.ChainController.Rpc;
using AElf.Net.Rpc;
using AElf.Wallet.Rpc;
using Autofac;

namespace AElf.Kernel.Modules.AutofacModule
{
    public class RpcServicesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ChainControllerRpcService>().PropertiesAutowired();
            builder.RegisterType<NetRpcService>().PropertiesAutowired();
            builder.RegisterType<WalletRpcService>().PropertiesAutowired();
        }
    }
}