using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
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
        public static ISiloHostBuilder AddAdoNetGrainStorageAsDefault<T>(
          this ISiloHostBuilder builder,
          Action<T> configureOptions) where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddAdoNetGrainStorage<T>(
            this ISiloHostBuilder builder,
            string name,
            Action<T> configureOptions) where T : AdoNetGrainStorageOptions
            => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddAdoNetGrainStorageAsDefault<T>(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<T>> configureOptions) where T : AdoNetGrainStorageOptions
            => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddAdoNetGrainStorage<T>(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddAdoNetGrainStorageAsDefault<T>(
            this ISiloBuilder builder,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddAdoNetGrainStorage<T>(
            this ISiloBuilder builder,
            string name,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddAdoNetGrainStorageAsDefault<T>(
            this ISiloBuilder builder,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddAdoNetGrainStorage<T>(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddAdoNetGrainStorage<T>(
            this IServiceCollection services,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddAdoNetGrainStorage<T>(
          this IServiceCollection services,
          string name,
          Action<T> configureOptions)
        where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddAdoNetGrainStorageAsDefault<T>(
            this IServiceCollection services,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddAdoNetGrainStorage<T>(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(name, configureOptions);
    }


}