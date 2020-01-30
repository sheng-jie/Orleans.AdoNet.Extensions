using System;
using Microsoft.Extensions.DependencyInjection;
using Orleans.Configuration;
using Orleans.Hosting;

namespace Orleans.AdoNet.Persistence
{
    public static class AdoNetStorageExtensions
    {
        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
          this ISiloHostBuilder builder,
          Action<T> configureOptions) where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return builder.AddAdoNetGrainStorageAsDefault(newAction);
        }


        /// <summary>
        /// Configure silo to use  AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorage<T>(
            this ISiloHostBuilder builder,
            string name,
            Action<T> configureOptions) where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return builder.AddAdoNetGrainStorage(name, newAction);
        }

        private static void ConvertToAdoNetGrainStorageOptions<T>(Action<T> configureOptions, AdoNetGrainStorageOptions options)
            where T : AdoNetGrainStorageOptions, new()
        {
            var t = new T();
            configureOptions(t);
            options.Invariant = t.Invariant;
            options.ConnectionString = t.ConnectionString;
            options.ConfigureJsonSerializerSettings = t.ConfigureJsonSerializerSettings;
            options.IndentJson = t.IndentJson;
            options.InitStage = t.InitStage;
            options.TypeNameHandling = t.TypeNameHandling;
            options.UseFullAssemblyNames = t.UseFullAssemblyNames;
            options.UseJsonFormat = t.UseJsonFormat;
            options.UseXmlFormat = t.UseXmlFormat;
        }

        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
        this ISiloBuilder builder,
        Action<T> configureOptions)
        where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return builder.AddAdoNetGrainStorageAsDefault(newAction);
        }

        /// <summary>
        /// Configure silo to use  AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOrleansAdoNetGrainStorage<T>(
            this ISiloBuilder builder,
            string name,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return builder.AddAdoNetGrainStorage(name, newAction);
        }


        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOrleansAdoNetGrainStorage<T>(
            this IServiceCollection services,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return services.AddAdoNetGrainStorage(newAction);
        }

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOrleansAdoNetGrainStorage<T>(
          this IServiceCollection services,
          string name,
          Action<T> configureOptions)
        where T : AdoNetGrainStorageOptions, new()
        {
            var newAction = new Action<AdoNetGrainStorageOptions>(options => ConvertToAdoNetGrainStorageOptions(configureOptions, options));

            return services.AddAdoNetGrainStorage(name, newAction);
        }
    }
}