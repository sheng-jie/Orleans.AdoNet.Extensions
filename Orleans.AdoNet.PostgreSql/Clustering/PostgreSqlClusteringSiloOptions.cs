using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        public PostgreSqlClusteringSiloOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNamePostgreSql;
        }
    }
}