using System;
using Orleans.Configuration;
using Orleans.Hosting;

namespace Orleans.AdoNet.Clustering
{
    /// <summary>Extensions for configuring ADO.NET for clustering.</summary>
    public static class AdoNetClusteringExtensions
    {
        /// <summary>
        /// Configures this silo to use ADO.NET for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseOrleansAdoNetClustering<T>(
          this ISiloHostBuilder builder,
          Action<T> configureOptions) where T : AdoNetClusteringSiloOptions, new()
        {
            var newAction = new Action<AdoNetClusteringSiloOptions>(options =>
            {
                var t = new T();
                configureOptions(t);
                options.Invariant = t.Invariant;
                options.ConnectionString = t.ConnectionString;
            });

            return builder.UseAdoNetClustering(newAction);
        }

        /// <summary>
        /// Configures this silo to use ADO.NET for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOrleansAdoNetClustering<T>(
          this ISiloBuilder builder,
          Action<T> configureOptions) where T : AdoNetClusteringSiloOptions, new()
        {
            var newAction = new Action<AdoNetClusteringSiloOptions>(options =>
            {
                var t = new T();
                configureOptions(t);
                options.Invariant = t.Invariant;
                options.ConnectionString = t.ConnectionString;
            });

            return builder.UseAdoNetClustering(newAction);
        }

        /// <summary>
        /// Configures this client to use ADO.NET for clustering. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.IClientBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IClientBuilder UseOrleansAdoNetClustering<T>(
          this IClientBuilder builder,
          Action<T> configureOptions) where T : AdoNetClusteringClientOptions, new()
        {
            var newAction = new Action<AdoNetClusteringClientOptions>(options =>
            {
                var t = new T();
                configureOptions(t);
                options.Invariant = t.Invariant;
                options.ConnectionString = t.ConnectionString;
            });

            return builder.UseAdoNetClustering(newAction);
        }
    }
}
