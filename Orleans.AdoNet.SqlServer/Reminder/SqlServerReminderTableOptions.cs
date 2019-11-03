using Orleans.Configuration;

namespace Orleans.AdoNet.SqlServer.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class SqlServerReminderTableOptions : AdoNetReminderTableOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        public new string Invariant { get; private set; }= AdoNetInvariants.InvariantNameSqlServer;
    }
}