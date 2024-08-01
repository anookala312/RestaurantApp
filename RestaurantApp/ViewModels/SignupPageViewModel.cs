using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using RestaurantApp.Pages;
namespace RestaurantApp.ViewModels
{
    public partial class SignupPageViewModel : ObservableObject
    {
        private readonly FirebaseAuthClient _authClient;

        [ObservableProperty]
        private string? _username;

        [ObservableProperty]
        private string? _email;

        [ObservableProperty]
        private string? _password;
        public SignupPageViewModel(FirebaseAuthClient authClient)
        {
            _authClient = authClient;
        }

        [RelayCommand]
        private async Task Register()
        {
            await _authClient.CreateUserWithEmailAndPasswordAsync(Email, Password);
            await Shell.Current.GoToAsync("//Login");
        }

        [RelayCommand]
        private async Task NavigateLogin()
        {
            await Shell.Current.GoToAsync("//Login");
        }
    }
}
