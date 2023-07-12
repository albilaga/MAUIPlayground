using System.Windows.Input;

namespace MAUIPlayground;

public class SecondContentViewModel : BaseViewModel
{
    public ICommand ClickCommand { get; }
    public SecondContentViewModel(INavigationService navigationService) : base(navigationService)
    {
        ClickCommand = new DelegateCommand(() => GoBackAsync());
    }
}