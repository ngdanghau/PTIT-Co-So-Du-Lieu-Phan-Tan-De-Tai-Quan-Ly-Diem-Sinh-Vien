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
CREATE OR ALTER PROCEDURE sp_InBangDiemMonHoc
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM int 
AS
BEGIN

	SELECT ROW_NUMBER() over(ORDER BY sv.TEN, sv.HO) STT, sv.MASV, sv.HO, sv.TEN, dk.DIEM_CC, dk.DIEM_GK, dk.DIEM_CK, (dk.DIEM_CC *0.1 + dk.DIEM_CK * 0.6 + dk.DIEM_GK * 0.3) as 'DIEM_HM'
	FROM DANGKY as dk

	INNER JOIN LOPTINCHI as ltc ON dk.MALTC= ltc.MALTC
	INNER JOIN SINHVIEN as sv ON dk.MASV = sv.MASV

	WHERE ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.MAMH = @MAMH AND ltc.NHOM = @NHOM

	ORDER BY sv.TEN, sv.HO
	  
END
GO
