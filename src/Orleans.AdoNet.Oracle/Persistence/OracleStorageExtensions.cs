﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Persistence;
using Orleans.Hosting;

namespace Orleans.AdoNet.Oracle.Persistence
{
    public static class OracleStorageExtensions
    {
        /// <summary>
        /// Configure silo to use Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorageAsDefault(
          this ISiloHostBuilder builder,
          Action<OracleGrainStorageOptions> configureOptions) => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);


        /// <summary>
        /// Configure silo to use  Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder AddOracleGrainStorage(
            this ISiloHostBuilder builder,
            string name,
            Action<OracleGrainStorageOptions> configureOptions)
            => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);



        /// <summary>
        /// Configure silo to use Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorageAsDefault(
            this ISiloBuilder builder,
            Action<OracleGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorageAsDefault(configureOptions);

        /// <summary>
        /// Configure silo to use  Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder AddOracleGrainStorage(
            this ISiloBuilder builder,
            string name,
            Action<OracleGrainStorageOptions> configureOptions)
             => builder.AddOrleansAdoNetGrainStorage(name, configureOptions);


        /// <summary>
        /// Configure silo to use  Oracle grain storage as the default grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorage(
            this IServiceCollection services,
            Action<OracleGrainStorageOptions> configureOptions)
             => services.AddOrleansAdoNetGrainStorage(configureOptions);

        /// <summary>
        /// Configure silo to use Oracle grain storage for grain storage. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </summary>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection AddOracleGrainStorage(
          this IServiceCollection services,
          string name,
          Action<OracleGrainStorageOptions> configureOptions)
         => services.AddOrleansAdoNetGrainStorage(name, configureOptions);

    }
}
