using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerReminderTableOptions : AdoNetReminderTableOptions
    {
        public SqlServerReminderTableOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameSqlServer;
        }
    }
}