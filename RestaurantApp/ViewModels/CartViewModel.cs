﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.ViewModels
{
    public partial class CartViewModel : ObservableObject
    {
        public event EventHandler<MenuItems> CartItemRemoved;
        public event EventHandler<MenuItems> CartItemUpdated;
        public event EventHandler CartCleared;
        public ObservableCollection<MenuItems> Items { get; set; } = new ObservableCollection<MenuItems>();

        [ObservableProperty]
        private double _totalAmount;

        private void RecalculateTotalAmount() => TotalAmount = Items.Sum(i => i.Amount);

        [RelayCommand]
        private void UpdateCartItem(MenuItems menuItems)
        {
            var item = Items.FirstOrDefault(i => i.Name == menuItems.Name);
            if (item is not null)
            {
                item.CartQuantity = menuItems.CartQuantity;
            }
            else
            {
                Items.Add(menuItems.Clone());
            }
            RecalculateTotalAmount();
        }

        [RelayCommand]
        private async void RemoveCartItem(string name)
        {
            var item = Items.FirstOrDefault(i => i.Name == name);
            if (item is not null)
            {
                Items.Remove(item);
                RecalculateTotalAmount();

                CartItemRemoved?.Invoke(this, item);

                var snackbarOptions = new SnackbarOptions
                {
                    CornerRadius = 10,
                    BackgroundColor = Colors.PaleGoldenrod
                };
                var snackbar = Snackbar.Make($"'{item.Name}' removed from Cart",
                    () =>
                    {
                        Items.Add(item);
                        RecalculateTotalAmount();
                        CartItemUpdated?.Invoke(this, item);
                    }, "Undo", TimeSpan.FromSeconds(5), snackbarOptions);
                await snackbar.Show();
            }
        }

        [RelayCommand]
        private async void ClearCart()
        {
            if (await Shell.Current.DisplayAlert("Confirm Clear Cart?", "Do you want to Clear all Items in the Cart", "Yes", "No"))
            {
                Items.Clear();
                RecalculateTotalAmount();
                CartCleared?.Invoke(this, EventArgs.Empty);
                await Toast.Make("Cart Cleared", ToastDuration.Short).Show();
            }
        }

        [RelayCommand]
        private async Task PlaceOrder()
        {
            Items.Clear();
            RecalculateTotalAmount();
            CartCleared?.Invoke(this, EventArgs.Empty);
            await Shell.Current.GoToAsync(nameof(CheckoutPage), animate: true);
        }
    }
}