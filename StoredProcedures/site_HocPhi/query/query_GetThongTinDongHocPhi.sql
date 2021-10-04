USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_GetThongTinDongHocPhi]
		@MASV = N'N15DCCN001'

SELECT	'Return Value' = @return_value

GO
