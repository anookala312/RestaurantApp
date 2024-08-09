using CommunityToolkit.Maui;
using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using Firebase.Auth.Providers;
using Firebase.Auth;
using RestaurantApp.Pages;
using RestaurantApp.ViewModels;
using RestaurantApp.Models;
using RestaurantApp.Services;


namespace RestaurantApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkitMarkup()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton(new FirebaseAuthClient(new FirebaseAuthConfig() 
            {
                AuthDomain = "laura-cafe-e050d.firebaseapp.com",
                ApiKey = "AIzaSyCago6E_opuoxqR1apPjZhFvoAhITpGzks",
                Providers = new FirebaseAuthProvider[] 
                { 
                    new EmailProvider()
                }
            }));

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<SignupPage>();
            builder.Services.AddSingleton<SignupPageViewModel>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<HomePage>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<MenuItemService>();
            builder.Services.AddTransientWithShellRoute<AllMenuItemsPage,AllMenuItemsViewModel>(nameof(AllMenuItemsPage));
            builder.Services.AddTransientWithShellRoute<ItemPage, ItemPageViewModel>(nameof(ItemPage));

            return builder.Build();
        }
    }
}
