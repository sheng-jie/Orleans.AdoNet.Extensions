using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Persistence
{
    public class SqlServerGrainStorageOptions : AdoNetGrainStorageOptions
    {
        public SqlServerGrainStorageOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameSqlServer;
        }
    }
}