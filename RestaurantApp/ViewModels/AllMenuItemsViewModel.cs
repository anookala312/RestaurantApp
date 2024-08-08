using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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
    [QueryProperty(nameof(FromSearch), nameof(FromSearch))]
    public partial class AllMenuItemsViewModel : ObservableObject
    {
        private readonly MenuItemService _menuItemService;
        public AllMenuItemsViewModel(MenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
            MenuItems = new(_menuItemService.GetAllMenuItems());
        }

        public ObservableCollection<MenuItems> MenuItems { get; set; }

        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty]
        private bool _searching;

        [RelayCommand]
        private async Task SearchMenuitems(string searchTerm) 
        {
            MenuItems.Clear();
            Searching = true;
            await Task.Delay(1000);
            foreach (var menuItem in _menuItemService.SearchMenuItems(searchTerm)) 
            {
                MenuItems.Add(menuItem);
            }
            Searching = false;
        }
    }
}
