using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class OracleReminderTableOptions : AdoNetReminderTableOptions
    {
        public OracleReminderTableOptions()
        {
            base.Invariant = AdoNetInvariants.InvariantNameOracleDatabase;
        }
    }
}