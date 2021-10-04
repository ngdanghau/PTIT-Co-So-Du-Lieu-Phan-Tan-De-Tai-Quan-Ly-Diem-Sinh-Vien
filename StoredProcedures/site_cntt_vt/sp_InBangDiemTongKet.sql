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
	SELECT SV.MASV, HOTEN = SV.HO + ' ' + SV.TEN, mh.TENMH, MAX(dk.DIEM_CC + dk.DIEM_CK + dk.DIEM_GK) AS 'DIEM'
	FROM SINHVIEN AS SV, DANGKY AS dk, MONHOC AS mh
	WHERE 
	SV.MALOP = @MALOP AND
	SV.MASV = dk.MASV
	GROUP BY sv.MASV, sv.HO, sv.TEN, mh.MAMH, mh.TENMH
	ORDER BY sv.TEN ASC

END
GO