namespace MAUIPlayground;

public class ItemViewModel : BindableBase
{
    public string Name { get; }
    public ItemViewModel(string name)
    {
        Name = name;
    }
    

    private bool _isSelected;
    public bool IsSelected
    {
        get => _isSelected;
        set => SetProperty(ref _isSelected, value);
    }
}