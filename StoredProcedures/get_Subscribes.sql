USE [QLDSV_TC]
GO
/****** Object:  View [dbo].[V_DSPM]    Script Date: Thu 4 9 2020 4:54:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Get_Subscribes]
AS
SELECT        TOP (100) PERCENT PUBS.description AS TENKHOA, SUBS.subscriber_server AS TENSERVER
FROM            dbo.sysmergepublications AS PUBS INNER JOIN
                         dbo.sysmergesubscriptions AS SUBS ON PUBS.pubid = SUBS.pubid AND PUBS.publisher <> SUBS.subscriber_server

GO