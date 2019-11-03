
using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; set; }= AdoNetInvariants.InvariantNameSqlServer;
    }
}