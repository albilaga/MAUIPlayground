namespace MAUIPlayground;

public partial class MainPage : ContentPage
{
    public MainPage(IRegionManager regionManager)
    {
        InitializeComponent();
        // regionManager.RegisterViewWithRegion(nameof(MainContentView), typeof(MainContentView));
    }
}