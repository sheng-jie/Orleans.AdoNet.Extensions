using Xunit;

namespace Orleans.AdoNet.SqlServer.Test
{
    [CollectionDefinition(ClusterCollection.Name)]
    public class ClusterCollection : ICollectionFixture<ClusterFixture>
    {
        public const string Name = "ClusterCollection";

    }
}