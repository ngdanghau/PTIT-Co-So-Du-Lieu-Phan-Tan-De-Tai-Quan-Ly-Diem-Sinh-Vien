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
CREATE OR ALTER PROCEDURE sp_TaoTaiKhoan
	@USERNAME VARCHAR(50),  @PASSWORD VARCHAR(50),
    @USERID VARCHAR(50),  @ROLE VARCHAR(50)    
AS

	DECLARE @RET INT

	EXEC @RET= SP_ADDLOGIN @USERNAME, @PASSWORD, 'QLDSV_TC'
	IF (@RET = 1)  -- USERNAME BI TRUNG
		BEGIN
			RETURN 1 -- Username đã tồn tại
		END 

  EXEC @RET= SP_GRANTDBACCESS @USERNAME, @USERID
  IF (@RET = 1)  -- USERID BI TRUNG
	  BEGIN
		   EXEC SP_DROPLOGIN @USERNAME
		   RETURN 2 -- UserId đã tồn tại tài khoản đăng nhập
	  END


  EXEC sp_addrolemember @ROLE, @USERID
  IF @ROLE <> 'SV'
	  BEGIN
		  EXEC sp_addsrvrolemember @USERNAME, 'SecurityAdmin'
		  EXEC sp_addsrvrolemember @USERNAME, 'SysAdmin'
		  EXEC sp_addsrvrolemember @USERNAME, 'ProcessAdmin'
	  END
  ELSE
	  BEGIN
		  EXEC sp_addsrvrolemember @USERNAME, 'ProcessAdmin'
	  END

RETURN 0 -- tạo thành công
GO
