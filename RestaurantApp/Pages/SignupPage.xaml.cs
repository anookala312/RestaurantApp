using RestaurantApp.ViewModels;

namespace RestaurantApp;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
		BindingContext = new SignupPageViewModel(Navigation);
	}
} 