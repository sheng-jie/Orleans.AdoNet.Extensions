using Orleans.Configuration;

namespace Orleans.AdoNet.Clustering.ClientOptions
{
    public class OracleClusteringClientOptions : AdoNetClusteringClientOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}