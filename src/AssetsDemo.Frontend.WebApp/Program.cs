using AssetsDemo.Frontend.WebApp.Components;
using AssetsDemo.Frontend.WebApp.Services.Implementations;
using AssetsDemo.Frontend.WebApp.Services.Interfaces;
using AssetsDemo.Frontend.WebApp.Settings;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddRazorComponents()
    .AddInteractiveServerComponents();

services.AddHttpContextAccessor();

services.AddOptions<ApiSettings>()
    .Bind(builder.Configuration.GetSection(nameof(ApiSettings)));

services.AddHttpClient<IAssetServices, AssetServices>(
    (provider, client) =>
    {
        var apiSettings = GetApiSettings(provider);
        client.BaseAddress = new Uri($"{apiSettings.BaseUrl}{apiSettings.AssetsRoute}");
    });

services.AddHttpClient<IAssetTypeServices, AssetTypeServices>(
    (provider, client) =>
    {
        var apiSettings = GetApiSettings(provider);
        client.BaseAddress = new Uri($"{apiSettings.BaseUrl}{apiSettings.AssetTypesRoute}");
    });

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

await app.RunAsync();
return;

static ApiSettings GetApiSettings(IServiceProvider serviceProvider)
{
    var settingsOptions = serviceProvider.GetRequiredService<IOptions<ApiSettings>>();
    var settings = settingsOptions.Value;
    return settings;
}