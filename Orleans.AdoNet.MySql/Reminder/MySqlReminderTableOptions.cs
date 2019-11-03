﻿using Orleans.Configuration;

namespace Orleans.AdoNet.MySql.Reminder
{
    /// <summary>Options for ADO.NET Sql Server clustering</summary>
    public class MySqlReminderTableOptions : AdoNetReminderTableOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNameMySql;
    }
}