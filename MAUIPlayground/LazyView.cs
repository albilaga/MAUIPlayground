using DryIoc;

namespace MAUIPlayground;

public class LazyView<TView> : ContentView
    where TView : ContentView, new()
{
    public ContentPage? ParentPage { get; set; }

    public LazyView()
    {
        Content = new LoadingView();
        Initialize();
    }

    private async void Initialize()
    {
        await Task.Delay(3000);
        var view = PrismStartup.Container.Resolve<TView>();
        if (view.BindingContext is null && view is IViewModelAware viewModelAware)
        {
            if (ParentPage?.BindingContext is BaseViewModel baseViewModel)
            {
                view.BindingContext = PrismStartup.Container.Resolve(viewModelAware.ViewModelType,
                    args: new object[]{baseViewModel.NavigationService});
            }
            else
            {
                view.BindingContext = PrismStartup.Container.Resolve(viewModelAware.ViewModelType);
            }
        }

        Content = view;
    }
}