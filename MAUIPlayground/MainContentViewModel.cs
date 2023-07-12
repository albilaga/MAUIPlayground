using System.Windows.Input;

namespace MAUIPlayground;

public class MainContentViewModel : BaseViewModel
{
    private ItemViewModel? _selectedItem;

    public IReadOnlyList<ItemViewModel> Items { get; }
    private ICommand? _selectItemCommand;
    // public ICommand SelectItemCommand { get; }
    public ICommand SelectItemCommand =>
        _selectItemCommand ??= new DelegateCommand(() => NavigateAsync(nameof(SecondPage)));

    public MainContentViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(
        navigationService)
    {
        Items = new[]
        {
            new ItemViewModel("Item 1"),
            new ItemViewModel("Item 2"),
            new ItemViewModel("Item 3"),
            new ItemViewModel("Item 4"),
            new ItemViewModel("Item 5"),
            new ItemViewModel("Item 6"),
            new ItemViewModel("Item 7"),
            new ItemViewModel("Item 8"),
            new ItemViewModel("Item 9"),
        };

//         SelectItemCommand = new Command<ItemViewModel>(selectedItem =>
//         {
//             NavigateAsync(nameof(SecondPage));
//             /*if (_selectedItem == selectedItem)
//             {
//                 return;
//             }
//
//             foreach (var item in Items)
//             {
//                 item.IsSelected = item == selectedItem;
//             }
//
//             _selectedItem = selectedItem;
//             eventAggregator.GetEvent<SelectedItemChanged>().Publish(_selectedItem);*/
//         });
    }
}