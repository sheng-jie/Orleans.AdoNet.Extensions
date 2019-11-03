using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Reminder.ReminderTableOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Reminder
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
          Action<OracleReminderTableOptions> configureOptions) => builder.UseAdoNetReminderService(configureOptions);


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
            Action<OptionsBuilder<OracleReminderTableOptions>> configureOptions) => builder.UseAdoNetReminderService(configureOptions);

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
          Action<OracleReminderTableOptions> configureOptions) => builder.UseAdoNetReminderService(configureOptions);

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
          Action<OptionsBuilder<OracleReminderTableOptions>> configureOptions) => builder.UseAdoNetReminderService(configureOptions);


        /// <summary>Adds reminder storage using Oracle Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.</summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configureOptions">Configuration delegate.</param>
        /// <returns>The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />, for chaining.</returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection UseOracleReminderService(
            this IServiceCollection services,
            Action<OptionsBuilder<OracleReminderTableOptions>> configureOptions) => services.UseAdoNetReminderService(configureOptions);
    
    }
}