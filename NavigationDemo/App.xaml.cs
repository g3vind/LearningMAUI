using NavigationDemo.MVVM.Views;

namespace NavigationDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MenuView());
        }
    }
}