using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Clustering
{
    /// <summary>
    /// Options for ADO.NET PostgreSql clustering
    /// </summary>
    public class PostgreSqlClusteringClientOptions : AdoNetClusteringClientOptions
    {
        public PostgreSqlClusteringClientOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNamePostgreSql;
        }
    }
}