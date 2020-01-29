using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence;
using Orleans.Hosting;

namespace Orleans.AdoNet.PostgreSql.Persistence
{
    public static class PostgreSqlStorageExtensions
    {
        /// <summary>
        /// Configure silo to use PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddPostgreSqlGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<PostgreSqlGrainStorageOptions> configureOptions) => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddPostgreSqlGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
            => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddPostgreSqlGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddPostgreSqlGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddPostgreSqlGrainStorage(
            this IServiceCollection services,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
             => services.AddOrleansAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddPostgreSqlGrainStorage(
          this IServiceCollection services,
          string name,
          Action<PostgreSqlGrainStorageOptions> configureOptions)
         => services.AddOrleansAdoNetGrainStorage(name, configureOptions);

    }
}
