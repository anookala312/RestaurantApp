using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestaurantApp.Models;
using RestaurantApp.Pages;
using RestaurantApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        private readonly MenuItemService _menuitemService;
        public HomePageViewModel(MenuItemService menuitemService) 
        {
            _menuitemService = menuitemService;
            Items = new(_menuitemService.GetPopularMenuItems());
        }

        public ObservableCollection<MenuItems> Items { get; set; } 

        [RelayCommand]
        private async Task GoToAllMenuItemsPage(bool fromSearch = false)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(AllMenuItemsViewModel.FromSearch)] = fromSearch
            };
            await Shell.Current.GoToAsync(nameof(AllMenuItemsPage), animate: true, parameters);
        }
    }
}
