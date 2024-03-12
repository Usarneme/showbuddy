using Microsoft.Extensions.Logging;

namespace ShowBuddy;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

    string dbPath = FileAccessHelper.GetLocalFilePath("showbuddy.db3");
    builder.Services.AddSingleton<UserRepository>(s => ActivatorUtilities.CreateInstance<UserRepository>(s, dbPath));

#if DEBUG
		builder.Logging.AddDebug();
#endif


		return builder.Build();
	}
}
