using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Orleans.Configuration;
using Orleans.Hosting;
using Orleans.AdoNet.Clustering;
using Orleans.AdoNet.MySql.Clustering;
using Orleans.AdoNet.MySql.Persistence;
using Orleans.AdoNet.MySql.Reminder;
using Orleans.Grains;

namespace Orleans.Server
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
                        var connectionString =@"Data Source=Server=localhost;Database=hello_orleans;Uid=root;Pwd=";
                        //use AdoNet for clustering 
                        
                        builder.UseMySqlClustering(option => { option.ConnectionString = connectionString; }).Configure<ClusterOptions>(options =>
                        {
                            options.ClusterId = "Hello.Orleans";
                            options.ServiceId = "Hello.Orleans";
                        }).ConfigureEndpoints(new Random().Next(10001, 20000), new Random().Next(20001, 30000));

                        //use AdoNet for reminder service
                       //  builder.UseMySqlReminderService(options =>
                       //      options.ConnectionString = connectionString
                       //  );
                       //
                       //  //use AdoNet for Persistence
                       //  builder.AddMySqlGrainStorageAsDefault(options =>
                       // {
                       //     options.ConnectionString = connectionString;
                       //     options.UseJsonFormat = true;
                       // });
                       //
                       //  builder.ConfigureApplicationParts(parts => parts.AddApplicationPart(typeof(IHelloGrain).Assembly).WithReferences());
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
