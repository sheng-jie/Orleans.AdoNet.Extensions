using Orleans.AdoNet.Clustering;
using Orleans.Configuration;

namespace Orleans.AdoNet.Persistence.GrainStorageOptions
{
    public class OracleGrainStorageOptions : AdoNetGrainStorageOptions
    {

        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}