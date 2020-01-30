using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Persistence
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlGrainStorageOptions : AdoNetGrainStorageOptions
    {
        public PostgreSqlGrainStorageOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNamePostgreSql;
        }
    }
}