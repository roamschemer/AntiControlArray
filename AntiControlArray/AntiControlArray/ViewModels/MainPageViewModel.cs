using Prism.Navigation;
using Reactive.Bindings;
using System;
using Xamarin.Forms;
//using System.Drawing; ← これは罠

namespace AntiControlArray.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        public ReactiveCommand Command { get; } = new ReactiveCommand();
        public ReactiveProperty<string> Text { get; set; } = new ReactiveProperty<string>();
        public ReactiveProperty<Color> TextColor { get; set; } = new ReactiveProperty<Color>();
        public ReactiveProperty<Color> BackgroundColor { get; set; } = new ReactiveProperty<Color>();

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Text.Value = "まだ押してないよ！";
            TextColor.Value = Color.Black;
            BackgroundColor.Value = Color.Pink;

            Command.Subscribe(_ =>
            {
                Text.Value = "今押したよ！";
                TextColor.Value = Color.Red;
                BackgroundColor.Value = Color.Yellow;
            });
        }
    }
}
