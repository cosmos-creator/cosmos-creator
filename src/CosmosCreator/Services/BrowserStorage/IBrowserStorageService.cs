// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmosCreator.Services.BrowserStorage
{
    public interface IBrowserStorageService
    {
        event EventHandler<StorageChangedEventArgs> StorageChanged;
        event EventHandler<StorageChangingEventArgs> StorageChanging;

        bool Set(string key, object value);
        Task<bool> SetAsync(string key, object value);
        T Get<T>(string key);
        Task<T> GetAsync<T>(string key);
        void Remove(string key);
        Task RemoveAsync(string key);
        void Clear();
        Task ClearAsync();
        int Length();
        Task<int> LengthAsync();
        string Key(int index);
        Task<string> KeyAsync(int index);
        bool Contains(string key);
        Task<bool> ContainsAsync(string key);
        IEnumerable<string> Keys();
        IAsyncEnumerable<string> KeysAsync();
    }
}
