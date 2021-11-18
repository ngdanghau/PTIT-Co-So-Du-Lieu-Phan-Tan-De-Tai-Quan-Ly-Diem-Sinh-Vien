USE [QLDSV_TC]
GO

/****** Object:  StoredProcedure [dbo].[sp_KiemTraMaSV]    Script Date: 18/11/2021 5:04:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_KiemTraMaSV]
	-- Add the parameters for the stored procedure here
	@MASV nchar(10)
AS
BEGIN
	IF EXISTS ( SELECT * FROM SINHVIEN as sv WHERE sv.MASV = @MASV )
		BEGIN
			RAISERROR ('Mã sinh viên đã tồn tại', 16,1)
			RETURN 1;
		END

		IF EXISTS ( SELECT * FROM LINK1.QLDSV_TC.DBO.SINHVIEN as sv WHERE sv.MASV = @MASV)
		BEGIN
			RAISERROR ('Mã sinh viên đã tồn tại ở Khoa khác', 16,1)
			RETURN 1;
		END

		IF EXISTS ( SELECT * FROM LINK0.QLDSV_TC.DBO.SINHVIEN as sv WHERE sv.MASV = @MASV)
		BEGIN
			RAISERROR ('Mã sinh viên đã tồn tại ở Khoa khác', 16,1)
			RETURN 1;
		END

	RETURN 0;
END

GO


