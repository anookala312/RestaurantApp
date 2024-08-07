using CommunityToolkit.Mvvm.ComponentModel;
using RestaurantApp.Models;
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
            Items = new(_menuitemService.GetOnSaleMenuItems());
        }

        public ObservableCollection<MenuItems> Items { get; set; }

    }
}
