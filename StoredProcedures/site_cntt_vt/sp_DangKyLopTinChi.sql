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
CREATE OR ALTER PROCEDURE sp_DangKyLopTinChi
	@MALTC int, @MASV nchar(10)
AS
BEGIN
	UPDATE DANGKY 
	SET    HUYDANGKY = 0 
	WHERE  MALTC = @MALTC AND MASV = @MASV 

	IF @@ROWCOUNT = 0 
	  INSERT INTO DANGKY (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK, HUYDANGKY) 
	  VALUES (@MALTC, @MASV , 0, 0, 0, 0)
END
GO
