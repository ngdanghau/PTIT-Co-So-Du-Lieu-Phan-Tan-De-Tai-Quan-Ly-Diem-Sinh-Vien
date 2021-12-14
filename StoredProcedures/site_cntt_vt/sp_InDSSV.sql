USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_InDSSV]    Script Date: 14/12/2021 3:58:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_InDSSV]
	-- Add the parameters for the stored procedure here
	@NIENKHOA nchar(9), @HOCKY int, @MAMH nchar(10), @NHOM int
AS
BEGIN

	SELECT  ROW_NUMBER() over(ORDER BY sv.TEN, sv.HO) STT, sv.MASV, sv.HO, sv.TEN, Case 
            When sv.PHAI='false' Then 'Nam' 
            Else 'Nu' END AS Phai  
			, sv.MALOP
	FROM  (SELECT ltc.MALTC from LOPTINCHI as ltc where ltc.MAMH = @MAMH AND ltc.NIENKHOA = @NIENKHOA AND ltc.HOCKY = @HOCKY AND ltc.NHOM = @NHOM) as ltc
	Inner join DANGKY as dk  on dk.MALTC = ltc.MALTC
	Inner join SINHVIEN as sv on dk.MASV = sv.MASV
	WHERE  sv.DANGHIHOC = 'False'

	ORDER BY sv.TEN, sv.HO

END
