namespace MAUIPlayground;

public class LazyView<TView> : ContentView
    where TView : ContentView, new()
{
    public LazyView()
    {
        Content = new LoadingView();
        Initialize();
    }

    private async void Initialize()
    {
        await Task.Delay(3000);
        Content = new TView();
    }
}