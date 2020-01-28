using System;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Clustering;
using Orleans.Hosting;

namespace Orleans.AdoNet.PostgreSql.Clustering
{
    public static class PostgreSqlClusteringExtensions
    {
        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UsePostgreSqlClustering(this ISiloHostBuilder builder,
            Action<PostgreSqlClusteringSiloOptions> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UsePostgreSqlClustering(this ISiloHostBuilder builder,
            Action<OptionsBuilder<PostgreSqlClusteringSiloOptions>> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UsePostgreSqlClustering(this ISiloBuilder builder,
            Action<PostgreSqlClusteringSiloOptions> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UsePostgreSqlClustering(this ISiloBuilder builder,
            Action<OptionsBuilder<PostgreSqlClusteringSiloOptions>> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UsePostgreSqlClustering(
            this IClientBuilder builder,
            Action<PostgreSqlClusteringClientOptions> configureOptions)
            => builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use PostgreSql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UsePostgreSqlClustering(
            this IClientBuilder builder,
            Action<OptionsBuilder<PostgreSqlClusteringClientOptions>> configureOptions)
            => builder.UseOrleansAdoNetClustering(configureOptions);
    }
}