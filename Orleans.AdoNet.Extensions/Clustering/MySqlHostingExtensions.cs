using System;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Clustering.ClientOptions;
using Orleans.AdoNet.Clustering.SiloOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Clustering
{
    public static class MySqlHostingExtensions
    {
        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseMySqlClustering(this ISiloHostBuilder builder,
            Action<MySqlClusteringSiloOptions> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseMySqlClustering(this ISiloHostBuilder builder,
            Action<OptionsBuilder<MySqlClusteringSiloOptions>> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseMySqlClustering(this ISiloBuilder builder,
            Action<MySqlClusteringSiloOptions> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseMySqlClustering(this ISiloBuilder builder,
            Action<OptionsBuilder<MySqlClusteringSiloOptions>> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseMySqlClustering(
            this IClientBuilder builder,
            Action<MySqlClusteringClientOptions> configureOptions)
            => builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use MySql for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseMySqlClustering(
            this IClientBuilder builder,
            Action<OptionsBuilder<MySqlClusteringClientOptions>> configureOptions)
            => builder.UseAdoNetClustering(configureOptions);
    }
}