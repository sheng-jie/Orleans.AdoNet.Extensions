using System;
using System.Threading.Tasks;
using Orleans.AdoNet.SqlServer.Test.Grains;
using Orleans.TestingHost;
using Xunit;

namespace Orleans.AdoNet.SqlServer.Test
{
    [Collection(ClusterCollection.Name)]
    public class SqlServerUnitTest
    {
        private readonly TestCluster _cluster;
        public SqlServerUnitTest(ClusterFixture clusterFixture)
        {
            _cluster = clusterFixture.TestCluster;
        }
        [Fact]
        public async Task Test_Cluster()
        {
            var sku = _cluster.GrainFactory.GetGrain<IInventoryGrain>("sku-001");
            await sku.Set(10);
            var result = await sku.Decrease(12);

            Assert.False(result);
        }

        [Fact]
        public async Task Test_State()
        {
            var sku = _cluster.GrainFactory.GetGrain<IInventoryGrain>("sku-002");
            await sku.Set(10);
            var qty = await sku.GetInventory();

            Assert.Equal(10, qty);
        }

        [Fact]
        public async Task Test_Reminder()
        {
            var sku = _cluster.GrainFactory.GetGrain<IInventoryGrain>("sku-003");
            await sku.Set(10);
            await Task.Delay(TimeSpan.FromSeconds(70));
            var qty = await sku.GetInventory();

            Assert.True(qty < 10);
        }
    }
}
