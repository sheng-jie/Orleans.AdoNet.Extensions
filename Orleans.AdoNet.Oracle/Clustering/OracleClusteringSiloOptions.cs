using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Clustering
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class OracleClusteringSiloOptions : AdoNetClusteringSiloOptions
    {
        public OracleClusteringSiloOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameOracleDatabase;
        }
    }
}