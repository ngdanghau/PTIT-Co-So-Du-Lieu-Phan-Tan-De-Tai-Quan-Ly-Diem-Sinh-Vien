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
CREATE OR ALTER PROCEDURE sp_GhiDiem
	-- khai bao cac bien tam 
	@DIEMTHI TYPE_DANGKY READONLY
AS
BEGIN
	MERGE INTO DANGKY AS Target
	USING (SELECT MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK FROM @DIEMTHI) AS Source
	ON Target.MALTC = Source.MALTC AND Target.MASV = Source.MASV
	WHEN MATCHED THEN 
		UPDATE SET Target.DIEM_CC = Source.DIEM_CC, Target.DIEM_GK = ROUND(Source.DIEM_GK,2), Target.DIEM_CK = ROUND(Source.DIEM_CK,2)

	WHEN NOT MATCHED THEN
		INSERT(MALTC, MASV, DIEM_CC, DIEM_GK, DIEM_CK)
		VALUES(Source.MALTC, Source.MASV, Source.DIEM_CC, ROUND(Source.DIEM_GK,2), ROUND(Source.DIEM_CK,2));
END
GO
