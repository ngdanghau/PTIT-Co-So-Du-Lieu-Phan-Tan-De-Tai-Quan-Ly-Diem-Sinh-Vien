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
CREATE OR ALTER PROCEDURE sp_GhiDiem
	-- khai bao cac bien tam 
	@MAKHOA nchar(10), @NIENKHOA nchar(9), @HOCKY int, @NHOM int, @MAMH nchar(10), @MASV nchar(10), @DIEM_CC int,  @DIEM_GK float, @DIEM_CK float
AS
BEGIN
	UPDATE DANGKY
	SET DIEM_CC = @DIEM_CC, DIEM_GK = @DIEM_GK, DIEM_CK = @DIEM_CK
	FROM (
			SELECT MALTC
			FROM LOPTINCHI
			WHERE NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY AND NHOM = @NHOM AND MAKHOA = @MAKHOA
		) AS LOPTINCHI
	WHERE MASV = @MASV AND LOPTINCHI.MALTC = DANGKY.MALTC
	  
END
GO
