USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_Get_Info_Login]
		@LOGINNAME = N'GV01'

SELECT	'Return Value' = @return_value

GO
