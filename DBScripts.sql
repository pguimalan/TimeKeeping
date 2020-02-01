USE [HRInfo]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressUpdate]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressUpdate]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressSelect]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressSelect]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressInsert]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressInsert]
GO
/****** Object:  Table [dbo].[TbDepartment]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP TABLE [dbo].[TbDepartment]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/1/2020 9:00:24 PM ******/
DROP TABLE [dbo].[TbAddress]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/1/2020 9:00:24 PM ******/
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
/****** Object:  Table [dbo].[TbDepartment]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbDepartment](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TbDepartment] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbAddress] ON 

INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (1, N'Sasa', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (2, N'Panacan', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (3, N'Dacudao', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
SET IDENTITY_INSERT [dbo].[TbAddress] OFF
SET IDENTITY_INSERT [dbo].[TbDepartment] ON 

INSERT [dbo].[TbDepartment] ([DepartmentId], [DepartmentName]) VALUES (1, N'ICT')
INSERT [dbo].[TbDepartment] ([DepartmentId], [DepartmentName]) VALUES (2, N'Accounting')
SET IDENTITY_INSERT [dbo].[TbDepartment] OFF
/****** Object:  StoredProcedure [dbo].[Usp_AddressInsert]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_AddressInsert]
					@iStrBarangay varchar(50),
					@iStrMunicipal_City varchar(50),
					@iStrProvince varchar(50),
					@iStrCountry varchar(50),
					@iStrZipCode varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int);

	Insert Into dbo.TbAddress(Barangay, Municipal_City, Province, Country, ZipCode)  output inserted.AddressId into @tb
		Values(@iStrBarangay, @iStrMunicipal_City, @iStrProvince, @iStrCountry, @iStrZipCode);

	Select Top 1 Id From @tb;

	SET NOCOUNT OFF;

END
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressSelect]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_AddressSelect] @iStrSearch varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select top 100 AddressId, Barangay, Municipal_City, Province, Country, ZipCode From dbo.TbAddress where 
		Barangay LIKE @iStrSearch+'%' OR 
		Municipal_City LIKE @iStrSearch+'%' OR
		Province LIKE @iStrSearch+'%' OR
		Country LIKE @iStrSearch+'%' OR
		ZipCode LIKE @iStrSearch+'%';

	SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressUpdate]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_AddressUpdate] @iIntAddressId int, @iStrBarangay varchar(50),
					@iStrMunicipal_City varchar(50),
					@iStrProvince varchar(50),
					@iStrCountry varchar(50),
					@iStrZipCode varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TbAddress set Barangay=@iStrBarangay, Municipal_City=@iStrMunicipal_City,Province=@iStrProvince, Country=@iStrCountry, ZipCode=@iStrZipCode
	where AddressId=@iIntAddressId;

	Select @iIntAddressId as Result;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Department_Insert] @iStrDeptName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Insert Into dbo.TbDepartment(DepartmentName) Values(@iStrDeptName);

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Department_Select]	@iStrSearch varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select DepartmentId, DepartmentName From dbo.TbDepartment where DepartmentName LIKE @iStrSearch+'%';

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/1/2020 9:00:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Department_Update] @iIntDeptId int, @iStrDeptName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TbDepartment set DepartmentName=@iStrDeptName where DepartmentId=@iIntDeptId;

    SET NOCOUNT OFF;
END
GO
