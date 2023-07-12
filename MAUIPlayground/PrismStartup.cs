using DryIoc;
using Microsoft.Extensions.Logging;
using Prism.DryIoc;
using Prism.Regions.Adapters;
using Prism.Regions.Behaviors;
using IContainer = DryIoc.IContainer;

namespace MAUIPlayground;

internal static class PrismStartup
{
    public static IContainer Container { get; private set; }

    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .ConfigureLogging(logging => logging.AddConsole())
            .OnInitialized(OnInitialized)
            .ConfigureRegionAdapters(ConfigureRegion)
            .ConfigureRegionBehaviors(ConfigureRegionBehaviors)
            .OnAppStart(nameof(LoadingPage));
    }

    private static void ConfigureRegionBehaviors(IRegionBehaviorFactory obj)
    {
        // obj.
    }

    private static void ConfigureRegion(RegionAdapterMappings obj)
    {
        // obj.
    }

    private static void RegisterTypes(IContainerRegistry containerRegistry)
    {
        containerRegistry
            .RegisterInstance(SemanticScreenReader.Default)
            .RegisterInstance(DeviceInfo.Current)
            .RegisterInstance(Launcher.Default)
            .RegisterForNavigation<LoadingPage>()
            .RegisterForNavigation<MainPage>()
            .RegisterForNavigation<SecondPage>()
            .Register<MainContentView>()
            .Register<MainContentViewModel>()
            .Register<SecondContentView>()
            .Register<SecondContentViewModel>();

        Container = containerRegistry.GetContainer();
    }

    private static void OnInitialized(IContainerProvider container)
    {
    }
}