USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_GetBangDiemMonHoc]
		@NIENKHOA = N'2021-2022',
		@HOCKY = 1,
		@MAMH = N'CTDL',
		@NHOM = 1

SELECT	'Return Value' = @return_value

GO
