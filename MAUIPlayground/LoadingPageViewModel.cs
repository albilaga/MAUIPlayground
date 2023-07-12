namespace MAUIPlayground;

public class LoadingPageViewModel : BaseViewModel,IInitialize
{
    public LoadingPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    public async void Initialize(INavigationParameters parameters)
    {
        await Task.Delay(3000).ConfigureAwait(true);
        await NavigateAsync($"/{nameof(MainPage)}");
    }
}