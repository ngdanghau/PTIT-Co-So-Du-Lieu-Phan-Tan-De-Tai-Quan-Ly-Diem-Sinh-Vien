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
CREATE OR ALTER PROCEDURE sp_GetBangDiemMonHoc
	-- khai bao cac bien tam 
	@MALTC int 
AS
BEGIN

	SELECT SV.MASV, SV.HO + ' '+ sv.TEN as 'HOTEN', DK.DIEM_CC, dk.DIEM_GK, dk.DIEM_CK
	FROM (SELECT MASV, MALTC, DIEM_CC, DIEM_GK, DIEM_CK FROM DANGKY WHERE MALTC = @MALTC) as DK, SINHVIEN SV
	WHERE SV.MASV = DK.MASV
	ORDER BY SV.TEN, SV.HO
	  
END
GO
