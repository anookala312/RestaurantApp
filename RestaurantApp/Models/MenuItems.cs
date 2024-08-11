namespace RestaurantApp.Models
{
    public partial class MenuItems : ObservableObject
    {
        public string? Name { get; set; }
        public string? Image {  get; set; }
        public double? Price { get; set; }
        public string? Description { get; set; }

        [ObservableProperty, NotifyPropertyChangedFor(nameof(Amount))]
        private int _cartQuantity;

        public double Amount => (double)(CartQuantity * Price);

        public MenuItems Clone() => MemberwiseClone() as MenuItems;
    }
}
