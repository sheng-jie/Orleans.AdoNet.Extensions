using Orleans.AdoNet.Clustering;
using Orleans.Configuration;

namespace Orleans.AdoNet.Persistence.GrainStorageOptions
{
    public class SqlServerGrainStorageOptions : AdoNetGrainStorageOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameSqlServer;
    }
}