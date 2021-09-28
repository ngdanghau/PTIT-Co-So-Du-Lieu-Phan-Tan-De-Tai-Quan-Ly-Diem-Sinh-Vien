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
CREATE OR ALTER PROCEDURE sp_InDSDongHocPhi
	-- khai bao cac bien tam 
	@MALOP nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN
	SELECT (hs.HO + ' ' + hs.TEN) as 'HO TEN', hs.HOCPHI, ISNULL(CT.SOTIENDADONG, 0) AS SOTIENDADONG
	FROM (

		(	SELECT hp.MASV, sv.HO, sv.TEN, hp.NIENKHOA, hp.HOCKY, hp.HOCPHI
			FROM (SELECT * FROM HOCPHI WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY ) AS hp, 
				 (SELECT MASV, HO, TEN FROM SINHVIEN WHERE MALOP = @MALOP) AS sv
			WHERE hp.MASV = sv.MASV 
		 ) AS hs

		 LEFT JOIN (
			SELECT MASV, HOCKY, NIENKHOA, SUM(SOTIENDONG) AS SOTIENDADONG
			FROM CT_DONGHOCPHI 
			GROUP BY MASV, HOCKY, NIENKHOA
		 ) AS CT
		 ON CT.MASV = HS.MASV AND CT.NIENKHOA = HS.NIENKHOA AND CT.HOCKY = HS.HOCKY
	)
	  
END
GO