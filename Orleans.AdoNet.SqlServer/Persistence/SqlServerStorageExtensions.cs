using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence.GrainStorageOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Persistence
{
    public static class SqlServerStorageExtensions
    {
        /// <summary>
        /// Configure silo to use SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddSqlServerGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<SqlServerGrainStorageOptions> configureOptions) => builder.AddAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddSqlServerGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<SqlServerGrainStorageOptions> configureOptions)
            => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddSqlServerGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions)
            => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddSqlServerGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddSqlServerGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<SqlServerGrainStorageOptions> configureOptions)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddSqlServerGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<SqlServerGrainStorageOptions> configureOptions)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddSqlServerGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddSqlServerGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddSqlServerGrainStorage(
            this IServiceCollection services,
            Action<SqlServerGrainStorageOptions> configureOptions)
             => services.AddAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddSqlServerGrainStorage(
          this IServiceCollection services,
          string name,
          Action<SqlServerGrainStorageOptions> configureOptions)
         => services.AddAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddSqlServerGrainStorageAsDefault(
            this IServiceCollection services,
            Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use SqlServer grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddSqlServerGrainStorage(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<SqlServerGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorage(name, configureOptions);
    }
}
