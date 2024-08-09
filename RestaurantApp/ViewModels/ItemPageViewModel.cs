namespace RestaurantApp.ViewModels
{
    [QueryProperty(nameof(MenuItems), nameof(MenuItems))]
    public partial class ItemPageViewModel : ObservableObject
    {
        public ItemPageViewModel() 
        {
        }
        
        [ObservableProperty]
        private MenuItems _menuItems;

        [RelayCommand]
        private void AddToCart() 
        {
            MenuItems.CartQuantity++;
        }

        [RelayCommand]
        private void RemoveFromCart()
        {
            if(MenuItems.CartQuantity > 0) 
            MenuItems.CartQuantity--;
        }

        [RelayCommand]
        private async Task ViewCart() 
        {
            if (MenuItems.CartQuantity > 0)
            {
                //go to cartpage
            }
            else
            {
                await Toast.Make("Please Add Items to the Cart", ToastDuration.Short).Show();
            }
        }

    }

}
