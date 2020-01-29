using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Clustering
{
    public class OracleClusteringClientOptions : AdoNetClusteringClientOptions
    {
        public OracleClusteringClientOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameOracleDatabase;
        }


    }
}