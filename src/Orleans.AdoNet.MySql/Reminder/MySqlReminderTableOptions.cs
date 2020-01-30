using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class MySqlReminderTableOptions : AdoNetReminderTableOptions
    {
        public MySqlReminderTableOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameMySql;
        }
    }
}