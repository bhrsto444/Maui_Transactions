using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using TokoviNovca.Repositories;
using TokoviNovca.MVVM.Models;
namespace TokoviNovca
{
    public static class MauiProgram
    {
        // Inicijalizacija SQLitePCL biblioteke
        //SQLitePCL.Batteries_V2.Init();
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Roboto-Black.ttf", "Strong");
                    fonts.AddFont("LibreFranklin-Regular.ttf", "Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif      
            builder.Services.AddSingleton<BaseRepository<Transaction>>();

            return builder.Build();
        }
    }
}
