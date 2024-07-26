using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Models
{
    internal class LoginPageViewModel
    {
        private INavigation _navigation;
        public Command RegisterBtn { get; }
        public Command LoginBtn { get; }
        public LoginPageViewModel(INavigation navigation) 
        {
            this._navigation = navigation;
            RegisterBtn = new Command(RegisterBtnTappedAsync);
            LoginBtn = new Command(LoginBtnTappedAsync);
        }

        private async void LoginBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new HomePage());
        }

        private async void RegisterBtnTappedAsync(object obj)
        {
            await this._navigation.PushAsync(new SignupPage());
        }
    }
}
