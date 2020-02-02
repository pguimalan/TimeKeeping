USE [HRInfo]
GO
/****** Object:  StoredProcedure [dbo].[Usp_User_GetByUserName]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_User_GetByUserName]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_Department_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressUpdate]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressUpdate]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressSelect]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressSelect]
GO
/****** Object:  StoredProcedure [dbo].[Usp_AddressInsert]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP PROCEDURE [dbo].[Usp_AddressInsert]
GO
/****** Object:  Table [dbo].[TbUsers]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbUsers]
GO
/****** Object:  Table [dbo].[TbEmployeeEmpInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbEmployeeEmpInfo]
GO
/****** Object:  Table [dbo].[TbEmployeeEducation]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbEmployeeEducation]
GO
/****** Object:  Table [dbo].[TbEmployeeContactInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbEmployeeContactInfo]
GO
/****** Object:  Table [dbo].[TbEmployeeBasicInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbEmployeeBasicInfo]
GO
/****** Object:  Table [dbo].[TbDepartment]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbDepartment]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/2/2020 5:34:02 PM ******/
DROP TABLE [dbo].[TbAddress]
GO
/****** Object:  Table [dbo].[TbAddress]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  Table [dbo].[TbDepartment]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  Table [dbo].[TbEmployeeBasicInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmployeeBasicInfo](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
	[Suffix] [varchar](10) NULL,
	[BirthDate] [date] NULL,
	[PlaceOfBirth] [varchar](50) NULL,
	[Citizenship] [varchar](50) NULL,
	[Height] [varchar](50) NULL,
	[Weight] [varchar](50) NULL,
	[Religion] [varchar](50) NULL,
	[ResidentialAddress1] [varchar](150) NULL,
	[ResidentialAddress2] [varchar](350) NULL,
	[CurrentAddress1] [varchar](150) NULL,
	[CurrentAddress2] [varchar](350) NULL,
 CONSTRAINT [PK_TbEmployeeBasicInfo] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmployeeContactInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmployeeContactInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[SpouseName] [varchar](50) NULL,
	[SpouseOccupation] [varchar](50) NULL,
	[SpouseBirthDate] [date] NULL,
	[FatherName] [varchar](50) NULL,
	[FatherOccupation] [varchar](50) NULL,
	[FatherBirthDate] [date] NULL,
	[MotherName] [varchar](50) NULL,
	[MotherOccupation] [varchar](50) NULL,
	[MotherBirthDate] [date] NULL,
	[ParentAddress1] [varchar](150) NULL,
	[ParentAddress2] [varchar](350) NULL,
	[ContactNum1] [varchar](25) NULL,
	[ContactNum2] [varchar](15) NULL,
	[EmailAddress] [varchar](100) NULL,
	[ContactPersonName] [varchar](75) NULL,
	[ContactPersonNumber] [varchar](15) NULL,
	[ContactPersonAddress1] [varchar](150) NULL,
	[ContactPersonAddress2] [varchar](350) NULL,
 CONSTRAINT [PK_TbEmployeeContactInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmployeeEducation]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmployeeEducation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Elementary] [varchar](150) NULL,
	[ElemDateGraduated] [date] NULL,
	[HighSchool] [varchar](150) NULL,
	[HighSchoolDateGraduated] [date] NULL,
	[Vocational] [varchar](150) NULL,
	[VocationalCourse] [varchar](150) NULL,
	[VocationalDateGraduated] [date] NULL,
	[College] [varchar](150) NULL,
	[CollegeCourse] [varchar](150) NULL,
	[CollegeDateGraduated] [date] NULL,
	[EducationalBackgroundRemarks] [varchar](max) NULL,
 CONSTRAINT [PK_TbEmployeeEducation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbEmployeeEmpInfo]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbEmployeeEmpInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Designation] [varchar](75) NULL,
	[Department] [varchar](50) NULL,
	[EmploymentStatus] [varchar](50) NULL,
	[BasicPay] [decimal](18, 2) NULL,
	[DateHired] [date] NULL,
	[TINNo] [varchar](50) NULL,
	[SSSNo] [varchar](50) NULL,
	[PhilHealth] [varchar](50) NULL,
	[PagIbigNo] [varchar](50) NULL,
	[CharRefFullName1] [varchar](75) NULL,
	[CharRefOccupation1] [varchar](50) NULL,
	[CharRefContactNum1] [varchar](15) NULL,
	[CharRefFullName2] [varchar](75) NULL,
	[CharRefOccupation2] [varchar](50) NULL,
	[CharRefContactNum2] [varchar](15) NULL,
	[CharRefFullName3] [varchar](75) NULL,
	[CharRefOccupation3] [varchar](50) NULL,
	[CharRefContactNum3] [varchar](15) NULL,
 CONSTRAINT [PK_TbEmployeeEmpInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TbUsers]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TbUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[PasswordHash] [varbinary](250) NOT NULL,
	[PasswordSalt] [varbinary](250) NOT NULL,
	[EmployeeId] [int] NULL,
	[UserTypeId] [int] NOT NULL,
 CONSTRAINT [PK_TbUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TbAddress] ON 

INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (1, N'Sasa', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (2, N'Panacan', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (3, N'Dacudao', N'Davao City', N'Davao del Sur', N'Philippines', N'8000')
INSERT [dbo].[TbAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (4, N'asdfasdf', N'asdfarse', N'asdfas', N'asdfasdf', N'1231')
SET IDENTITY_INSERT [dbo].[TbAddress] OFF
SET IDENTITY_INSERT [dbo].[TbDepartment] ON 

INSERT [dbo].[TbDepartment] ([DepartmentId], [DepartmentName]) VALUES (1, N'ICT')
INSERT [dbo].[TbDepartment] ([DepartmentId], [DepartmentName]) VALUES (2, N'Accounting')
INSERT [dbo].[TbDepartment] ([DepartmentId], [DepartmentName]) VALUES (3, N'Human Resource')
SET IDENTITY_INSERT [dbo].[TbDepartment] OFF
SET IDENTITY_INSERT [dbo].[TbUsers] ON 

INSERT [dbo].[TbUsers] ([UserId], [UserName], [PasswordHash], [PasswordSalt], [EmployeeId], [UserTypeId]) VALUES (1, N'admin', 0x356DBE7BA2CC31F38CEA012DFBE948D522D90A3781369FC454A253C0ED41F58BFF5F40BB8BE88C4D5762957E79A6EFE34AF77C340A92D981316D807AF1721135, 0x58BF665A7AA37F4386BE395669B1DEC35D7EE064EC13A1B50BA0C71C771A1436DB44C9E4E1EDB33FEACA93F0D74633BBB5EF3B0643944608C98847BCF079D2D8213984512E5C068A092EE5AB8F61872BD1E3046B4CCC4957D9EB393E9E4EC984A176A00D5B1A74ED6DD1B096D4FA708DE303BA4BFA2CB243EFBD9E7C1FACA18F, 0, 1)
SET IDENTITY_INSERT [dbo].[TbUsers] OFF
/****** Object:  StoredProcedure [dbo].[Usp_AddressInsert]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_AddressSelect]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_AddressUpdate]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/2/2020 5:34:02 PM ******/
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
/****** Object:  StoredProcedure [dbo].[Usp_User_GetByUserName]    Script Date: 2/2/2020 5:34:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_User_GetByUserName] @iStrUserName varchar(64)
AS
BEGIN	
	SET NOCOUNT OFF;

	Select 
		UserId, PasswordHash, PasswordSalt from dbo.TbUsers
	where UserName=@iStrUserName;
	

    SET NOCOUNT ON;
END




GO
