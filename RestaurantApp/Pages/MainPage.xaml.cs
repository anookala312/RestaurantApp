using RestaurantApp.Models;

namespace RestaurantApp.Pages;

public partial class MainPage : ContentPage
{
    public MainPage(LoginPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }


}