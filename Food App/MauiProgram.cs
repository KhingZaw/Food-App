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
            builder.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("fontello.ttf", "Icons");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            })
            .UseMauiCommunityToolkit();

            var services = builder.Services;
#if DEBUG
            builder.Logging.AddDebug();

#endif
            services.AddSingleton<IConnectivity>(Connectivity.Current);

            services.AddSingleton<FoodService>();

            builder.Services.AddSingleton<MainViewModel>();
            builder.Services.AddSingleton<MainPage>(); 

            builder.Services.AddSingleton<HomeViewModel>();
            builder.Services.AddSingleton<HomePage>();

            builder.Services.AddSingleton<DetailViewModel>();
            builder.Services.AddSingleton<DetailPage>();
            
            builder.Services.AddSingleton<FavoriteViewModel>();
            builder.Services.AddSingleton<Favorites>();

            return builder.Build();
        }
    }
}