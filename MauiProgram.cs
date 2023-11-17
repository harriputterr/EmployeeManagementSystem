using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiDesktopApplicaton.Data;
using MauiDesktopApplicaton.Interface;

namespace MauiDesktopApplicaton;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		try
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			builder.Services.AddMauiBlazorWebView();
#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
#endif
			//Add Services
			builder.Services.AddSingleton<IEmployeeManagement, EmployeeManagement>();
			builder.Services.AddSingleton<EmployeeController>();
			builder.Services.AddSingleton<LoginController>();

            return builder.Build();
		}
		catch (Exception ex) 
		{
			return null;
		}
	}
}
