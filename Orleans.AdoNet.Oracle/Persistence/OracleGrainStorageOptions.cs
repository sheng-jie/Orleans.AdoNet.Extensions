using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Persistence
{
    public class OracleGrainStorageOptions : AdoNetGrainStorageOptions
    {

        private new string Invariant  = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}