using System.Windows.Input;

namespace MAUIPlayground;

public class MainPageViewModel : BindableBase
{
    private string _text;

    public string Text
    {
        get => _text;
        private set => SetProperty(ref _text, value);
    }

    public MainPageViewModel()
    {
        var timer = Application.Current!.Dispatcher.CreateTimer();
        var now = DateTime.Now;
        timer.Tick += (sender, args) =>
        {
            var currentTime = DateTime.Now;
            var seconds = (int)(currentTime - now).TotalSeconds;
            Text = seconds % 2 == 0
                ? "This is even second."
                : "This is odd second.";
        };
        timer.Start();
    }
}