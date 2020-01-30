using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence;
using Orleans.Hosting;

namespace Orleans.AdoNet.SqlServer.Persistence
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
          Action<SqlServerGrainStorageOptions> configureOptions) => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);


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
            => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddSqlServerGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<SqlServerGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

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
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use  SqlServer grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddSqlServerGrainStorage(
            this IServiceCollection services,
            Action<SqlServerGrainStorageOptions> configureOptions)
             => services.AddOrleansAdoNetGrainStorage(configureOptions);

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
         => services.AddOrleansAdoNetGrainStorage(name, configureOptions);
    }
}
