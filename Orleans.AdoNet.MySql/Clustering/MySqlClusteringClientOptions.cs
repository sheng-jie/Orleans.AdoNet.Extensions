using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Clustering
{
    /// <summary>Options for ADO.NET MySql clustering</summary>
    public class MySqlClusteringClientOptions : AdoNetClusteringClientOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNameMySql;
    }
}