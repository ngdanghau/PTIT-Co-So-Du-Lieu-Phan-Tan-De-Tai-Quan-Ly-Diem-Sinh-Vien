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
CREATE OR ALTER PROCEDURE sp_GetChiTietDongHocPhi
	-- khai bao cac bien tam 
	@MASV nchar(10), @NIENKHOA nchar(9), @HOCKY int
AS
BEGIN

	SELECT CT_DONGHOCPHI.NGAYDONG, CT_DONGHOCPHI.SOTIENDONG
	FROM CT_DONGHOCPHI
	WHERE CT_DONGHOCPHI.NIENKHOA = @NIENKHOA AND CT_DONGHOCPHI.HOCKY = @HOCKY AND CT_DONGHOCPHI.MASV = @MASV
	  
END
GO
