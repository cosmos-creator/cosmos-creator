// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

namespace CosmosCreator.Services.BrowserStorage
{
    public class StorageChangedEventArgs
    {
        public string Key { get; set; }
        public object PreviousValue { get; set; }
        public object NewValue { get; set; }
    }
}
