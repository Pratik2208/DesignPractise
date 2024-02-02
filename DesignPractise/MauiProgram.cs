using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DesignPractise.Pages;

namespace DesignPractise
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
#if DEBUG
            builder.Logging.AddDebug();
            builder.Services.AddTransient<MainPage>();
            
#endif
            return builder.Build();
        }
    }
}

//CFBR