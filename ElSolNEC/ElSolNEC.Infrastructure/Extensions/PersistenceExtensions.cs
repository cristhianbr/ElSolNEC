﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using ElSolNEC.Domain.Ports;
using ElSolNEC.Infrastructure.Adapters;
using System.Data;
using Npgsql;

namespace ElSolNEC.Infrastructure.Extensions
{
    public static class PersistenceExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, string stringConnection)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(ILogger<>), typeof(Logger<>));
            services.AddTransient<IDbConnection>(_ => new NpgsqlConnection(stringConnection));

            return services;
        }
    }
}
