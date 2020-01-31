# Introduction
A simple wrapper repo for configuring Orleans cluster, reminder, grain persistence with Ado.NET provider.
There are four nuget package:
1. Orleans.AdoNet.MySql
2. Orleans.AdoNet.SqlServer
3. Orleans.AdoNet.Oracle
4. Orleans.AdoNet.PostgreSql

# How to Use
 1. Chose nuget package according to your Ado.Net provider. 
 For example, if you want use **SqlServer** for Orleans cluster/remiand/persistence, add **`Orleans.AdoNet.SqlServer`** package from Visual Studio Nuget Package Manager.
 2. After install package, a readme.txt will open in your visual studio like below. Copy script in the readme.txt and run in your Database. 
 
 ```
 -- The sql scripts in the below is for creating table and seeding data for orleans clustering, persistence and remiander. 
-- It will create the following tables:
-- 1. OrleansQuery
-- 2. OrleansMembershipTable (This is for Orleans Cluster manager.)
-- 3. OrleansMembershipVersionTable (This is for Orleans Cluster manager.)
-- 4. OrleansRemindersTable (This is for Orleans Reminder.)
-- 5. Storage (This is for Orleans Grain Persistence.)

-- Please copy and run it in your SqlServer database !

================================================
//scripts...
 ```
 
 > 1. You can keep table on your need. (**OrleansQuery** cannot delete!!!)
 > 2. If there is no readme.txt display, navigation to responding project in this repo, and open the **SqlScripts** folder, you will find sql scripts.
 And you should run *-Main.Sql first, and then run other sql scripts according to your requirement.
 
 
 3. Use extension method on your Orleans Server side like below.
 ```
 Host.CreateDefaultBuilder()
     .UseOrleans((builder) =>
      {
          var connectionString =
              @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hello.Orleans;Integrated Security=True;Pooling=False;Max Pool Size=200;MultipleActiveResultSets=True";
         //use AdoNet for clustering 

         builder.UseSqlServerClustering(option =>
          {
              option.ConnectionString = connectionString;
          }).Configure<ClusterOptions>(options =>
          {
              options.ClusterId = "Hello.Orleans";
              options.ServiceId = "Hello.Orleans";
          }).ConfigureEndpoints(new Random().Next(10001, 20000), new Random().Next(20001, 30000));

         //use AdoNet for reminder service
         builder.UseSqlServerReminderService(options =>
          {
              options.ConnectionString = connectionString;
          });

         //use AdoNet for Persistence
         builder.AddSqlServerGrainStorageAsDefault(options =>
         {
             options.ConnectionString = connectionString;
             options.UseJsonFormat = true;
         }); 
 ```
 
 4. Use extension method on your Orleans Client side like below.
 ```
 var connectionString =
    @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Hello.Orleans;Integrated Security=True;Pooling=False;Max Pool
Size=200;MultipleActiveResultSets=True";
// Configure a client and connect to the service.
var client = new ClientBuilder()
    .UseSqlServerClustering(option =>
        option.ConnectionString = connectionString).Configure<ClusterOptions>(options =>
    {
        options.ClusterId = "Hello.Orleans";
        options.ServiceId = "Hello.Orleans";
    })
    .ConfigureLogging(logging => logging.AddConsole())
    .Build();
 ```
 
 # Todo
 Tests will be add later
