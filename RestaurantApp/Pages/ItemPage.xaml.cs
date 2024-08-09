namespace RestaurantApp.Pages;

public partial class ItemPage : ContentPage
{
	private readonly ItemPageViewModel _itemPageViewModel;
	public ItemPage(ItemPageViewModel itemPageViewModel)
	{
		_itemPageViewModel = itemPageViewModel;

        InitializeComponent();
		BindingContext = _itemPageViewModel;
	}

    private async void ImageButton_CLicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync("..", animate: true);
    }

    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);
        Behaviors.Add(new CommunityToolkit.Maui.Behaviors.StatusBarBehavior
        { 
            StatusBarColor = Colors.DarkGoldenrod,
            StatusBarStyle = CommunityToolkit.Maui.Core.StatusBarStyle.LightContent
        });
    }
}