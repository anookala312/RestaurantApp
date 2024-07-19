namespace RestaurantApp
{
    public partial class HomePage : ContentPage
    {
        
        public HomePage()
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
