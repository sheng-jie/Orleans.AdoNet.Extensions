using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Persistence
{
    public class OracleGrainStorageOptions : AdoNetGrainStorageOptions
    {

        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}