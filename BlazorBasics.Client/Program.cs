using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorBasics.Client;
using BlazorBasics.Client.Services;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register default services
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Register the own services
builder.Services.AddScoped<ICounterService, CounterService>();
builder.Services.AddScoped<IOtherServiceUsingCounterService, OtherServiceUsingCounterService>();

// Register third-party services
builder.Services.AddBlazoredToast();

await builder.Build().RunAsync();