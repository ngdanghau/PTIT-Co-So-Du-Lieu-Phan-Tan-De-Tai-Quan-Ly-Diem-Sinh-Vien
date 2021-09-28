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
CREATE OR ALTER PROCEDURE [dbo].[sp_ThemHocPhi]
	-- khai bao cac bien tam 
	@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int, @HOCPHI int 
AS
BEGIN
	INSERT INTO HOCPHI(MASV, NIENKHOA , HOCKY, HOCPHI)
	VALUES (@MASV, @NIENKHOA, @HOCKY, @HOCPHI)
END
GO