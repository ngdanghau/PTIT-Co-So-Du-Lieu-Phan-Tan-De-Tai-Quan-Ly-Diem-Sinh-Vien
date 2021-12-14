USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_InBangDiemMonHoc]    Script Date: 14/12/2021 4:53:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_InBangDiemMonHoc] @NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM int 
AS
BEGIN

	SELECT ROW_NUMBER() over(ORDER BY sv.TEN, sv.HO) STT, sv.MASV, sv.HO, sv.TEN, dk.DIEM_CC, dk.DIEM_GK, dk.DIEM_CK, (dk.DIEM_CC *0.1 +dk.DIEM_GK*0.3 + dk.DIEM_CK * 0.6) as 'DIEM_HM'
	FROM (SELECT ltc.MALTC from LOPTINCHI as ltc where ltc.MAMH = @MAMH AND ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.NHOM = @NHOM) as ltc

	INNER JOIN DANGKY as dk ON dk.MALTC= ltc.MALTC
	INNER JOIN SINHVIEN as sv ON dk.MASV = sv.MASV

	WHERE sv.DANGHIHOC = 'False'

	ORDER BY sv.TEN, sv.HO
	  
END
