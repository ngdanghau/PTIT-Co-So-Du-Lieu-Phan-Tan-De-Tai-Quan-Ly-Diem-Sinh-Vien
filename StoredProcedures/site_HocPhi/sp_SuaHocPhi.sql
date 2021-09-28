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
CREATE OR ALTER PROCEDURE [dbo].[sp_SuaHocPhi]
	-- khai bao cac bien tam 
	@MASV nchar(10), 
	@NIENKHOA nchar(9), @HOCKY int, @HOCPHI int, 
	@NIENKHOANEW nchar(9), @HOCKYNEW  int, @HOCPHINEW  int
AS
BEGIN
	UPDATE HOCPHI
	SET  NIENKHOA = @NIENKHOANEW, HOCKY = @HOCKYNEW, HOCPHI = @HOCPHINEW
	WHERE MASV = @MASV AND NIENKHOA = @NIENKHOA AND HOCKY = @HOCKY 
END
GO