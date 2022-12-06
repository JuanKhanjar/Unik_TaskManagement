
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Graph;
using Unik_TaskManagement.Persistence.Data;

namespace Unik_TaskManagement.Api.InitialMigration
{
	public static class MigrationManager
	{
		public static IHost MigrateDatabase ( this IHost webApp )
		{
			using (var scope = webApp.Services.CreateScope( ))
			{
				using (var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>( ))
				{
					try
					{
						appContext.Database.Migrate( );
					}
					catch (Exception ex)
					{
						//Log errors or do anything you think it's needed
						throw;
					}
				}
			}
			return webApp;
		}
	}
}
