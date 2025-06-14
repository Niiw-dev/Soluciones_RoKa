using DotNetEnv;
using Microsoft.AspNetCore.ResponseCompression;
using RoKa.Components;
using RoKa.Domain.Services;
using RoKa.Application.Interfaces;
// using Serilog;

Env.Load();

// Log.Logger = new LoggerConfiguration()
//     .MinimumLevel.Debug()
//     .Enrich.FromLogContext()
//     .WriteTo.Console()
//     .WriteTo.File("Logs/Logs.txt", rollingInterval: RollingInterval.Day)
//     .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

// builder.Host.UseSerilog();
builder.Services.AddSignalR();
builder.Services.AddHttpClient();
builder.Services.AddControllers();

builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
        [ "application/octet-stream" ]);
});

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.AddHttpClient("MiApi", client =>
{
    client.BaseAddress = new Uri("http://localhost:5090/");
});

var app = builder.Build();

app.MapControllers();

// app.UseSerilogRequestLogging();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();