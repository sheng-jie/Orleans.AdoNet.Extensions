using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Orleans.TestingHost;

namespace Orleans.AdoNet.SqlServer.Test
{
    public class ClusterFixture : IDisposable
    {
        public readonly TestCluster TestCluster;

        public ClusterFixture()
        {
            var builder = new TestClusterBuilder();


            builder.ConfigureHostConfiguration(config =>
            {
                config.AddInMemoryCollection(new Dictionary<string, string>
                {
                    {
                        "Orleans_SqlServer_ConStr",
                        @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SqlServerTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                    }
                });
            });
            builder.AddSiloBuilderConfigurator<TestSiloBuilderConfigurator>();
            TestCluster = builder.Build();
            TestCluster.Deploy();
        }



        public void Dispose()
        {
            TestCluster.StopAllSilos();
        }
    }
}