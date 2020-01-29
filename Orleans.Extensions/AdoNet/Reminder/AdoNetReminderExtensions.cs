﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.Configuration;
using Orleans.Hosting;

namespace Orleans.AdoNet.Reminder
{
    /// <summary>Extensions for configuring ADO.NET for clustering.</summary>
    public static class AdoNetReminderExtensions
    {
        /// <summary>
        /// Adds reminder storage using ADO.NET. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseOrleansAdoNetReminderService<T>(
          this ISiloHostBuilder builder,
          Action<T> configureOptions) where T : AdoNetReminderTableOptions => builder.UseAdoNetReminderService(configureOptions as Action<AdoNetReminderTableOptions>);



        /// <summary>
        /// Adds reminder storage using ADO.NET. Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOrleansAdoNetReminderService<T>(
          this ISiloBuilder builder,
          Action<T> configureOptions) where T : AdoNetReminderTableOptions => builder.UseAdoNetReminderService(configureOptions as Action<AdoNetReminderTableOptions>);
    }
}
