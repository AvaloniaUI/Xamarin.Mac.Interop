using Avalonia;
using Avalonia.Markup.Xaml;

namespace Xamarin.Mac.Interop
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
