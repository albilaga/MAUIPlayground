namespace MAUIPlayground;

public partial class MainContentView : IViewModelAware
{
    public Type ViewModelType => typeof(MainContentViewModel);

    public MainContentView()
    {
        InitializeComponent();
    }
}