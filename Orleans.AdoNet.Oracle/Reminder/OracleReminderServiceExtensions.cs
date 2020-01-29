using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.Hosting;
using Orleans.AdoNet.Reminder;

namespace Orleans.AdoNet.Oracle.Reminder
{
    public static class OracleReminderServiceExtensions
    {
        /// <summary>
        /// Adds reminder storage using Oracle Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UseOracleReminderService(
          this ISiloHostBuilder builder,
          Action<OracleReminderTableOptions> configureOptions) => builder.UseOrleansAdoNetReminderService(configureOptions);



        /// <summary>
        /// Adds reminder storage using Oracle Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UseOracleReminderService(
          this ISiloBuilder builder,
          Action<OracleReminderTableOptions> configureOptions) => builder.UseOrleansAdoNetReminderService(configureOptions);
    
    }
}