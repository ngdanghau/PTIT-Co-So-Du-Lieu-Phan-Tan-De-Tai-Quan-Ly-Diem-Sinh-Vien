USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuDiem]    Script Date: 14/12/2021 5:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_PhieuDiem]
	-- khai bao cac bien 
	@MASV char(12)
AS
BEGIN
   SELECT  ROW_NUMBER() over(ORDER BY mh.TENMH) STT, mh.TENMH , MAX(dk.DIEM_CC *0.1 + dk.DIEM_CK * 0.6 + dk.DIEM_GK * 0.3) AS 'DIEM'
   
   FROM (SELECT * from DANGKY as dk where dk.MASV = @MASV ) as dk
	
   INNER JOIN LOPTINCHI as ltc ON dk.MALTC= ltc.MALTC
   INNER JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
   

   GROUP BY mh.TENMH
   ORDER BY mh.TENMH
END
