using RestaurantApp.ViewModels;

namespace RestaurantApp.Pages;

public partial class AllMenuItemsPage : ContentPage
{
	public AllMenuItemsPage(AllMenuItemsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}