using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class MySqlClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        public MySqlClusteringSiloOptions()
        {
            base.Invariant  = AdoNetInvariants.InvariantNameMySql;
        }
    }
}