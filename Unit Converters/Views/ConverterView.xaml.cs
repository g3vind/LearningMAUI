using Unit_Converters.ViewModels;

namespace Unit_Converters.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConverterViewModel();
	}
}