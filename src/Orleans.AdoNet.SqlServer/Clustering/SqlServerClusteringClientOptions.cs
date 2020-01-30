using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerClusteringClientOptions : AdoNetClusteringClientOptions
    {
        public SqlServerClusteringClientOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameSqlServer;
        }
    }
}