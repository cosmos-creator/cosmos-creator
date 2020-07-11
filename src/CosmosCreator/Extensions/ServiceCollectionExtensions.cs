// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

using CosmosCreator.Services.BrowserStorage;
using Microsoft.Extensions.DependencyInjection;

namespace CosmosCreator.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBrowserStorage(this IServiceCollection services)
        {
            return services
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped<ISessionStorageService, SessionStorageService>();
        }
    }
}
