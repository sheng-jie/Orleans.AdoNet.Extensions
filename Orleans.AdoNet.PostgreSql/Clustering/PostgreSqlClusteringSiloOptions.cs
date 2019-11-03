using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNamePostgreSql;
    }
}