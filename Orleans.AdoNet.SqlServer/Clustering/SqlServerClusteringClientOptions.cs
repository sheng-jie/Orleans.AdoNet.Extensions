using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerClusteringClientOptions : AdoNetClusteringClientOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNameSqlServer;
    }
}