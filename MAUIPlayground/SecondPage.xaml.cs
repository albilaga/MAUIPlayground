namespace MAUIPlayground;

public partial class SecondPage : ContentPage
{
    public SecondPage()
    {
        InitializeComponent();
    }

    protected override bool OnBackButtonPressed()
    {
        System.Diagnostics.Debugger.Break();
        return base.OnBackButtonPressed();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}