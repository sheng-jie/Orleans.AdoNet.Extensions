using Microsoft.Extensions.Configuration;
using Orleans.AdoNet.SqlServer.Clustering;
using Orleans.AdoNet.SqlServer.Persistence;
using Orleans.AdoNet.SqlServer.Reminder;
using Orleans.Hosting;
using Orleans.TestingHost;

namespace Orleans.AdoNet.SqlServer.Test
{
    public class TestSiloBuilderConfigurator : ISiloBuilderConfigurator
    {
        public void Configure(ISiloHostBuilder hostBuilder)
        {
            var connectStr = hostBuilder.GetConfiguration().GetValue<string>("Orleans_SqlServer_ConStr");

            hostBuilder.UseSqlServerClustering(options => options.ConnectionString = connectStr);
            hostBuilder.ConfigureApplicationParts(parts => parts.AddFromApplicationBaseDirectory().WithReferences());
            hostBuilder.AddSqlServerGrainStorageAsDefault(options =>
            {
                options.ConnectionString = connectStr;
                options.UseJsonFormat = true;
            });
            hostBuilder.UseSqlServerReminderService(options => options.ConnectionString = connectStr);
        }
    }
}