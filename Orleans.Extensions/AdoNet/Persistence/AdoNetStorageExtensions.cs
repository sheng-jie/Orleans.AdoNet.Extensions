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
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
          this ISiloHostBuilder builder,
          Action<T> configureOptions) where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions as Action<AdoNetGrainStorageOptions>);


        /// <summary>
        /// Configure silo to use  AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorage<T>(
            this ISiloHostBuilder builder,
            string name,
            Action<T> configureOptions) where T : AdoNetGrainStorageOptions
            => builder.AddAdoNetGrainStorage(name, configureOptions as Action<AdoNetGrainStorageOptions>);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<T>> configureOptions) where T : AdoNetGrainStorageOptions
            => builder.AddAdoNetGrainStorageAsDefault(configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOrleansAdoNetGrainStorage<T>(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);

        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
            this ISiloBuilder builder,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions as Action<AdoNetGrainStorageOptions>);

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
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions as Action<AdoNetGrainStorageOptions>);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOrleansAdoNetGrainStorageAsDefault<T>(
            this ISiloBuilder builder,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorageAsDefault(configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOrleansAdoNetGrainStorage<T>(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => builder.AddAdoNetGrainStorage(name, configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);

        /// <summary>
        /// Configure silo to use  AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOrleansAdoNetGrainStorage<T>(
            this IServiceCollection services,
            Action<T> configureOptions)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(configureOptions as Action<AdoNetGrainStorageOptions>);

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
        where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(name, configureOptions as Action<AdoNetGrainStorageOptions>);


        /// <summary>
        /// Configure silo to use AdoNet grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOrleansAdoNetGrainStorageAsDefault<T>(
            this IServiceCollection services,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorageAsDefault(configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);

        /// <summary>
        /// Configure silo to use AdoNet grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOrleansAdoNetGrainStorage<T>(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<T>> configureOptions = null)
            where T : AdoNetGrainStorageOptions => services.AddAdoNetGrainStorage(name, configureOptions as Action<OptionsBuilder<AdoNetGrainStorageOptions>>);
    }


}