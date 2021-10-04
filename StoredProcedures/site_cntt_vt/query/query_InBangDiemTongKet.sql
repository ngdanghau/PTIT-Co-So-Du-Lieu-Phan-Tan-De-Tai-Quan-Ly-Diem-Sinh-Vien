USE [QLDSV_TC]
GO

DECLARE	@return_value int

EXEC	@return_value = [dbo].[sp_InBangDiemTongKet]
		@MALOP = N'D15CQCP01'

SELECT	'Return Value' = @return_value

GO
