using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace Console.Template.Extensions.Logging;

public static class LoggingExtensions
{
    public static IHostApplicationBuilder ConfigureLogging(this IHostApplicationBuilder builder)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration)
            .CreateLogger();
        
        builder.Services.AddLogging();
        builder.Services.AddSerilog(logger);

        return builder;
    }
}