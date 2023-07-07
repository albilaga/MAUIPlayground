using System.Windows.Input;

namespace MAUIPlayground;

public class SelectedItemChanged : PubSubEvent<ItemViewModel>
{
}

public class MainPageViewModel : BindableBase, IDestructible
{
    private ItemViewModel _selectedItem;
    private readonly SubscriptionToken _subscriptionToken;


    private bool _isValid;

    public bool IsValid
    {
        get => _isValid;
        private set => SetProperty(ref _isValid, value);
    }

    public ICommand ContinueCommand { get; }

    public MainPageViewModel(IPageDialogService pageDialogService, IEventAggregator eventAggregator)
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

            pageDialogService.DisplayAlertAsync("Success", $"Selected item is {_selectedItem.Name}", "Ok");
        });
    }

    public void Destroy()
    {
        _subscriptionToken.Dispose();
    }
}