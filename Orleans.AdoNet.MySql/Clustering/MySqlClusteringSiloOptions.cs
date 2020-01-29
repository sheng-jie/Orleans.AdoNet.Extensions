using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class MySqlClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        // private new string Invariant  = AdoNetInvariants.InvariantNameMySql;

        public MySqlClusteringSiloOptions()
        {
            base.Invariant  = AdoNetInvariants.InvariantNameMySql;
        }
    }
}