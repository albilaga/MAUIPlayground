using Microsoft.Extensions.Logging;

namespace MAUIPlayground;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .ConfigureLogging(logging => logging.AddConsole())
            .OnInitialized(OnInitialized)
            .OnAppStart($"{nameof(NavigationPage)}/{nameof(MainPage)}");
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry.RegisterForNavigation<MainPage>()
            .RegisterForNavigation<SecondPage>()
            .RegisterInstance(SemanticScreenReader.Default)
            .RegisterInstance(DeviceInfo.Current)
            .RegisterInstance(Launcher.Default);
    }

    private static void OnInitialized(IContainerProvider container)
    {
    }
}