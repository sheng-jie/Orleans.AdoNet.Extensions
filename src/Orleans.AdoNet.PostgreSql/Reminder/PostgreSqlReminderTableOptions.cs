using Orleans.Configuration;

namespace Orleans.AdoNet.PostgreSql.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class PostgreSqlReminderTableOptions : AdoNetReminderTableOptions
    {
        public PostgreSqlReminderTableOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNamePostgreSql;
        }
    }
}