using EncoreTIX.Services;
using EncoreTIX.Services.IServices;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using EncoreTIX.Models;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace EncoreTIX;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        var stream = Assembly.GetExecutingAssembly()
                     .GetManifestResourceStream("EncoreTIX.appsettings.json");

        if (stream is null)
            throw new InvalidOperationException("Embedded appsettings.json not found. Check Build Action is 'Embedded Resource'.");

        var config = new ConfigurationBuilder()
            .AddJsonStream(stream)
            .Build();

        builder.Configuration.AddConfiguration(config);
        builder.Services.Configure<TicketmasterSettings>(config.GetSection("Ticketmaster"));


        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddHttpClient<ITicketmasterService, TicketmasterService>();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
