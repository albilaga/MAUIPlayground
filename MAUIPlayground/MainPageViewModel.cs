using System.Windows.Input;

namespace MAUIPlayground;

public class MainPageViewModel : BindableBase
{
    private readonly IDeviceInfo _deviceInfo;

    private bool _isValid;

    public bool IsValid
    {
        get => _isValid;
        private set
        {
            if (SetProperty(ref _isValid, value))
            {
                RaisePropertyChanged(nameof(IsNotValid));
            }
        }
    }

    public bool IsNotValid => !IsValid;

    private ICommand _clickCommand;
    public ICommand ClickCommand => _clickCommand ??= new Command(() => IsValid = true);

    public MainPageViewModel(IDeviceInfo deviceInfo)
    {
        _deviceInfo = deviceInfo;
        RaisePropertyChanged(nameof(IsNotValid));
    }
}