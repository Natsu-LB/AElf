﻿using System.Threading.Tasks;
using AElf.Common;
using AElf.Kernel.Manager.Interfaces;
using AElf.Kernel.Storage;

namespace AElf.Kernel.Manager.Managers
{
    public class TransactionResultManager : ITransactionResultManager
    {
        private readonly IKeyValueStore _transactionResultStore;

        public TransactionResultManager(TransactionResultStore transactionResultStore)
        {
            _transactionResultStore = transactionResultStore;
        }

        public async Task AddTransactionResultAsync(TransactionResult tr)
        {
            await _transactionResultStore.SetAsync(tr.TransactionId.ToHex(), tr);
        }

        public async Task<TransactionResult> GetTransactionResultAsync(Hash txId)
        {
            return await _transactionResultStore.GetAsync<TransactionResult>(txId.ToHex());
        }
    }
}