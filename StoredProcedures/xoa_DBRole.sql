USE [QLDSV_TC];
SELECT s.name
FROM sys.schemas s
WHERE s.principal_id = USER_ID('SV');

ALTER AUTHORIZATION ON SCHEMA::db_owner TO dbo;
ALTER AUTHORIZATION ON SCHEMA::db_securityadmin TO dbo;