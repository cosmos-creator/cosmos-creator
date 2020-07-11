// SPDX-License-Identifier: MIT
// Copyright ©2020 Cosmos Creator Group

using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using CosmosCreator.Extensions;

namespace CosmosCreator
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services
                .AddBaseAddressHttpClient()
                .AddBrowserStorage();

            await builder.Build().RunAsync();
        }
    }
}
