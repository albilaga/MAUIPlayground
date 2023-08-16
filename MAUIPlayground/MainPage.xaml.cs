
namespace MAUIPlayground;

public partial class MainPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        // await Task.Delay(3000).ConfigureAwait(true);
        // await _lazyView.LoadViewAsync();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new SecondPage());
    }
}