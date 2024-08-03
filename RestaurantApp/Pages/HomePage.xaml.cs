using RestaurantApp.ViewModels;

namespace RestaurantApp.Pages;

public partial class HomePage : ContentPage
{
	public HomePage(HomePageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}