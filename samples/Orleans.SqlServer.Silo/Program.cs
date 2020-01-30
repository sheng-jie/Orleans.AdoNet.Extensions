using System;
using System.Threading.Tasks;

namespace Orleans.SqlServer.Silo
{
    class Program
    {
        static Task Main(string[] args)
        {
            Console.Title = typeof(Program).Namespace;

            // define the cluster configuration
            return Host.CreateDefaultBuilder()
                .UseOrleans((builder) =>
                    {

                        var invariant = "System.Data.SqlClient";
                        var connectionString =
                            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hello.Orleans;Integrated Security=True;Pooling=False;Max Pool Size=200;MultipleActiveResultSets=True";
                        //use AdoNet for clustering 

                        builder.UseSqlServerClustering(option =>
                        {
                            option.ConnectionString = connectionString;
                        }).Configure<ClusterOptions>(options =>
                        {
                            options.ClusterId = "Hello.Orleans";
                            options.ServiceId = "Hello.Orleans";
                        }).ConfigureEndpoints(new Random().Next(10001, 20000), new Random().Next(20001, 30000));

                        //use AdoNet for reminder service
                        builder.UseSqlServerReminderService(options =>
                        {
                            options.ConnectionString = connectionString;
                            options.Invariant = invariant;
                        }
                        );

                        //use AdoNet for Persistence
                        builder.AddSqlServerGrainStorageAsDefault(options =>
                       {
                           options.Invariant = invariant;
                           options.ConnectionString = connectionString;
                           options.UseJsonFormat = true;
                       });

                        builder.ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(IHelloGrain).Assembly).WithReferences());
                    }
                )
                .ConfigureServices(services =>
                {
                    services.Configure<ConsoleLifetimeOptions>(options =>
                    {
                        options.SuppressStatusMessages = true;
                    });
                })
                .ConfigureLogging(builder => { builder.AddConsole(); })
                .RunConsoleAsync();
        }
    }
}
