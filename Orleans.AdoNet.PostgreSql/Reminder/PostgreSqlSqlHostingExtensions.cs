using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Orleans.AdoNet.Reminder.ReminderTableOptions;
using Orleans.Hosting;

namespace Orleans.AdoNet.Reminder
{
    public static class PostgreSqlReminderServiceExtensions
    {
       /// <summary>
        /// Adds reminder storage using PostgreSql Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UsePostgreSqlReminderService(
          this ISiloHostBuilder builder,
          Action<PostgreSqlReminderTableOptions> configureOptions) => builder.UseAdoNetReminderService(configureOptions);


        /// <summary>
        /// Adds reminder storage using PostgreSql Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloHostBuilder UsePostgreSqlReminderService(
            this ISiloHostBuilder builder,
            Action<OptionsBuilder<PostgreSqlReminderTableOptions>> configureOptions) => builder.UseAdoNetReminderService(configureOptions);

        /// <summary>
        /// Adds reminder storage using PostgreSql Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UsePostgreSqlReminderService(
          this ISiloBuilder builder,
          Action<PostgreSqlReminderTableOptions> configureOptions) => builder.UseAdoNetReminderService(configureOptions);

        /// <summary>
        /// Adds reminder storage using PostgreSql Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />
        /// </summary>
        /// <param name="builder">The builder.</param>
        /// <param name="configureOptions">The configuration delegate.</param>
        /// <returns>
        /// The provided <see cref="T:Orleans.Hosting.ISiloBuilder" />.
        /// </returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static ISiloBuilder UsePostgreSqlReminderService(
          this ISiloBuilder builder,
          Action<OptionsBuilder<PostgreSqlReminderTableOptions>> configureOptions) => builder.UseAdoNetReminderService(configureOptions);


        /// <summary>Adds reminder storage using PostgreSql Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.</summary>
        /// <param name="services">The service collection.</param>
        /// <param name="configureOptions">Configuration delegate.</param>
        /// <returns>The provided <see cref="T:Orleans.Hosting.ISiloHostBuilder" />, for chaining.</returns>
        /// <remarks>
        /// Instructions on configuring your database are available at <see href="http://aka.ms/orleans-sql-scripts" />.
        /// </remarks>
        public static IServiceCollection UsePostgreSqlReminderService(
            this IServiceCollection services,
            Action<OptionsBuilder<PostgreSqlReminderTableOptions>> configureOptions) => services.UseAdoNetReminderService(configureOptions);
    
    }
}