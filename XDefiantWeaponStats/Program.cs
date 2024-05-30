using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using XDefiantWeaponStats;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp =>
    new HttpClient
    {
        BaseAddress = new Uri("https://gist.githubusercontent.com/JulianusIV/048279b4720afdb062366c276026d0a3/raw/080697ea0ccf596bce1fb09062c2470a864f6c60/test.json")
    });

await builder.Build().RunAsync();
