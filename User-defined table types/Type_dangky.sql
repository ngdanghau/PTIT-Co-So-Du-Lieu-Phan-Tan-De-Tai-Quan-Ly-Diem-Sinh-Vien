-- ================================
-- Create User-defined Table Type
-- ================================
USE [QLDSV_TC]
GO

-- Create the data type
CREATE TYPE [dbo].[TYPE_DANGKY] AS TABLE 
(
	[MALTC] [int] NOT NULL,
	[MASV] [nchar](10) NOT NULL,
	[DIEM_CC] [int] NULL,
	[DIEM_GK] [float] NULL,
	[DIEM_CK] [float] NULL
)
GO
