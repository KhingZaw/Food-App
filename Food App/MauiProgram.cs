using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Food_App.ViewModel;
using Food_App.Services;
using Food_App.View;

namespace Food_App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("fontello.ttf", "Icons");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

            var services = builder.Services;
#if DEBUG
            builder.Logging.AddDebug();

#endif
            services.AddSingleton<IConnectivity>(Connectivity.Current);

            services.AddSingleton<FoodService>();

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<MainPage>(); 

            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<HomePage>();

            builder.Services.AddTransient<DetailViewModel>();
            builder.Services.AddTransient<DetailPage>();
            
            builder.Services.AddTransient<FavoriteViewModel>();
            builder.Services.AddTransient<Favorites>();

            builder.Services.AddTransient<AllFoodsViewModel>();
            builder.Services.AddTransient<AllFoodsPage>();

            builder.Services.AddTransient<CheckOutViewModel>();
            builder.Services.AddTransient<CheckOutPage>();

            return builder.Build();
        }
    }
}