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
CREATE OR ALTER PROCEDURE sp_GetDanhSachDangKyLopTinChi
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int
AS
BEGIN
	SELECT sv.MASV, sv.HO + ' '+ sv.TEN as 'HOTEN', dk.DIEM_CC, dk.DIEM_GK, dk.DIEM_CK
	FROM DANGKY as dk

	INNER JOIN LOPTINCHI as ltc ON dk.MALTC= ltc.MALTC
	INNER JOIN SINHVIEN as sv ON dk.MASV = sv.MASV

	WHERE ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.MAMH = @MAMH AND ltc.NHOM = @NHOM AND ltc.MAKHOA = @MAKHOA

	ORDER BY sv.TEN, sv.HO
	  
END
GO