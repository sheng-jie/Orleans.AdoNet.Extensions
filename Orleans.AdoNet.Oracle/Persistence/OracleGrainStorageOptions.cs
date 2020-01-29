using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Persistence
{
    public class OracleGrainStorageOptions : AdoNetGrainStorageOptions
    {
        public OracleGrainStorageOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameOracleDatabase;
        }
    }
}