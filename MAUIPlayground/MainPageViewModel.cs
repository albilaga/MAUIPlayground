using System.Windows.Input;

namespace MAUIPlayground;

public class MainPageViewModel : BindableBase
{
    public IReadOnlyList<int> Items { get; }
    public ICommand ClickCommand { get; }

    public MainPageViewModel(INavigationService navigationService)
    {
        ClickCommand = new DelegateCommand(() => navigationService.NavigateAsync(nameof(SecondPage)));
        Items = new[] { 1, 2, 3, 4, 5 };
    }
}