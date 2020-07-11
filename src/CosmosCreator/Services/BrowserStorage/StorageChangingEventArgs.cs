// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

namespace CosmosCreator.Services.BrowserStorage
{
    public class StorageChangingEventArgs : StorageChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}
