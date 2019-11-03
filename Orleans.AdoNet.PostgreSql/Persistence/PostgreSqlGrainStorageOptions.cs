using Orleans.AdoNet.Clustering;
using Orleans.Configuration;

namespace Orleans.AdoNet.Persistence.GrainStorageOptions
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlGrainStorageOptions : AdoNetGrainStorageOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNamePostgreSql;
    }
}