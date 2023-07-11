using RegionManager = Prism.Regions.Xaml.RegionManager;

namespace MAUIPlayground;

public class MainLazyView : ContentView
{
    public MainLazyView()
    {
        RegionManager.SetRegionName(this,nameof(MainLazyView));
        RegionManager.SetDefaultView(this,typeof(LazyView<MainContentView>));
    }
}