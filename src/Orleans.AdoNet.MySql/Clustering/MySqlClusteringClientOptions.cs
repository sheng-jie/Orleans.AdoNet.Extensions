using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Clustering
{
    /// <summary>Options for ADO.NET MySql clustering</summary>
    public class MySqlClusteringClientOptions : AdoNetClusteringClientOptions
    {
        public MySqlClusteringClientOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameMySql;
        }
    }
}