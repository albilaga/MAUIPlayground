using System.Windows.Input;

namespace MAUIPlayground;

public class MainPageViewModel : BindableBase
{
    public ICommand ClickCommand { get; }

    public MainPageViewModel(INavigationService navigationService)
    {
        ClickCommand = new DelegateCommand(() => navigationService.NavigateAsync(nameof(SecondPage)));
    }
}