using RestaurantApp.ViewModels;

namespace RestaurantApp.Pages;

public partial class SignupPage : ContentPage
{
	public SignupPage(SignupPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
} 