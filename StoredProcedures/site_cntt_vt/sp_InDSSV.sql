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
CREATE OR ALTER PROCEDURE sp_InDSSV
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM int 
AS
BEGIN

	SELECT sv.MASV, sv.HO, sv.TEN, sv.PHAI, sv.MALOP
	   FROM SINHVIEN as sv, LOPTINCHI as ltc, DANGKY as dk
	   WHERE 
		sv.MASV = dk.MASV AND ltc.MALTC = dk.MALTC AND
		ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.MAMH = @MAMH AND ltc.NHOM = @NHOM
	ORDER BY sv.TEN, sv.HO
	  
END
GO
