using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace MAUIPlayground;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
        On<iOS>().SetUseSafeArea(true);
    }

    // protected override void OnSizeAllocated(double width, double height)
    // {
    //     base.OnSizeAllocated(width, height);
    //     Console.WriteLine($"Boxview Height: {BoxView.Height}");
    // }
}