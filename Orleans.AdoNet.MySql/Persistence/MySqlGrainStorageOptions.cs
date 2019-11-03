using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Persistence
{
    public class MySqlGrainStorageOptions : AdoNetGrainStorageOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNameMySql;
    }
}