using System.Windows.Input;

namespace MAUIPlayground;

public class SelectedItemChanged : PubSubEvent<ItemViewModel>
{
}

public class MainPageViewModel : BaseViewModel, IDestructible
{
    private ItemViewModel? _selectedItem;
    
    private readonly SubscriptionToken _subscriptionToken;


    private bool _isValid;

    public bool IsValid
    {
        get => _isValid;
        private set => SetProperty(ref _isValid, value);
    }

    public ICommand ContinueCommand { get; }

    public MainPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(
        navigationService)
    {
        _subscriptionToken = eventAggregator.GetEvent<SelectedItemChanged>()
            .Subscribe(selectedItem =>
            {
                _selectedItem = selectedItem;
                IsValid = true;
            });
        ContinueCommand = new Command(() =>
        {
            if (_selectedItem is null)
            {
                return;
            }

            NavigateAsync(nameof(SecondPage));
        });
    }

    public void Destroy()
    {
        _subscriptionToken.Dispose();
    }
}