using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Persistence
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlGrainStorageOptions : AdoNetGrainStorageOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNamePostgreSql;
    }
}