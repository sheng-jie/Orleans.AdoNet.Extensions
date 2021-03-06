﻿using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Reminder;
using Orleans.Hosting;

namespace Orleans.AdoNet.SqlServer.Reminder
{
    public static class SqlServerReminderServiceExtensions
    {
        /// <summary>
        /// Adds reminder storage using SqlServer Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseSqlServerReminderService(
          this ISiloHostBuilder builder,
          Action<SqlServerReminderTableOptions> configureOptions) => builder.UseOrleansAdoNetReminderService(configureOptions);

        /// <summary>
        /// Adds reminder storage using SqlServer Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseSqlServerReminderService(
          this ISiloBuilder builder,
          Action<SqlServerReminderTableOptions> configureOptions) => builder.UseOrleansAdoNetReminderService(configureOptions);

    }
}
