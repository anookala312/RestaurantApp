namespace RestaurantApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnLoginClicked(object sender, EventArgs e)
        {

                LoginButton.Text = $"Logged In";


            SemanticScreenReader.Announce(LoginButton.Text);
        }
    }

}
