using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Clustering
{
    /// <summary>
    /// Options for ADO.NET PostgreSql clustering
    /// </summary>
    public class PostgreSqlClusteringClientOptions : AdoNetClusteringClientOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNamePostgreSql;
    }
}