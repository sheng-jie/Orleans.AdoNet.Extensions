using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence.GrainStorageOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Persistence
{
    public static class OracleStorageExtensions
    {
        /// <summary>
        /// Configure silo to use Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OracleGrainStorageOptions> configureOptions) => builder.AddAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OracleGrainStorageOptions> configureOptions)
            => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions)
            => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OracleGrainStorageOptions> configureOptions)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OracleGrainStorageOptions> configureOptions)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorage(
            this IServiceCollection services,
            Action<OracleGrainStorageOptions> configureOptions)
             => services.AddAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorage(
          this IServiceCollection services,
          string name,
          Action<OracleGrainStorageOptions> configureOptions)
         => services.AddAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorageAsDefault(
            this IServiceCollection services,
            Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorage(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<OracleGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorage(name, configureOptions);
    }
}
