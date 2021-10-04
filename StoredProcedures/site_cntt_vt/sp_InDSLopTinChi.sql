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
CREATE OR ALTER PROCEDURE sp_InDSLopTinChi
	-- khai bao cac bien tam 
	@NIENKHOA nchar(9), @HOCKY int
AS
BEGIN

	SELECT mh.TENMH, ltc.NHOM, (gv.HO + ' ' + gv.TEN) as 'HO TEN', ltc.SOSVTOITHIEU, COUNT(dk.MASV) as soSVDK
	FROM  LOPTINCHI as ltc

	LEFT JOIN GIANGVIEN as gv ON gv.MAGV = ltc.MAGV
	LEFT JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
	LEFT JOIN DANGKY as dk ON dk.MALTC = ltc.MALTC

	WHERE ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY
	GROUP BY ltc.NHOM, mh.TENMH, gv.HO, gv.TEN, ltc.SOSVTOITHIEU
	ORDER BY mh.TENMH, ltc.NHOM
	  
END
GO
