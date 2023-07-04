using Microsoft.Extensions.Logging;
namespace MauiSampleAppFirst;

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
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
         .ConfigureMauiHandlers((handlers) =>
          {
#if ANDROID
                handlers.AddHandler(typeof(MauiSampleAppFirst.Controls.CustomHtmlLabel), typeof(MauiSampleAppFirst.Platforms.Android.CustomRenderer.CustomHtmlLabelRenderer));
#elif IOS
              //handlers.AddHandler(typeof(PressableView), typeof(XamarinCustomRenderer.iOS.Renderers.PressableViewRenderer));
#endif
          });

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
