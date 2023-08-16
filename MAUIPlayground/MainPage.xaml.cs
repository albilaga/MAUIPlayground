using CommunityToolkit.Maui.Views;

namespace MAUIPlayground;

public partial class MainPage
{
    // private readonly LazyView<LazyTestView> _lazyView;
    public MainPage()
    {
        InitializeComponent();
        // _lazyView = new LazyView<LazyTestView>();
        // Content = _lazyView;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // await Task.Delay(3000).ConfigureAwait(true);
        // await _lazyView.LoadViewAsync();
    }
}