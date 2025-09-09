using Unit_Converters.Views;

namespace Unit_Converters
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new ConverterView());
        }
    }
}