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
CREATE OR ALTER PROCEDURE sp_LayDSLopTinChiDeDangKy
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int
AS
BEGIN

	SELECT ltc.MALTC, mh.MAMH, mh.TENMH, ltc.NHOM, (gv.HO + ' ' + gv.TEN) as 'HO TEN', ltc.SOSVTOITHIEU, COUNT(dk.MASV) as SOSVDK
	FROM  LOPTINCHI as ltc

	LEFT JOIN GIANGVIEN as gv ON gv.MAGV = ltc.MAGV
	LEFT JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
	LEFT JOIN (SELECT MASV, MALTC FROM DANGKY WHERE HUYDANGKY = 0) as dk ON dk.MALTC = ltc.MALTC

	WHERE ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.HUYLOP = 0
	GROUP BY ltc.MALTC, ltc.NHOM, mh.MAMH, mh.TENMH, gv.HO, gv.TEN, ltc.SOSVTOITHIEU
	ORDER BY mh.TENMH, ltc.NHOM
	  
END
GO
