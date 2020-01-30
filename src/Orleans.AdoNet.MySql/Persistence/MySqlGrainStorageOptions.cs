using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Persistence
{
    public class MySqlGrainStorageOptions : AdoNetGrainStorageOptions
    {
        public MySqlGrainStorageOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameMySql;
        }
    }
}