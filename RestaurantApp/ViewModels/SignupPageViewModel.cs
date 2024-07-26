using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    internal class SignupPageViewModel
    {
        private INavigation _navigation;

        public Command RegisterUserBtn { get; }

        public SignupPageViewModel(INavigation navigation) 
        { 
            this._navigation = navigation;
            RegisterUserBtn = new Command(RegisterUserTappedAsync);
        }

        private void RegisterUserTappedAsync(object obj)
        {
        }
    }
}
