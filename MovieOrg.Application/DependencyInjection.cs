﻿using Microsoft.Extensions.DependencyInjection;

namespace MovieOrg.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            return services;
        }
    }
}
