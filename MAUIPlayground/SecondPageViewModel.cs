using System.Windows.Input;

namespace MAUIPlayground;

public class SecondPageViewModel : BindableBase
{
    public ICommand GoBack { get; }

    public SecondPageViewModel(INavigationService navigationService)
    {
        GoBack = new DelegateCommand(() => navigationService.GoBackAsync());
    }
}