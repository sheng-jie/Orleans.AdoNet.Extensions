using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Persistence
{
    public class SqlServerGrainStorageOptions : AdoNetGrainStorageOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameSqlServer;
    }
}