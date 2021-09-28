USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_TaoTaiKhoan]
		@USERNAME = N'GV03',
		@PASSWORD = N'123456',
		@USERID = N'GV03',
		@ROLE = N'KHOA'

SELECT	'Return Value' = @return_value

GO
