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
}