-- The sql scripts in the below is for creating table and seeding data for orleans clustering, persistence and remiander. 
-- It will create the following tables:
-- 1. OrleansQuery
-- 2. OrleansMembershipTable
-- 3. OrleansMembershipVersionTable
-- 4. OrleansRemindersTable
-- 5. Storage

-- Please copy and run it in your Oracle database !

-- -----------------------------------------------------------------------------------

-- This table defines Orleans operational queries. Orleans uses these to manage its operations,
-- these are the only queries Orleans issues to the database.
-- These can be redefined (e.g. to provide non-destructive updates) provided the stated interface principles hold.
CREATE TABLE "ORLEANSQUERY"
(
    "QUERYKEY" VARCHAR2(64 BYTE) NOT NULL ENABLE,
    "QUERYTEXT" VARCHAR2(4000 BYTE),

    CONSTRAINT "ORLEANSQUERY_PK" PRIMARY KEY ("QUERYKEY")
);
/

COMMIT;

-- For each deployment, there will be only one (active) membership version table version column which will be updated periodically.
CREATE TABLE "ORLEANSMEMBERSHIPVERSIONTABLE"
(
    "DEPLOYMENTID" NVARCHAR2(150) NOT NULL ENABLE,
    "TIMESTAMP" TIMESTAMP (6) DEFAULT sys_extract_utc(systimestamp) NOT NULL ENABLE,
    "VERSION" NUMBER(*,0) DEFAULT 0,

    CONSTRAINT "ORLEANSMEMBERSHIPVERSIONTA_PK" PRIMARY KEY ("DEPLOYMENTID")
);
/

-- Every silo instance has a row in the membership table.
CREATE TABLE "ORLEANSMEMBERSHIPTABLE"
(
    "DEPLOYMENTID" NVARCHAR2(150) NOT NULL ENABLE,
    "ADDRESS" VARCHAR2(45 BYTE) NOT NULL ENABLE,
    "PORT" NUMBER(*,0) NOT NULL ENABLE,
    "GENERATION" NUMBER(*,0) NOT NULL ENABLE,
    "SILONAME" NVARCHAR2(150) NOT NULL ENABLE,
    "HOSTNAME" NVARCHAR2(150) NOT NULL ENABLE,
    "STATUS" NUMBER(*,0) NOT NULL ENABLE,
    "PROXYPORT" NUMBER(*,0),
    "SUSPECTTIMES" VARCHAR2(4000 BYTE),
    "STARTTIME" TIMESTAMP (6) NOT NULL ENABLE,
    "IAMALIVETIME" TIMESTAMP (6) NOT NULL ENABLE,

    CONSTRAINT "ORLEANSMEMBERSHIPTABLE_PK" PRIMARY KEY ("DEPLOYMENTID", "ADDRESS", "PORT", "GENERATION"),
    CONSTRAINT "ORLEANSMEMBERSHIPTABLE_FK1" FOREIGN KEY ("DEPLOYMENTID")
	  REFERENCES "ORLEANSMEMBERSHIPVERSIONTABLE" ("DEPLOYMENTID") ENABLE
);
/

CREATE OR REPLACE FUNCTION InsertMembership(PARAM_DEPLOYMENTID IN NVARCHAR2, PARAM_IAMALIVETIME IN TIMESTAMP, PARAM_SILONAME IN NVARCHAR2, PARAM_HOSTNAME IN NVARCHAR2, PARAM_ADDRESS IN VARCHAR2,
                                    PARAM_PORT IN NUMBER, PARAM_GENERATION IN NUMBER, PARAM_STARTTIME IN TIMESTAMP, PARAM_STATUS IN NUMBER, PARAM_PROXYPORT IN NUMBER, PARAM_VERSION IN NUMBER)
  RETURN NUMBER IS
  rowcount NUMBER;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    INSERT INTO OrleansMembershipTable
    (
      DeploymentId,
      Address,
      Port,
      Generation,
      SiloName,
      HostName,
      Status,
      ProxyPort,
      StartTime,
      IAmAliveTime
    )
    SELECT
      PARAM_DEPLOYMENTID,
      PARAM_ADDRESS,
      PARAM_PORT,
      PARAM_GENERATION,
      PARAM_SILONAME,
      PARAM_HOSTNAME,
      PARAM_STATUS,
      PARAM_PROXYPORT,
      PARAM_STARTTIME,
      PARAM_IAMALIVETIME
    FROM DUAL WHERE NOT EXISTS
    (
      SELECT 1 FROM OrleansMembershipTable WHERE
        DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
        AND Address = PARAM_ADDRESS AND PARAM_ADDRESS IS NOT NULL
        AND Port = PARAM_PORT AND PARAM_PORT IS NOT NULL
        AND Generation = PARAM_GENERATION AND PARAM_GENERATION IS NOT NULL
    );
    rowcount :=	SQL%ROWCOUNT;
    UPDATE OrleansMembershipVersionTable
    SET Timestamp = sys_extract_utc(systimestamp),
        Version = Version + 1
    WHERE
  		DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
    	AND Version = PARAM_VERSION AND PARAM_VERSION IS NOT NULL
      AND rowcount > 0;
    rowcount :=	SQL%ROWCOUNT;
    IF rowcount = 0 THEN
      ROLLBACK;
    ELSE
      COMMIT;
    END IF;

    IF rowcount > 0 THEN
      RETURN(1);
    ELSE
      RETURN(0);
    END IF;
  END;
/

CREATE OR REPLACE FUNCTION UpdateMembership(PARAM_DEPLOYMENTID IN NVARCHAR2, PARAM_ADDRESS IN VARCHAR2, PARAM_PORT IN NUMBER, PARAM_GENERATION IN NUMBER,
                                               PARAM_IAMALIVETIME IN TIMESTAMP, PARAM_STATUS IN NUMBER, PARAM_SUSPECTTIMES IN VARCHAR2, PARAM_VERSION IN NUMBER
                                              )
  RETURN NUMBER IS
  rowcount NUMBER;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    UPDATE OrleansMembershipVersionTable
      SET
        Timestamp = sys_extract_utc(systimestamp),
        Version = Version + 1
    WHERE
		DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
		AND Version = PARAM_VERSION AND PARAM_VERSION IS NOT NULL;
    rowcount := SQL%ROWCOUNT;
    UPDATE OrleansMembershipTable
      SET
        Status = PARAM_STATUS,
        SuspectTimes = PARAM_SUSPECTTIMES,
        IAmAliveTime = PARAM_IAMALIVETIME
      WHERE DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
        AND Address = PARAM_ADDRESS AND PARAM_ADDRESS IS NOT NULL
        AND Port = PARAM_PORT AND PARAM_PORT IS NOT NULL
        AND Generation = PARAM_GENERATION AND PARAM_GENERATION IS NOT NULL
        AND rowcount > 0;
    rowcount := SQL%ROWCOUNT;
    COMMIT;
    RETURN(rowcount);
  END;
/

CREATE OR REPLACE FUNCTION InsertMembershipVersion(PARAM_DEPLOYMENTID IN NVARCHAR2)
RETURN NUMBER IS
rowcount NUMBER;
PRAGMA AUTONOMOUS_TRANSACTION;
BEGIN
  INSERT INTO OrleansMembershipVersionTable
      (
        DeploymentId
      )
      SELECT PARAM_DEPLOYMENTID FROM DUAL WHERE NOT EXISTS
      (
        SELECT 1 FROM OrleansMembershipVersionTable WHERE
        DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
      );
      rowCount := SQL%ROWCOUNT;

      COMMIT;
      RETURN(rowCount);
END;
/

CREATE OR REPLACE FUNCTION UpdateIAmAlivetime(PARAM_DEPLOYMENTID IN NVARCHAR2, PARAM_ADDRESS in VARCHAR2, PARAM_PORT IN NUMBER,
                                                 PARAM_GENERATION IN NUMBER, PARAM_IAMALIVE IN TIMESTAMP)
RETURN NUMBER IS
rowcount NUMBER;
PRAGMA AUTONOMOUS_TRANSACTION;
BEGIN
    UPDATE OrleansMembershipTable
        SET
            IAmAliveTime = PARAM_IAMALIVE
        WHERE
            DeploymentId = PARAM_DEPLOYMENTID AND PARAM_DEPLOYMENTID IS NOT NULL
            AND Address = PARAM_ADDRESS AND PARAM_ADDRESS IS NOT NULL
            AND Port = PARAM_PORT AND PARAM_PORT IS NOT NULL
            AND Generation = PARAM_GENERATION AND PARAM_GENERATION IS NOT NULL;
      COMMIT;
      RETURN(0);
END;
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'UpdateIAmAlivetimeKey','
    SELECT UpdateIAmAlivetime(:DeploymentId, :Address, :Port, :Generation, :IAmAliveTime) AS RESULT FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'InsertMembershipVersionKey','
    SELECT InsertMembershipVersion(:DeploymentId) AS RESULT FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'InsertMembershipKey','
    SELECT INSERTMEMBERSHIP(:DeploymentId,:IAmAliveTime,:SiloName,:Hostname,:Address,:Port,:Generation,:StartTime,:Status,:ProxyPort,:Version) FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'UpdateMembershipKey','
    SELECT UpdateMembership(:DeploymentId, :Address, :Port, :Generation, :IAmAliveTime, :Status, :SuspectTimes, :Version) AS RESULT FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'MembershipReadRowKey','
    SELECT v.DeploymentId, m.Address, m.Port, m.Generation, m.SiloName, m.HostName,
       m.Status, m.ProxyPort, m.SuspectTimes, m.StartTime, m.IAmAliveTime, v.Version
    FROM
        OrleansMembershipVersionTable v
        LEFT OUTER JOIN OrleansMembershipTable m ON v.DeploymentId = m.DeploymentId
        AND Address = :Address AND :Address IS NOT NULL
        AND Port = :Port AND :Port IS NOT NULL
        AND Generation = :Generation AND :Generation IS NOT NULL
    WHERE
        v.DeploymentId = :DeploymentId AND :DeploymentId IS NOT NULL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'MembershipReadAllKey','
    SELECT v.DeploymentId, m.Address, m.Port, m.Generation, m.SiloName, m.HostName, m.Status,
       m.ProxyPort, m.SuspectTimes, m.StartTime, m.IAmAliveTime, v.Version
    FROM
        OrleansMembershipVersionTable v
        LEFT OUTER JOIN OrleansMembershipTable m ON v.DeploymentId = m.DeploymentId
    WHERE
        v.DeploymentId = :DeploymentId AND :DeploymentId IS NOT NULL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'DeleteMembershipTableEntriesKey','
  BEGIN
    DELETE FROM OrleansMembershipTable
      WHERE DeploymentId = :DeploymentId AND :DeploymentId IS NOT NULL;
    DELETE FROM OrleansMembershipVersionTable
      WHERE DeploymentId = :DeploymentId AND :DeploymentId IS NOT NULL;
  END;
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'GatewaysQueryKey','
    SELECT Address, ProxyPort, Generation
    FROM OrleansMembershipTable
    WHERE DeploymentId = :DeploymentId AND :DeploymentId IS NOT NULL
      AND Status = :Status AND :Status IS NOT NULL
      AND ProxyPort > 0
');
/

COMMIT;

CREATE TABLE "STORAGE"
(

    -- These are for the book keeping. Orleans calculates
    -- these hashes (see RelationalStorageProvide implementation),
    -- which are signed 32 bit integers mapped to the *Hash fields.
    -- The mapping is done in the code. The
    -- *String columns contain the corresponding clear name fields.
    --
    -- If there are duplicates, they are resolved by using GrainIdN0,
    -- GrainIdN1, GrainIdExtensionString and GrainTypeString fields.
    -- It is assumed these would be rarely needed.
    "GRAINIDHASH" NUMBER(*,0) NOT NULL ENABLE,
    "GRAINIDN0" NUMBER(19,0) NOT NULL ENABLE,
    "GRAINIDN1" NUMBER(19,0) NOT NULL ENABLE,
    "GRAINTYPEHASH" NUMBER(*,0) NOT NULL ENABLE,
    "GRAINTYPESTRING" NVARCHAR2(512) NOT NULL ENABLE,
    "GRAINIDEXTENSIONSTRING" NVARCHAR2(512),
    "SERVICEID" NVARCHAR2(150) NOT NULL ENABLE,


    -- The usage of the Payload records is exclusive in that
    -- only one should be populated at any given time and two others
    -- are NULL. The types are separated to advantage on special
    -- processing capabilities present on database engines (not all might
    -- have both JSON and XML types.
    --
    -- One is free to alter the size of these fields.
    "PAYLOADBINARY" BLOB,
    "PAYLOADXML" CLOB,
    "PAYLOADJSON" CLOB,
    -- Informational field, no other use.
    "MODIFIEDON" TIMESTAMP (6) NOT NULL ENABLE,
    -- The version of the stored payload.
    "VERSION" NUMBER(*,0)

    -- The following would in principle be the primary key, but it would be too thick
    -- to be indexed, so the values are hashed and only collisions will be solved
    -- by using the fields. That is, after the indexed queries have pinpointed the right
    -- rows down to [0, n] relevant ones, n being the number of collided value pairs.
);
CREATE INDEX "IX_STORAGE" ON "STORAGE" ("GRAINIDHASH", "GRAINTYPEHASH") PARALLEL
COMPRESS;
/

CREATE OR REPLACE FUNCTION WriteToStorage(PARAM_GRAINIDHASH IN NUMBER, PARAM_GRAINIDN0 IN NUMBER, PARAM_GRAINIDN1 IN NUMBER, PARAM_GRAINTYPEHASH IN NUMBER, PARAM_GRAINTYPESTRING IN NVARCHAR2,
                                             PARAM_GRAINIDEXTENSIONSTRING IN NVARCHAR2, PARAM_SERVICEID IN VARCHAR2, PARAM_GRAINSTATEVERSION IN NUMBER, PARAM_PAYLOADBINARY IN BLOB,
                                             PARAM_PAYLOADJSON IN CLOB, PARAM_PAYLOADXML IN CLOB)
  RETURN NUMBER IS
  rowcount NUMBER;
  newGrainStateVersion NUMBER := PARAM_GRAINSTATEVERSION;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    -- When Orleans is running in normal, non-split state, there will
    -- be only one grain with the given ID and type combination only. This
    -- grain saves states mostly serially if Orleans guarantees are upheld. Even
    -- if not, the updates should work correctly due to version number.
    --
    -- In split brain situations there can be a situation where there are two or more
    -- grains with the given ID and type combination. When they try to INSERT
    -- concurrently, the table needs to be locked pessimistically before one of
    -- the grains gets @GrainStateVersion = 1 in return and the other grains will fail
    -- to update storage. The following arrangement is made to reduce locking in normal operation.
    --
    -- If the version number explicitly returned is still the same, Orleans interprets it so the update did not succeed
    -- and throws an InconsistentStateException.
    --
    -- See further information at https://dotnet.github.io/orleans/Documentation/Core-Features/Grain-Persistence.html.


    -- If the @GrainStateVersion is not zero, this branch assumes it exists in this database.
    -- The NULL value is supplied by Orleans when the state is new.
    IF newGrainStateVersion IS NOT NULL THEN
        UPDATE Storage
        SET
            PayloadBinary = PARAM_PAYLOADBINARY,
            PayloadJson = PARAM_PAYLOADJSON,
            PayloadXml = PARAM_PAYLOADXML,
            ModifiedOn = sys_extract_utc(systimestamp),
            Version = Version + 1
        WHERE
            GrainIdHash = PARAM_GRAINIDHASH AND PARAM_GRAINIDHASH IS NOT NULL
            AND GrainTypeHash = PARAM_GRAINTYPEHASH AND PARAM_GRAINTYPEHASH IS NOT NULL
            AND (GrainIdN0 = PARAM_GRAINIDN0 OR PARAM_GRAINIDN0 IS NULL)
            AND (GrainIdN1 = PARAM_GRAINIDN1 OR PARAM_GRAINIDN1 IS NULL)
            AND (GrainTypeString = PARAM_GRAINTYPESTRING OR PARAM_GRAINTYPESTRING IS NULL)
            AND ((PARAM_GRAINIDEXTENSIONSTRING IS NOT NULL AND GrainIdExtensionString IS NOT NULL AND GrainIdExtensionString = PARAM_GRAINIDEXTENSIONSTRING) OR PARAM_GRAINIDEXTENSIONSTRING IS NULL AND GrainIdExtensionString IS NULL)
            AND ServiceId = PARAM_SERVICEID AND PARAM_SERVICEID IS NOT NULL
            AND Version IS NOT NULL AND Version = PARAM_GRAINSTATEVERSION AND PARAM_GRAINSTATEVERSION IS NOT NULL
    RETURNING Version INTO newGrainStateVersion;

    rowcount := SQL%ROWCOUNT;

    IF rowcount = 1 THEN
      COMMIT;
      RETURN(newGrainStateVersion);
    END IF;
    END IF;

    -- The grain state has not been read. The following locks rather pessimistically
    -- to ensure only one INSERT succeeds.
    IF PARAM_GRAINSTATEVERSION IS NULL THEN
        INSERT INTO Storage
        (
            GrainIdHash,
            GrainIdN0,
            GrainIdN1,
            GrainTypeHash,
            GrainTypeString,
            GrainIdExtensionString,
            ServiceId,
            PayloadBinary,
            PayloadJson,
            PayloadXml,
            ModifiedOn,
            Version
        )
        SELECT
            PARAM_GRAINIDHASH,
            PARAM_GRAINIDN0,
            PARAM_GRAINIDN1,
            PARAM_GRAINTYPEHASH,
            PARAM_GRAINTYPESTRING,
            PARAM_GRAINIDEXTENSIONSTRING,
            PARAM_SERVICEID,
            PARAM_PAYLOADBINARY,
            PARAM_PAYLOADJSON,
            PARAM_PAYLOADXML,
            sys_extract_utc(systimestamp),
            1 FROM DUAL
         WHERE NOT EXISTS
         (
            -- There should not be any version of this grain state.
            SELECT 1
            FROM Storage
            WHERE
                GrainIdHash = PARAM_GRAINIDHASH AND PARAM_GRAINIDHASH IS NOT NULL
                AND GrainTypeHash = PARAM_GRAINTYPEHASH AND PARAM_GRAINTYPEHASH IS NOT NULL
                AND (GrainIdN0 = PARAM_GRAINIDN0 OR PARAM_GRAINIDN0 IS NULL)
                AND (GrainIdN1 = PARAM_GRAINIDN1 OR PARAM_GRAINIDN1 IS NULL)
                AND (GrainTypeString = PARAM_GRAINTYPESTRING OR PARAM_GRAINTYPESTRING IS NULL)
                AND ((PARAM_GRAINIDEXTENSIONSTRING IS NOT NULL AND GrainIdExtensionString IS NOT NULL AND GrainIdExtensionString = PARAM_GRAINIDEXTENSIONSTRING) OR PARAM_GRAINIDEXTENSIONSTRING IS NULL AND GrainIdExtensionString IS NULL)
                AND ServiceId = PARAM_SERVICEID AND PARAM_SERVICEID IS NOT NULL
         );

     rowCount := SQL%ROWCOUNT;

        IF rowCount > 0 THEN
            newGrainStateVersion := 1;
        END IF;
    END IF;
  COMMIT;
    RETURN(newGrainStateVersion);
  END;
/

CREATE OR REPLACE FUNCTION ClearStorage(PARAM_GRAINIDHASH IN NUMBER, PARAM_GRAINIDN0 IN NUMBER, PARAM_GRAINIDN1 IN NUMBER, PARAM_GRAINTYPEHASH IN NUMBER, PARAM_GRAINTYPESTRING IN NVARCHAR2,
                                             PARAM_GRAINIDEXTENSIONSTRING IN NVARCHAR2, PARAM_SERVICEID IN VARCHAR2, PARAM_GRAINSTATEVERSION IN NUMBER)
  RETURN NUMBER IS
  rowcount NUMBER;
  newGrainStateVersion NUMBER := PARAM_GRAINSTATEVERSION;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    UPDATE Storage
    SET
        PayloadBinary = NULL,
        PayloadJson = NULL,
        PayloadXml = NULL,
        ModifiedOn = sys_extract_utc(systimestamp),
        Version = Version + 1
    WHERE GrainIdHash = PARAM_GRAINIDHASH AND PARAM_GRAINIDHASH IS NOT NULL
      AND GrainTypeHash = PARAM_GRAINTYPEHASH AND PARAM_GRAINTYPEHASH IS NOT NULL
      AND (GrainIdN0 = PARAM_GRAINIDN0 OR PARAM_GRAINIDN0 IS NULL)
      AND (GrainIdN1  = PARAM_GRAINIDN1 OR PARAM_GRAINIDN1 IS NULL)
      AND (GrainTypeString = PARAM_GRAINTYPESTRING OR PARAM_GRAINTYPESTRING IS NULL)
      AND ((PARAM_GRAINIDEXTENSIONSTRING IS NOT NULL AND GrainIdExtensionString IS NOT NULL AND GrainIdExtensionString = PARAM_GRAINIDEXTENSIONSTRING) OR PARAM_GRAINIDEXTENSIONSTRING IS NULL AND GrainIdExtensionString IS NULL)
      AND ServiceId = PARAM_SERVICEID AND PARAM_SERVICEID IS NOT NULL
      AND Version IS NOT NULL AND Version = PARAM_GRAINSTATEVERSION AND PARAM_GRAINSTATEVERSION IS NOT NULL
    RETURNING Version INTO newGrainStateVersion;

    COMMIT;
    RETURN(newGrainStateVersion);
  END;
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'WriteToStorageKey','
  SELECT WriteToStorage(:GrainIdHash, :GrainIdN0, :GrainIdN1, :GrainTypeHash, :GrainTypeString,
                                             :GrainIdExtensionString, :ServiceId, :GrainStateVersion, :PayloadBinary,
                                             :PayloadJson, :PayloadXml) AS NewGrainStateVersion FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ClearStorageKey',
    'SELECT ClearStorage(:GrainIdHash, :GrainIdN0, :GrainIdN1, :GrainTypeHash, :GrainTypeString,
                                             :GrainIdExtensionString, :ServiceId, :GrainStateVersion) AS Version FROM DUAL'
);
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ReadFromStorageKey',
    '
     SELECT PayloadBinary, PayloadXml, PayloadJson, Version
     FROM Storage
     WHERE GrainIdHash = :GrainIdHash AND :GrainIdHash IS NOT NULL
       AND (GrainIdN0 = :GrainIdN0 OR :GrainIdN0 IS NULL)
       AND (GrainIdN1 = :GrainIdN1 OR :GrainIdN1 IS NULL)
       AND GrainTypeHash = :GrainTypeHash AND :GrainTypeHash IS NOT NULL
       AND (GrainTypeString = :GrainTypeString OR :GrainTypeString IS NULL)
       AND ((:GrainIdExtensionString IS NOT NULL AND GrainIdExtensionString IS NOT NULL AND GrainIdExtensionString = :GrainIdExtensionString) OR :GrainIdExtensionString IS NULL AND GrainIdExtensionString IS NULL)
       AND ServiceId = :ServiceId AND :ServiceId IS NOT NULL'
);
/

COMMIT;

-- Orleans Reminders table - https://dotnet.github.io/orleans/Documentation/Core-Features/Timers-and-Reminders.html
CREATE TABLE "ORLEANSREMINDERSTABLE"
(
    "SERVICEID" NVARCHAR2(150) NOT NULL ENABLE,
    "GRAINID" VARCHAR2(150) NOT NULL,
    "REMINDERNAME" NVARCHAR2(150) NOT NULL,
    "STARTTIME" TIMESTAMP(6) NOT NULL ENABLE,
    "PERIOD" INT NULL,
    "GRAINHASH" INT NOT NULL,
    "VERSION" INT NOT NULL,

    CONSTRAINT PK_REMINDERSTABLE PRIMARY KEY(SERVICEID, GRAINID, REMINDERNAME)
);
/

CREATE OR REPLACE FUNCTION UpsertReminderRow(PARAM_SERVICEID IN NVARCHAR2, PARAM_GRAINHASH IN INT, PARAM_GRAINID IN VARCHAR2, PARAM_REMINDERNAME IN NVARCHAR2,
                                                PARAM_STARTTIME IN TIMESTAMP, PARAM_PERIOD IN NUMBER)
RETURN NUMBER IS
  rowcount NUMBER;
  currentVersion NUMBER := 0;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    MERGE INTO OrleansRemindersTable ort
    USING (
      SELECT PARAM_SERVICEID as SERVICEID,
        PARAM_GRAINID as GRAINID,
        PARAM_REMINDERNAME as REMINDERNAME,
        PARAM_STARTTIME as STARTTIME,
        PARAM_PERIOD as PERIOD,
        PARAM_GRAINHASH GRAINHASH
      FROM dual
    ) n_ort
    ON (ort.ServiceId = n_ort.SERVICEID AND
        ort.GrainId = n_ort.GRAINID AND
        ort.ReminderName = n_ort.REMINDERNAME
    )
    WHEN MATCHED THEN
    UPDATE SET
      ort.StartTime = n_ort.STARTTIME,
      ort.Period = n_ort.PERIOD,
      ort.GrainHash = n_ort.GRAINHASH,
      ort.Version = ort.Version+1
    WHEN NOT MATCHED THEN
    INSERT (ort.ServiceId, ort.GrainId, ort.ReminderName, ort.StartTime, ort.Period, ort.GrainHash, ort.Version)
    VALUES (n_ort.SERVICEID, n_ort.GRAINID, n_ort.REMINDERNAME, n_ort.STARTTIME, n_ort.PERIOD, n_ort.GRAINHASH, 0);

    SELECT Version INTO currentVersion FROM OrleansRemindersTable
        WHERE ServiceId = PARAM_SERVICEID AND PARAM_SERVICEID IS NOT NULL
        AND GrainId = PARAM_GRAINID AND PARAM_GRAINID IS NOT NULL
        AND ReminderName = PARAM_REMINDERNAME AND PARAM_REMINDERNAME IS NOT NULL;
    COMMIT;
    RETURN(currentVersion);
  END;
/

CREATE OR REPLACE FUNCTION DeleteReminderRow(PARAM_SERVICEID IN NVARCHAR2, PARAM_GRAINID IN VARCHAR2, PARAM_REMINDERNAME IN NVARCHAR2,
                                                PARAM_VERSION IN NUMBER)
RETURN NUMBER IS
  rowcount NUMBER;
  PRAGMA AUTONOMOUS_TRANSACTION;
  BEGIN
    DELETE FROM OrleansRemindersTable
      WHERE ServiceId = PARAM_SERVICEID AND PARAM_SERVICEID IS NOT NULL
        AND GrainId = PARAM_GRAINID AND PARAM_GRAINID IS NOT NULL
        AND ReminderName = PARAM_REMINDERNAME AND PARAM_REMINDERNAME IS NOT NULL
        AND Version = PARAM_VERSION AND PARAM_VERSION IS NOT NULL;

    rowcount := SQL%ROWCOUNT;

    COMMIT;
    RETURN(rowcount);
  END;
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'UpsertReminderRowKey','
    SELECT UpsertReminderRow(:ServiceId, :GrainHash, :GrainId, :ReminderName, :StartTime, :Period) AS Version FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ReadReminderRowsKey','
    SELECT GrainId, ReminderName, StartTime, Period, Version
    FROM OrleansRemindersTable
    WHERE
        ServiceId = :ServiceId AND :ServiceId IS NOT NULL
        AND GrainId = :GrainId AND :GrainId IS NOT NULL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ReadReminderRowKey','
    SELECT GrainId, ReminderName, StartTime, Period, Version
    FROM OrleansRemindersTable
    WHERE
        ServiceId = :ServiceId AND :ServiceId IS NOT NULL
        AND GrainId = :GrainId AND :GrainId IS NOT NULL
        AND ReminderName = :ReminderName AND :ReminderName IS NOT NULL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ReadRangeRows1Key','
    SELECT GrainId, ReminderName, StartTime, Period, Version
    FROM OrleansRemindersTable
    WHERE
        ServiceId = :ServiceId AND :ServiceId IS NOT NULL
        AND GrainHash > :BeginHash AND :BeginHash IS NOT NULL
        AND GrainHash <= :EndHash AND :EndHash IS NOT NULL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'ReadRangeRows2Key','
    SELECT GrainId, ReminderName, StartTime, Period,Version
    FROM OrleansRemindersTable
    WHERE
        ServiceId = :ServiceId AND :ServiceId IS NOT NULL
        AND ((GrainHash > :BeginHash AND :BeginHash IS NOT NULL)
        OR (GrainHash <= :EndHash AND :EndHash IS NOT NULL))
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'DeleteReminderRowKey','
    SELECT DeleteReminderRow(:ServiceId, :GrainId, :ReminderName, :Version) AS RESULT FROM DUAL
');
/

INSERT INTO OrleansQuery(QueryKey, QueryText)
VALUES
(
    'DeleteReminderRowsKey','
    DELETE FROM OrleansRemindersTable
    WHERE ServiceId = :ServiceId AND :ServiceId IS NOT NULL
');
/

COMMIT;
