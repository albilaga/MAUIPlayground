namespace MAUIPlayground;

public abstract class BaseViewModel : BindableBase
{
    private readonly INavigationService _navigationService;

    protected BaseViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
    }

    protected Task GoBackAsync() => MainThread.InvokeOnMainThreadAsync(_navigationService.GoBackAsync);

    protected Task NavigateAsync(string page) => MainThread.InvokeOnMainThreadAsync(()=>_navigationService.NavigateAsync(
        page, new NavigationParameters
        {
            { KnownNavigationParameters.Animated, false }
        }));
}