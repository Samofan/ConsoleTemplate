using Console.Template.Application;
using Console.Template.Application.Settings;
using Console.Template.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Configuration.AddJsonFile(Constants.SettingsFile);
builder.ConfigureLogging();

builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection(SettingsSections.ApplicationSettings));

builder.Services.AddTransient<TitleService>();

var host = builder.Build();

var titleService = host.Services.GetService<TitleService>()!;
titleService.ShowTitle();
