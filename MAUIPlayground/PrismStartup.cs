using Microsoft.Extensions.Logging;

namespace MAUIPlayground;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .ConfigureLogging(logging => logging.AddConsole())
            .OnInitialized(OnInitialized)
            .OnAppStart(nameof(MainPage));
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>()
            .RegisterInstance(SemanticScreenReader.Default)
            .RegisterInstance(DeviceInfo.Current)
            .RegisterInstance(Launcher.Default);
        ViewModelLocationProvider.Register<MainContentView, MainContentViewModel>();
    }

    private static void OnInitialized(IContainerProvider container)
    {
    }
}