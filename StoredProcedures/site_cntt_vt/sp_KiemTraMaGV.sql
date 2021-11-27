USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaMH]    Script Date: 11/27/2021 8:51:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROC [dbo].[sp_KiemTraMaGV]
@MAGV char(15), @MAKHOA char(10)
AS
BEGIN
	IF NOT EXISTS  ( SELECT * FROM GIANGVIEN WHERE GIANGVIEN.MAGV = @MAGV AND GIANGVIEN.MAKHOA = @MAKHOA)
	BEGIN
		RAISERROR ('Mã giảng viên không tồn tại trên khoa đang chọn', 16,1)
		RETURN 1;
	END

RETURN 0;
END