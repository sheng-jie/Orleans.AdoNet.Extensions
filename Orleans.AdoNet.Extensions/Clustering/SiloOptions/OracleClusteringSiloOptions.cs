using Orleans.Configuration;

namespace Orleans.AdoNet.Clustering.SiloOptions
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class OracleClusteringSiloOptions : AdoNetClusteringSiloOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}