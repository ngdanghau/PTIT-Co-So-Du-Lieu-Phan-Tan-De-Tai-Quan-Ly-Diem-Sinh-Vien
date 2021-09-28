USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_PhieuDiem]
		@MASV = N'N15DCCN003'

SELECT	'Return Value' = @return_value

GO
