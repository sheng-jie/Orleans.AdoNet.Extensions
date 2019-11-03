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
          Action<PostgreSqlGrainStorageOptions> configureOptions) => builder.AddAdoNetGrainStorageAsDefault(configureOptions);


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
            => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddPostgreSqlGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions)
            => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddPostgreSqlGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddPostgreSqlGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

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
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddPostgreSqlGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddPostgreSqlGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions = null)
             => builder.AddAdoNetGrainStorage(name, configureOptions);

        /// <summary>
        /// Configure silo to use  PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddPostgreSqlGrainStorage(
            this IServiceCollection services,
            Action<PostgreSqlGrainStorageOptions> configureOptions)
             => services.AddAdoNetGrainStorage(configureOptions);

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
         => services.AddAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use PostgreSql grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddPostgreSqlGrainStorageAsDefault(
            this IServiceCollection services,
            Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use PostgreSql grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddPostgreSqlGrainStorage(
            this IServiceCollection services,
            string name,
            Action<OptionsBuilder<PostgreSqlGrainStorageOptions>> configureOptions = null)
             => services.AddAdoNetGrainStorage(name, configureOptions);
    }
}
