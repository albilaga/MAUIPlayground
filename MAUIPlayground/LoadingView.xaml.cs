using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIPlayground;

public partial class LoadingView : ContentView
{
    
    public LoadingView()
    {
        InitializeComponent();
    }

    /*private async void Test(IRegionManager regionManager,INavigationService navigationService)
    {
        await Task.Delay(TimeSpan.FromSeconds(5)).ConfigureAwait(true);
        navigationService.NavigateAsync()
    }*/
}