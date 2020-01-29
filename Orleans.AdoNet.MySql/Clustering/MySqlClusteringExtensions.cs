using System;
using Microsoft.Extensions.Options;
using Orleans.Hosting;
using Orleans.AdoNet.Clustering;

namespace Orleans.AdoNet.MySql.Clustering
{
    public static class MySqlClusteringExtensions
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
            builder.UseOrleansAdoNetClustering(configureOptions);


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
            builder.UseOrleansAdoNetClustering(configureOptions);


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
            => builder.UseOrleansAdoNetClustering(configureOptions);
    }
}