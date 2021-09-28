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
CREATE OR ALTER PROCEDURE [dbo].[sp_XoaHocPhi]
	-- khai bao cac bien tam 
	@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN
	DELETE FROM HOCPHI
	WHERE MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY
END
GO