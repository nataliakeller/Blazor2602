using CLED.Artic.Web.Components;
using CLED.Artic.Web.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

builder.Services.AddHttpClient();

builder.Services.AddScoped<IArtworksService, ArtworksService>();
//builder.Services.AddScoped<IArtworksService, FakeArtworksService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.Use((context, next) =>
//{
//    next.Invoke();
//    return Task.CompletedTask;
//});

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

//app.MapGet("/", () =>
//{
//    return "Hello World!";
//});

app.Run();
