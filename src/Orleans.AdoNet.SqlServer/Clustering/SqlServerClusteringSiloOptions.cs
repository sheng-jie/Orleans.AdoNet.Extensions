
using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerClusteringSiloOptions : AdoNetClusteringSiloOptions
    {
        public SqlServerClusteringSiloOptions()
        {
            base.Invariant= AdoNetInvariants.InvariantNameSqlServer;
        }
    }
}