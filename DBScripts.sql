USE [HRInfo]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/1/2020 3:28:53 PM ******/
DROP TABLE [dbo].[TbAddress]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/1/2020 3:28:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbAddress](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Barangay] [varchar](50) NULL,
	[Municipal_City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[ZipCode] [varchar](10) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbAddress] ON 

INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (1, N'Sasa', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (2, N'Panacan', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
SET IDENTITY_INSERT [dbo].[TbAddress] OFF
