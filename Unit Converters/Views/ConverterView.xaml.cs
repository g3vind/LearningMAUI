using Unit_Converters.ViewModels;

namespace Unit_Converters.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConverterViewModel();
	}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
		var vm = (ConverterViewModel)BindingContext;
		vm.Convert();
    }

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        var vm = (ConverterViewModel)BindingContext;
        vm.Convert();
    }
}