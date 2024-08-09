namespace RestaurantApp.Pages;

public partial class CheckoutPage : ContentPage
{
	public CheckoutPage(CheckoutViewModel checkoutViewModel)
	{
		InitializeComponent();
		BindingContext = checkoutViewModel;
	}
}