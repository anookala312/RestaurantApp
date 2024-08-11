namespace RestaurantApp.ViewModels
{
    [QueryProperty(nameof(MenuItems), nameof(MenuItems))]
    public partial class ItemPageViewModel : ObservableObject, IDisposable
    {
        private readonly CartViewModel _cartViewModel;
        public ItemPageViewModel(CartViewModel cartViewModel) 
        {
            _cartViewModel = cartViewModel;
            _cartViewModel.CartCleared += OnCartCleared;
            _cartViewModel.CartItemRemoved += OnCartItemRemoved;
            _cartViewModel.CartItemUpdated += OnCartItemUpdated;

        }

        private void OnCartCleared(object? _, EventArgs e) => MenuItems.CartQuantity = 0;

        private void OnCartItemRemoved(object? _, MenuItems p) => OnCartItemChanged(p, 0);
        private void OnCartItemUpdated(object? _, MenuItems p) => OnCartItemChanged(p, p.CartQuantity);
        private void OnCartItemChanged(MenuItems p, int quantity) 
        {
            if(p.Name == MenuItems.Name) 
            {
                MenuItems.CartQuantity = quantity;
            }
        }
        
        [ObservableProperty]
        private MenuItems _menuItems;

        [RelayCommand]
        private void AddToCart() 
        {
            MenuItems.CartQuantity++;
            _cartViewModel.UpdateCartItemCommand.Execute(MenuItems);
        }

        [RelayCommand]
        private void RemoveFromCart()
        {
            if (MenuItems.CartQuantity > 0)
            {
                MenuItems.CartQuantity--;
                _cartViewModel?.UpdateCartItemCommand.Execute(MenuItems);
            }
        }

        [RelayCommand]
        private async Task ViewCart() 
        {
            if (MenuItems.CartQuantity > 0)
            {
                await Shell.Current.GoToAsync(nameof(CartPage), animate: true);
            }
            else
            {
                await Toast.Make("Please Add Items to the Cart", ToastDuration.Short).Show();
            }
        }
        public void Dispose() 
        {
            _cartViewModel.CartCleared -= OnCartCleared;
            _cartViewModel.CartItemRemoved -= OnCartItemRemoved;
            _cartViewModel.CartItemUpdated -= OnCartItemUpdated;
        }

    }

}
