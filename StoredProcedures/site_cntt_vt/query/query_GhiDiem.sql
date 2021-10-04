USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_GhiDiem]
		@NIENKHOA = N'2021-2022',
		@HOCKY = 1,
		@NHOM = 1,
		@MAMH = N'CTDL',
		@MASV = N'N15DCCN003',
		@DIEM_CC = 10,
		@DIEM_GK = 5,
		@DIEM_CK = 10

SELECT	'Return Value' = @return_value

GO
