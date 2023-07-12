using System.Windows.Input;

namespace MAUIPlayground;

public class SecondPageViewModel : BaseViewModel
{
    private ICommand? _clickCommand;
    public ICommand ClickCommand => _clickCommand ??= new DelegateCommand(() => GoBackAsync());

    public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        // ClickCommand = new DelegateCommand(() => GoBackAsync());
    }
}