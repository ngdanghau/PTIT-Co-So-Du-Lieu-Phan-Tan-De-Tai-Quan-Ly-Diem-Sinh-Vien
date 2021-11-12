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
	@MALTC int, @MASV nchar(10), @MAMH nchar(10), @HOCKY int, @NIENKHOA nchar(9)
AS
BEGIN
	SELECT DK.MALTC 
	FROM DANGKY DK
	LEFT JOIN LOPTINCHI LTC
	ON  DK.MALTC = LTC.MALTC
	WHERE	LTC.MAMH = @MAMH AND 
			LTC.NIENKHOA = @NIENKHOA AND 
			LTC.HOCKY = @HOCKY  AND 
			DK.HUYDANGKY = 0 AND 
			DK.MASV = @MASV
	
	IF @@ROWCOUNT > 0
	BEGIN
		RAISERROR ('Môn học đã đăng ký rồi!', 16,1)
		RETURN 1;
	END


	UPDATE DANGKY 
	SET    HUYDANGKY = 0 
	WHERE  MALTC = @MALTC AND MASV = @MASV 

	IF @@ROWCOUNT = 0 
	  INSERT INTO DANGKY (MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK, HUYDANGKY) 
	  VALUES (@MALTC, @MASV , 0, 0, 0, 0)
END
GO
