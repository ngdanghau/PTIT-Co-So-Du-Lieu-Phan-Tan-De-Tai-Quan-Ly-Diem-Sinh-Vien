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
CREATE OR ALTER PROCEDURE sp_GetDS_LTC
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int
AS
BEGIN

	SELECT MALTC, TENMH, NHOM, HO + ' ' + TEN AS 'HOTEN'
	FROM (SELECT MALTC, MAMH, NHOM, MAGV FROM LOPTINCHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY AND HUYLOP = 0) LTC, MONHOC MH, GIANGVIEN GV
	WHERE LTC.MAMH = MH.MAMH AND LTC.MAGV = GV.MAGV
	ORDER BY TENMH, NHOM
END
GO
