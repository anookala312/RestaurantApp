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
        
        [RelayCommand]
        private async Task GoToItemPage(MenuItems menuItems)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(ItemPageViewModel.MenuItems)] = menuItems
            };
            await Shell.Current.GoToAsync(nameof(ItemPage), animate: true, parameters);
        }
    }
}
