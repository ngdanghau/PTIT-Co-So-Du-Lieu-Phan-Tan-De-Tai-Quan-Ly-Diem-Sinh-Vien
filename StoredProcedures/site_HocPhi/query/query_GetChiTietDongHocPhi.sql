USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_GetChiTietDongHocPhi]
		@MASV = N'N15DCCN001',
		@NIENKHOA = N'2021-2022',
		@HOCKY = N'1'

SELECT	'Return Value' = @return_value

GO
