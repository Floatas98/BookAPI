using BookApp.Components;
using BookApp.Components.Services;
using BookApp.Components.Services.Interface;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient<IHttpClientService, HttpClientService>();
builder.Services.AddSingleton<OpenLibraryService>();
builder.Services.AddScoped<WishlistService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

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

app.Run();
