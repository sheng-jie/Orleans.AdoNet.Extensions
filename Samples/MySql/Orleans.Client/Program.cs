﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans.AdoNet.MySql.Clustering;
using Orleans.Configuration;
using Orleans.Grains;

namespace Orleans.Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var connectionString =@"Data Source=Server=localhost;Database=hello_orleans;Uid=root;Pwd=passowrd";

                // Configure a client and connect to the service.
                var client = new ClientBuilder().UseMySqlClustering(option =>
                        option.ConnectionString = connectionString).Configure<ClusterOptions>(options =>
                    {
                        options.ClusterId = "Hello.Orleans";
                        options.ServiceId = "Hello.Orleans";
                    })
                    .ConfigureLogging(logging => logging.AddConsole())
                    .Build();

               await client.Connect(CreateRetryFilter());
                Console.WriteLine("Client successfully connect to silo host");

                // Use the connected client to call a grain, writing the result to the terminal.
                var friend = client.GetGrain<IHelloGrain>(string.Empty);
                var response = await friend.SayHi("Shengjie");
                Console.WriteLine(response);

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadKey();
            }
        }

        private static Func<Exception, Task<bool>> CreateRetryFilter(int maxAttempts = 5)
        {
            var attempt = 0;
            return RetryFilter;

            async Task<bool> RetryFilter(Exception exception)
            {
                attempt++;
                Console.WriteLine($"Cluster client attempt {attempt} of {maxAttempts} failed to connect to cluster.  Exception: {exception}");
                if (attempt > maxAttempts)
                {
                    return false;
                }

                await Task.Delay(TimeSpan.FromSeconds(4));
                return true;
            }
        }
    }
}
