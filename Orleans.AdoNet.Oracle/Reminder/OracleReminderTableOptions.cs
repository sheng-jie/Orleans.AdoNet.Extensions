using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class OracleReminderTableOptions : AdoNetReminderTableOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; } = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}