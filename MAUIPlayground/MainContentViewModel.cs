using System.Windows.Input;

namespace MAUIPlayground;

public class MainContentViewModel : BindableBase
{
    private ItemViewModel? _selectedItem;

    public IReadOnlyList<ItemViewModel> Items { get; }
    public ICommand SelectItemCommand { get; }

    public MainContentViewModel(IEventAggregator eventAggregator)
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

        SelectItemCommand = new Command<ItemViewModel>(selectedItem =>
        {
            if (_selectedItem == selectedItem)
            {
                return;
            }

            foreach (var item in Items)
            {
                item.IsSelected = item == selectedItem;
            }

            _selectedItem = selectedItem;
            eventAggregator.GetEvent<SelectedItemChanged>().Publish(_selectedItem);
        });
    }
}