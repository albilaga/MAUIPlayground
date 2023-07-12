using System.Windows.Input;

namespace MAUIPlayground;

public class SecondContentViewModel : BaseViewModel
{
    public ICommand ClickCommand { get; }

    public SecondContentViewModel(INavigationService navigationService, IDeviceInfo deviceInfo) : base(
        navigationService)
    {
        ClickCommand = new DelegateCommand(() => GoBackAsync());
        Console.WriteLine(deviceInfo);
    }
}