using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public partial class CheckoutViewModel
    {
        [RelayCommand]
        private async Task BacktoHome()
        {
            await Shell.Current.GoToAsync("//Home");
        }
    }
}
