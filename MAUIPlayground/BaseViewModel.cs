namespace MAUIPlayground;

public abstract class BaseViewModel : BindableBase
{
    public INavigationService NavigationService { get; }

    protected BaseViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
    }

    protected Task GoBackAsync() => MainThread.InvokeOnMainThreadAsync(NavigationService.GoBackAsync);

    protected Task NavigateAsync(string page) => MainThread.InvokeOnMainThreadAsync(()=>NavigationService.NavigateAsync(
        page, new NavigationParameters
        {
            { KnownNavigationParameters.Animated, false }
        }));
}