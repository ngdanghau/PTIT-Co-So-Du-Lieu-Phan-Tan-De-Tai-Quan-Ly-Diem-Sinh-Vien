USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_PhieuDiem]    Script Date: 11/18/2021 6:07:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE [dbo].[sp_PhieuDiem]
	-- khai bao cac bien 
	@MASV char(12)
AS
BEGIN
   SELECT  ROW_NUMBER() over(ORDER BY mh.TENMH) STT, mh.TENMH , MAX(ROUND(dk.DIEM_CC,2) *0.1 + ROUND(dk.DIEM_CK,2) * 0.6 + ROUND(dk.DIEM_GK,2) * 0.3) AS 'DIEM'
   FROM LOPTINCHI as ltc

   INNER JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
   INNER JOIN DANGKY as dk ON dk.MALTC= ltc.MALTC

   WHERE dk.MASV = @MASV
   GROUP BY mh.TENMH
   ORDER BY mh.TENMH
END

