using RestaurantApp.Models;

namespace RestaurantApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new LoginPageViewModel(Navigation);
    }
}