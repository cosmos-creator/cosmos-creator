// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace CosmosCreator.Services.BrowserStorage
{
    public class SessionStorageService : BaseStorageService, ISessionStorageService
    {
        public SessionStorageService(IJSRuntime jsRuntime) : base(jsRuntime) { }

        protected override void JSSetItem(string key, string value) => _jsInProcessRuntime.InvokeVoid("sessionStorage.setItem", key, value);
        protected override ValueTask JSSetItemAsync(string key, string value) => _jsRuntime.InvokeVoidAsync("sessionStorage.setItem", key, value);
        protected override string JSGetItem(string key) => _jsInProcessRuntime.Invoke<string>("sessionStorage.getItem", key);
        protected override ValueTask<string> JSGetItemAsync(string key) => _jsRuntime.InvokeAsync<string>("sessionStorage.getItem", key);
        protected override void JSRemoveItem(string key) => _jsInProcessRuntime.InvokeVoid("sessionStorage.removeItem", key);
        protected override ValueTask JSRemoveItemAsync(string key) => _jsRuntime.InvokeVoidAsync("sessionStorage.removeItem", key);
        protected override void JSClear() => _jsInProcessRuntime.InvokeVoid("sessionStorage.clear");
        protected override ValueTask JSClearAsync() => _jsRuntime.InvokeVoidAsync("sessionStorage.clear");
        protected override int JSLength() => _jsInProcessRuntime.Invoke<int>("eval", "sessionStorage.length");
        protected override ValueTask<int> JSLengthAsync() => _jsRuntime.InvokeAsync<int>("eval", "sessionStorage.length");
        protected override string JSKey(int index) => _jsInProcessRuntime.Invoke<string>("sessionStorage.key", index);
        protected override ValueTask<string> JSKeyAsync(int index) => _jsRuntime.InvokeAsync<string>("sessionStorage.key", index);
        protected override bool JSHasOwnProperty(string key) => _jsInProcessRuntime.Invoke<bool>("sessionStorage.hasOwnProperty", key);
        protected override ValueTask<bool> JSHasOwnPropertyAsync(string key) => _jsRuntime.InvokeAsync<bool>("sessionStorage.hasOwnProperty", key);
    }
}
