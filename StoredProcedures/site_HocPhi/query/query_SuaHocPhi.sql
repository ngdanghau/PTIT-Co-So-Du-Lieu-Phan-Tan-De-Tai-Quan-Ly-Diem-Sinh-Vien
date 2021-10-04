USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_SuaHocPhi]
		@MASV = N'N15DCCN001',
		@NIENKHOA = N'2018-2019',
		@HOCKY = 1,
		@HOCPHI = '340000'

SELECT	'Return Value' = @return_value

GO
