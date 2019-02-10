﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Application.User
{
    public static class Setup
	{

		public static void SetupApplicationUser(this IServiceCollection services, string connectionString)
		{
			
			// Establish database connection
			services.AddEntityFrameworkNpgsql().AddDbContext<Context.UserContext>(options => options.UseNpgsql(connectionString));

			// Add service
			services.AddScoped<Services.IUserService, Services.UserService>();
		}
	}
}