USE [QLDSV_TC]
GO
/****** Object:  StoredProcedure [dbo].[sp_InBangDiemTongKet]    Script Date: 12/14/2021 5:38:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER   PROCEDURE [dbo].[sp_InBangDiemTongKet]
	-- khai bao cac bien tam 
	@MALOP nchar(10)
AS
BEGIN
	SELECT HOTEN = SV.MASV + ' - ' +SV.HO + ' ' + SV.TEN, DIEM.TENMH, DIEM.DIEM
FROM SINHVIEN AS SV
INNER JOIN (SELECT MASV, DIEM = MAX(DIEM), TENMH
			FROM 
			(SELECT DK.MALTC, DK.MASV, DIEM = DK.DIEM_CC *0.1 + DK.DIEM_CK * 0.6 + DK.DIEM_GK * 0.3 
			FROM DANGKY DK
			GROUP BY DK.MALTC, DK.MASV, DK.DIEM_CC, DK.DIEM_CK, DK.DIEM_GK) AS DIEM

			LEFT JOIN  (
				SELECT LTC.MALTC, MH.TENMH
				FROM MONHOC MH
				INNER JOIN LOPTINCHI LTC
				ON LTC.MAMH = MH.MAMH
			) AS MH

			ON DIEM.MALTC = MH.MALTC
			GROUP BY MH.TENMH, DIEM.MASV) AS DIEM

ON SV.MASV = DIEM.MASV  AND SV.MALOP = @MALOP
GROUP BY sv.HO, sv.MASV, sv.TEN, DIEM.TENMH, DIEM.DIEM
ORDER BY sv.TEN, sv.HO ASC

END
