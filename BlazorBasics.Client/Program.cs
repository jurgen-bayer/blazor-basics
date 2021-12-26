using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorBasics.Client;
using BlazorBasics.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the services
builder.Services.AddScoped<ICounterService, CounterService>();
builder.Services.AddScoped<IOtherServiceUsingCounterService, OtherServiceUsingCounterService>();

await builder.Build().RunAsync();