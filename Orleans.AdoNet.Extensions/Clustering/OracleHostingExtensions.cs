using System;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Clustering.ClientOptions;
using Orleans.AdoNet.Clustering.SiloOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Clustering
{
    public static class OracleHostingExtensions
    {
        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseOracleClustering(this ISiloHostBuilder builder,
            Action<OracleClusteringSiloOptions> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseOracleClustering(this ISiloHostBuilder builder,
            Action<OptionsBuilder<OracleClusteringSiloOptions>> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOracleClustering(this ISiloBuilder builder,
            Action<OracleClusteringSiloOptions> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOracleClustering(this ISiloBuilder builder,
            Action<OptionsBuilder<OracleClusteringSiloOptions>> configureOptions) =>
            builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseOracleClustering(
            this IClientBuilder builder,
            Action<OracleClusteringClientOptions> configureOptions)
            => builder.UseAdoNetClustering(configureOptions);

        /// <summary>
        /// Configures this silo to use Oracle for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseOracleClustering(
            this IClientBuilder builder,
            Action<OptionsBuilder<OracleClusteringClientOptions>> configureOptions)
            => builder.UseAdoNetClustering(configureOptions);
    }
}