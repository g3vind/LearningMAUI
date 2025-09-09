using NavigationDemo.MVVM.ViewModels;

namespace NavigationDemo.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}
}