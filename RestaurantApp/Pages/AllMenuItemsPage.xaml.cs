namespace RestaurantApp.Pages;

public partial class AllMenuItemsPage : ContentPage
{
	private readonly AllMenuItemsViewModel _allMenuItemsViewModel;
	public AllMenuItemsPage(AllMenuItemsViewModel allMenuItemsViewModel)
	{
		InitializeComponent();
		_allMenuItemsViewModel = allMenuItemsViewModel;
		BindingContext = allMenuItemsViewModel;
	}
	
	protected override async void OnAppearing() 
	{ 
		base.OnAppearing();
		if (_allMenuItemsViewModel.FromSearch) 
		{ 
			await Task.Delay(1000);
			searchBar.Focus();
		}
	}
	void searchBar_TextChanged(object sender, TextChangedEventArgs e) 
	{
		if(!string.IsNullOrWhiteSpace(e.OldTextValue) && string.IsNullOrWhiteSpace(e.NewTextValue)) 
		{
            _allMenuItemsViewModel.SearchMenuitemsCommand.Execute(null);
        }
	}
}