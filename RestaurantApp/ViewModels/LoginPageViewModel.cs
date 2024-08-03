using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Microsoft.Toolkit.Mvvm.Input;
using RestaurantApp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    public partial class LoginPageViewModel : ObservableObject
    {
        private readonly FirebaseAuthClient _authClient;

        [ObservableProperty]
        private string? _email;

        [ObservableProperty]
        private string? _password;
        public LoginPageViewModel(FirebaseAuthClient authClient)
        {
            _authClient = authClient;
        }
        public string? Username => _authClient.User?.Info?.DisplayName;

        [RelayCommand]
        private async Task Login() 
        {
            try
            {
                await _authClient.SignInWithEmailAndPasswordAsync(Email, Password);

                OnPropertyChanged(nameof(Username));
                await Shell.Current.GoToAsync("//Home");
            }
            catch (Exception ex) 
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Invalid email or password.", "OK");
            }

        }

        [RelayCommand]
        private async Task NavigateSignUp() 
        {
            await Shell.Current.GoToAsync("//Register");
        }


    }
}
