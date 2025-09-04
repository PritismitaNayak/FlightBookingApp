using Microsoft.AspNetCore.Identity;
using System;

namespace AuthService.Extensions
{
	public static class ServiceExtension
	{
		public static void ConfigureDIServices(this IServiceCollection services)
		{
			services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
			services.AddScoped<JwtService>();
			
		}
	}
}
