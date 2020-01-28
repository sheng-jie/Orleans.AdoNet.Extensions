using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence;
using Orleans.Hosting;

namespace Orleans.AdoNet.MySql.Persistence
{
    public static class MySqlStorageExtensions
    {
        /// <summary>
        /// Configure silo to use MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddMySqlGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<MySqlGrainStorageOptions> configureOptions) => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddMySqlGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<MySqlGrainStorageOptions> configureOptions)
            => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddMySqlGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions)
            => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddMySqlGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions = null)
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddMySqlGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<MySqlGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddMySqlGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<MySqlGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddMySqlGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions = null)
             => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddMySqlGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions = null)
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddMySqlGrainStorage(
            this IServiceCollection services,
            Action<MySqlGrainStorageOptions> configureOptions)
             => services.AddOrleansAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddMySqlGrainStorage(
          this IServiceCollection services,
          string name,
          Action<MySqlGrainStorageOptions> configureOptions)
         => services.AddOrleansAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use MySql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddMySqlGrainStorageAsDefault(
            this IServiceCollection services,
            Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions = null)
             => services.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use MySql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddMySqlGrainStorage(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<MySqlGrainStorageOptions>> configureOptions = null)
             => services.AddOrleansAdoNetGrainStorage(name, configureOptions);
    }
}
