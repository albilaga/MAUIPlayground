using DryIoc;
using Microsoft.Extensions.Logging;
using Prism.DryIoc;
using Prism.Regions.Adapters;
using Prism.Regions.Behaviors;

namespace MAUIPlayground;

internal static class PrismStartup
{
    public static void Configure(PrismAppBuilder builder)
    {
        builder.RegisterTypes(RegisterTypes)
            .ConfigureLogging(logging => logging.AddConsole())
            .OnInitialized(OnInitialized)
            .ConfigureRegionAdapters(ConfigureRegion)
            .ConfigureRegionBehaviors(ConfigureRegionBehaviors)
            .OnAppStart(nameof(MainPage));
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
        containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>()
            .RegisterInstance(SemanticScreenReader.Default)
            .RegisterInstance(DeviceInfo.Current)
            .RegisterInstance(Launcher.Default)
            .RegisterForRegionNavigation<MainContentView, MainContentViewModel>();
        
        var regionManager = containerRegistry.GetContainer().Resolve<IRegionManager>();
        regionManager.RegisterViewWithRegion(nameof(MainLazyView), typeof(LazyView<MainContentView>));
        // regionManager.RegisterViewWithRegion(nameof(MainLazyView))
    }

    private static void OnInitialized(IContainerProvider container)
    {
    }
}