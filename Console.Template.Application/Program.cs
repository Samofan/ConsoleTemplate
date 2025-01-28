using Console.Template.Application;
using Console.Template.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile(Constants.SettingsFile);
builder.ConfigureLogging();

var host = builder.Build();

await host.RunAsync();