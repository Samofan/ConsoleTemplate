using Console.Template.Application.Settings;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Spectre.Console;

namespace Console.Template.Application;

internal class TitleService(IOptions<ApplicationSettings> applicationSettings,
    ILogger<TitleService> logger)
{
    internal void ShowTitle()
    {
        var title = applicationSettings.Value.Title;
        
        logger.LogInformation("Showing string '{title} on console", title);
        
        AnsiConsole.Write(
            new FigletText(title)
                .LeftJustified()
                .Color(Color.Red));
    }
}