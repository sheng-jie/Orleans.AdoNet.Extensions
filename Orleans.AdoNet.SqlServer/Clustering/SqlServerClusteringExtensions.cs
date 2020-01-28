using System;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Clustering;
using Orleans.Hosting;

namespace Orleans.AdoNet.SqlServer.Clustering
{
    public static class SqlServerClusteringExtensions
    {
        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseSqlServerClustering(this ISiloHostBuilder builder,
            Action<SqlServerClusteringSiloOptions> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseSqlServerClustering(this ISiloHostBuilder builder,
            Action<OptionsBuilder<SqlServerClusteringSiloOptions>> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOrleansSqlServerClustering(this ISiloBuilder builder,
            Action<SqlServerClusteringSiloOptions> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseSqlServerClustering(this ISiloBuilder builder,
            Action<OptionsBuilder<SqlServerClusteringSiloOptions>> configureOptions) =>
            builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseSqlServerClustering(
            this IClientBuilder builder,
            Action<SqlServerClusteringClientOptions> configureOptions)
            => builder.UseOrleansAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use SqlServer for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseSqlServerClustering(
            this IClientBuilder builder,
            Action<OptionsBuilder<SqlServerClusteringClientOptions>> configureOptions)
            => builder.UseOrleansAdoNetClustering(configureOptions);
    }
}
