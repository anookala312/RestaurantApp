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
