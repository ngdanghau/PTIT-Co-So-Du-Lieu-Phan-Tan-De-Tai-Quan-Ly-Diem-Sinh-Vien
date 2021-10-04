USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_InDSSV]    Script Date: 8/31/2021 2:53:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE OR ALTER PROCEDURE sp_PhieuDiem
	-- khai bao cac bien 
	@MASV char(12)
AS
BEGIN
   SELECT mh.TENMH , MAX(dk.DIEM_CC *0.1 + dk.DIEM_CK * 0.6 ) AS 'DIEM'
   FROM LOPTINCHI as ltc

   INNER JOIN MONHOC as mh ON mh.MAMH = ltc.MAMH
   INNER JOIN DANGKY as dk ON dk.MALTC= ltc.MALTC

   WHERE dk.MASV = @MASV
   GROUP BY mh.TENMH

END
