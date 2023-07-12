namespace MAUIPlayground;

public partial class SecondContentView : ContentView, IViewModelAware
{
    public SecondContentView()
    {
        InitializeComponent();
    }

    public Type ViewModelType => typeof(SecondContentViewModel);
}