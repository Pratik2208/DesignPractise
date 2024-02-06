using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using DesignPractise.Pages;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using DesignPractise.ViewModel;
using DesignPractise.Services;

namespace DesignPractise
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (h, v) =>
            {
                h.PlatformView.BackgroundTintList =
                    Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            });
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<UserViewModel>();
            builder.Services.AddSingleton<AuthService>();
#if DEBUG
            builder.Logging.AddDebug();
            
            
#endif
            return builder.Build();
        }
    }
}