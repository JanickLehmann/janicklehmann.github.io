using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using janicklehmann.github.io;
using janicklehmann.github.io.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient("IP", options => {
    options.BaseAddress = new Uri("https://reallyfreegeoip.org");
});

builder.Services.AddScoped<IIPService, IPService>();

await builder.Build().RunAsync();
