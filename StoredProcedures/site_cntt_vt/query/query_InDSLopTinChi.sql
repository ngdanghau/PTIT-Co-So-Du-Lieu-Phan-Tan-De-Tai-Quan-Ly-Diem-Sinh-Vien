USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_InDSLopTinChi]
		@NIENKHOA = N'2021-2022',
		@HOCKY = 1

SELECT	'Return Value' = @return_value

GO
