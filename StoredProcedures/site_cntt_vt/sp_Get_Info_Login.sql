USE [QLDSV_TC]

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE sp_Get_Info_Login
	@LOGINNAME varchar(50)
AS
BEGIN
	DECLARE @TENUSER NVARCHAR(50)
	SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@LOGINNAME)
 
	DECLARE @HOTEN NVARCHAR(50)
	if exists (SELECT HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV =  @TENUSER)
	SELECT @HOTEN=HO+ ' '+ TEN FROM GIANGVIEN  WHERE MAGV =  @TENUSER

	SELECT USERNAME = @TENUSER, HOTEN = @HOTEN, TENNHOM = NAME
	   FROM sys.sysusers 
	   WHERE UID = (SELECT GROUPUID 
					FROM SYS.SYSMEMBERS 
					WHERE MEMBERUID = (SELECT UID FROM sys.sysusers WHERE NAME = @TENUSER)
					)
END
GO
