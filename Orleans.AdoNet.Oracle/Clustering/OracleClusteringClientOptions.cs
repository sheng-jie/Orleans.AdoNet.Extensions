﻿using Orleans.Configuration;

namespace Orleans.AdoNet.Oracle.Clustering
{
    public class OracleClusteringClientOptions : AdoNetClusteringClientOptions
    {

        /// <summary>
        /// The invariant name of the connector for membership's database.
        /// </summary>
        private new string Invariant  = AdoNetInvariants.InvariantNameOracleDatabase;
    }
}