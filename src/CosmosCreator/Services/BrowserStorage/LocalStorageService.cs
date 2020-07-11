// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace CosmosCreator.Services.BrowserStorage
{
    public class LocalStorageService : BaseStorageService, ILocalStorageService
    {
        public LocalStorageService(IJSRuntime jsRuntime) : base(jsRuntime) { }

        protected override void JSSetItem(string key, string value) => _jsInProcessRuntime.InvokeVoid("localStorage.setItem", key, value);
        protected override ValueTask JSSetItemAsync(string key, string value) => _jsRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
        protected override string JSGetItem(string key) => _jsInProcessRuntime.Invoke<string>("localStorage.getItem", key);
        protected override ValueTask<string> JSGetItemAsync(string key) => _jsRuntime.InvokeAsync<string>("localStorage.getItem", key);
        protected override void JSRemoveItem(string key) => _jsInProcessRuntime.InvokeVoid("localStorage.removeItem", key);
        protected override ValueTask JSRemoveItemAsync(string key) => _jsRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        protected override void JSClear() => _jsInProcessRuntime.InvokeVoid("localStorage.clear");
        protected override ValueTask JSClearAsync() => _jsRuntime.InvokeVoidAsync("localStorage.clear");
        protected override int JSLength() => _jsInProcessRuntime.Invoke<int>("eval", "localStorage.length");
        protected override ValueTask<int> JSLengthAsync() => _jsRuntime.InvokeAsync<int>("eval", "localStorage.length");
        protected override string JSKey(int index) => _jsInProcessRuntime.Invoke<string>("localStorage.key", index);
        protected override ValueTask<string> JSKeyAsync(int index) => _jsRuntime.InvokeAsync<string>("localStorage.key", index);
        protected override bool JSHasOwnProperty(string key) => _jsInProcessRuntime.Invoke<bool>("localStorage.hasOwnProperty", key);
        protected override ValueTask<bool> JSHasOwnPropertyAsync(string key) => _jsRuntime.InvokeAsync<bool>("localStorage.hasOwnProperty", key);
    }
}
