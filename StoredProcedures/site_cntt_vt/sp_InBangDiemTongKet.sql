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
CREATE OR ALTER PROCEDURE sp_InBangDiemTongKet
	-- khai bao cac bien tam 
	@MALOP nchar(10)
AS
BEGIN
	SELECT HOTEN = SV.MASV + ' - ' +SV.HO + ' ' + SV.TEN, mh.TENMH, MAX(dk.DIEM_CC *0.1 + dk.DIEM_CK * 0.6 + dk.DIEM_GK * 0.3) AS 'DIEM'
	FROM SINHVIEN AS SV, DANGKY AS dk, MONHOC AS mh
	WHERE 
	SV.MALOP = @MALOP AND
	SV.MASV = dk.MASV
	GROUP BY sv.HO, sv.MASV, sv.TEN, mh.MAMH, mh.TENMH
	ORDER BY sv.TEN, sv.HO ASC

END
GO