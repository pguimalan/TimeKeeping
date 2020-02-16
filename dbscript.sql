USE [TimeKeepingDb]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Workload_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Workload_SelectById]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Workload_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_BySemId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Workload_BySemId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_ByEmpSemId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Workload_ByEmpSemId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_SelectById]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_ResetPassword]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_ResetPassword]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_GetByUserName]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_SystemUser_GetByUserName]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Semester_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_SelectDropdown]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Semester_SelectDropdown]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Semester_SelectById]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Semester_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Semester_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_LeaveCredits_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_LeaveCredits_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_LeaveCredits_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_LeaveCredits_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_SelectAll]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_FingerPrint_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_FingerPrint_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_Delete]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_FingerPrint_Delete]
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_ByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_FingerPrint_ByEmpId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEmpInfo_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEmpInfo_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_GetByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEmpInfo_GetByEmpId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEducation_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEducation_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_GetByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeEducation_GetByEmpId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeContactInfo_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeContactInfo_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_GetByEmployeeId]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeContactInfo_GetByEmployeeId]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeBasicInfo_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeBasicInfo_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_GetById]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_EmployeeBasicInfo_GetById]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Employee_SelectAll]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Employee_SelectAll]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Employee_BasicInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Employee_BasicInfo]
GO
/****** Object:  StoredProcedure [dbo].[Usp_DTR_Log]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_DTR_Log]
GO
/****** Object:  StoredProcedure [dbo].[Usp_DTR_GenerateLog]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_DTR_GenerateLog]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Department_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_SelectForDTR]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Department_SelectForDTR]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Department_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Department_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Address_Update]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Address_Select]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP PROCEDURE [dbo].[Usp_Address_Insert]
GO
ALTER TABLE [dbo].[TSemester] DROP CONSTRAINT [DF_TSemester_SemStatus]
GO
ALTER TABLE [dbo].[TEmployeeLeaves] DROP CONSTRAINT [DF_TEmployeeLeaves_IsWithPay]
GO
/****** Object:  Table [dbo].[TWorkload]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TWorkload]
GO
/****** Object:  Table [dbo].[TUsers]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TUsers]
GO
/****** Object:  Table [dbo].[TSemester]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TSemester]
GO
/****** Object:  Table [dbo].[TPayrollCutoffs]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TPayrollCutoffs]
GO
/****** Object:  Table [dbo].[TLeaveCreditSettings]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TLeaveCreditSettings]
GO
/****** Object:  Table [dbo].[TLeaveCredits]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TLeaveCredits]
GO
/****** Object:  Table [dbo].[TFingerPrint]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TFingerPrint]
GO
/****** Object:  Table [dbo].[TEmployeeLeaves]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TEmployeeLeaves]
GO
/****** Object:  Table [dbo].[TEmployeeEmpInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TEmployeeEmpInfo]
GO
/****** Object:  Table [dbo].[TEmployeeEducation]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TEmployeeEducation]
GO
/****** Object:  Table [dbo].[TEmployeeContactInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TEmployeeContactInfo]
GO
/****** Object:  Table [dbo].[TEmployeeBasicInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TEmployeeBasicInfo]
GO
/****** Object:  Table [dbo].[TDepartments]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TDepartments]
GO
/****** Object:  Table [dbo].[TDailyTimeRecord]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TDailyTimeRecord]
GO
/****** Object:  Table [dbo].[TAddress]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP TABLE [dbo].[TAddress]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetUserFullName]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP FUNCTION [dbo].[fn_GetUserFullName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetEmployeeFullName]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP FUNCTION [dbo].[fn_GetEmployeeFullName]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetEmployeeDepartment]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP FUNCTION [dbo].[fn_GetEmployeeDepartment]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetContactNumbers]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP FUNCTION [dbo].[fn_GetContactNumbers]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_FormatTime]    Script Date: 2/17/2020 12:07:34 AM ******/
DROP FUNCTION [dbo].[fn_FormatTime]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_FormatTime]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_FormatTime]
(
	@iTime time
)
RETURNS varchar(8)
AS
BEGIN	
	DECLARE @StrTime varchar(8)

	Set @StrTime=IIF(@iTime is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(8), @iTime, 100), 7)),'PM', ' PM'),'AM', ' AM'));

	RETURN @StrTime

END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetContactNumbers]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create FUNCTION [dbo].[fn_GetContactNumbers]
(
	@ContactNumber1 varchar(50)=NULL,
	@ContactNumber2 varchar(50)=NULL

)
RETURNS varchar(100)
AS
BEGIN
	Declare @ContactNumber varchar(305)='';

	IF @ContactNumber1 IS NOT NULL AND @ContactNumber1 <> ''
		SET @ContactNumber = @ContactNumber1;

	IF @ContactNumber2 IS NOT NULL AND @ContactNumber2 <> ''		
		SET @ContactNumber = @ContactNumber + ' - ' + @ContactNumber2;

	return @ContactNumber;
END
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetEmployeeDepartment]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create FUNCTION [dbo].[fn_GetEmployeeDepartment]
(
	@iIntEmployeeId int
)
RETURNS varchar(150)
AS
BEGIN	
	DECLARE @DepartmentName varchar(150)


	Select @DepartmentName=DepartmentName From TDepartments
	where DepartmentId In (Select DepartmentId From TEmployeeEmpInfo where EmployeeId=@iIntEmployeeId);

	RETURN @DepartmentName

END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetEmployeeFullName]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetEmployeeFullName]
(
	@iIntEmployeeId int
)
RETURNS varchar(150)
AS
BEGIN	
	DECLARE @fullname varchar(150)

	Select @fullname=LastName + ', ' + FirstName+ ' ' + Left(MiddleName,1)+'.' from dbo.TEmployeeBasicInfo where EmployeeId=@iIntEmployeeId;

	RETURN @fullname

END

GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetUserFullName]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fn_GetUserFullName]
(
	@iIntUserId int
)
RETURNS varchar(150)
AS
BEGIN	
	DECLARE @fullname varchar(150)

	Select @fullname=LastName + ', ' + FirstName+ ' ' + Left(MiddleName,1)+ '.' from dbo.TUsers where UserId=@iIntUserId;

	RETURN @fullname

END

GO
/****** Object:  Table [dbo].[TAddress]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAddress](
	[AddressId] [int] IDENTITY(1,1) NOT NULL,
	[Barangay] [varchar](50) NULL,
	[Municipal_City] [varchar](50) NULL,
	[Province] [varchar](50) NULL,
	[Country] [varchar](50) NULL,
	[ZipCode] [varchar](10) NULL,
 CONSTRAINT [PK_TAddress] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDailyTimeRecord]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDailyTimeRecord](
	[LogId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[CurrentDate] [date] NOT NULL,
	[TimeIn_AM] [time](7) NULL,
	[TimeIn_AM_MinsLate] [decimal](18, 2) NULL,
	[TimeOut_AM] [time](7) NULL,
	[UnderTime_AM] [decimal](18, 2) NULL,
	[TimeIn_PM] [time](7) NULL,
	[TimeIn_PM_MinsLate] [decimal](18, 2) NULL,
	[TimeOut_PM] [time](7) NULL,
	[TimeIn_Evening] [time](7) NULL,
	[TimeIn_Evening_MinsLate] [decimal](18, 2) NULL,
	[TimeOut_Evening] [time](7) NULL,
 CONSTRAINT [PK_TDailyTimeRecord] PRIMARY KEY CLUSTERED 
(
	[LogId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TDepartments]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TDepartments](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TDepartments] PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEmployeeBasicInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEmployeeBasicInfo](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
	[Suffix] [varchar](10) NULL,
	[BirthDate] [date] NOT NULL,
	[PlaceOfBirth] [varchar](50) NULL,
	[Citizenship] [varchar](50) NULL,
	[Height] [varchar](50) NULL,
	[Weight] [varchar](50) NULL,
	[Religion] [varchar](50) NULL,
	[ResidentialAddress1] [varchar](150) NULL,
	[ResidentialAddress2] [varchar](350) NULL,
	[CurrentAddress1] [varchar](150) NULL,
	[CurrentAddress2] [varchar](350) NULL,
	[Gender] [varchar](6) NULL,
	[CivilStatus] [varchar](10) NULL,
	[PicName] [varchar](300) NULL,
 CONSTRAINT [PK_TEmployeeBasicInfo] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEmployeeContactInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEmployeeContactInfo](
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
 CONSTRAINT [PK_TEmployeeContactInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEmployeeEducation]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEmployeeEducation](
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
	[HighestEducAttainment] [varchar](35) NULL,
	[EducationalBackgroundRemarks] [varchar](max) NULL,
 CONSTRAINT [PK_TEmployeeEducation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEmployeeEmpInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEmployeeEmpInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Designation] [varchar](75) NULL,
	[DepartmentId] [int] NOT NULL,
	[EmploymentType] [varchar](50) NULL,
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
	[EmpStatus] [varchar](10) NULL,
	[BasicPayOption] [varchar](10) NULL,
 CONSTRAINT [PK_TEmployeeEmpInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TEmployeeLeaves]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TEmployeeLeaves](
	[Int] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[LeaveType] [varchar](2) NOT NULL,
	[NoDaysUsed] [int] NOT NULL,
	[IsWithPay] [bit] NULL,
	[LeaveRemarks] [varchar](750) NULL,
	[CreatedBy] [varchar](75) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [varchar](75) NULL,
	[ModifiedDateTime] [datetime] NULL,
 CONSTRAINT [PK_TEmployeeLeaves] PRIMARY KEY CLUSTERED 
(
	[Int] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TFingerPrint]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TFingerPrint](
	[FPId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Finger] [tinyint] NOT NULL,
	[Mask] [int] NOT NULL,
 CONSTRAINT [PK_TFingerPrint] PRIMARY KEY CLUSTERED 
(
	[FPId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TLeaveCredits]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TLeaveCredits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[VL] [int] NULL,
	[SL] [int] NULL,
	[CurrentYear] [int] NULL,
 CONSTRAINT [PK_TbLeaveCredits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TLeaveCreditSettings]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TLeaveCreditSettings](
	[Id] [int] NOT NULL,
	[LeaveType] [varchar](2) NOT NULL,
	[NoDays] [int] NOT NULL,
 CONSTRAINT [PK_TLeaveCreditSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TPayrollCutoffs]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TPayrollCutoffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PayrollMonth] [int] NOT NULL,
	[PayrollYear] [int] NOT NULL,
	[PayrollPeriod] [int] NOT NULL,
	[PeriodStart] [date] NOT NULL,
	[PeriodEnd] [date] NOT NULL,
 CONSTRAINT [PK_TPayrollCutoffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TSemester]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TSemester](
	[SemesterId] [int] IDENTITY(1,1) NOT NULL,
	[SemesterDesc] [varchar](50) NOT NULL,
	[SchoolYear] [varchar](10) NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_TSemester] PRIMARY KEY CLUSTERED 
(
	[SemesterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TUsers]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[PasswordHash] [varbinary](250) NOT NULL,
	[PasswordSalt] [varbinary](250) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
 CONSTRAINT [PK_TUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TWorkload]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TWorkload](
	[WorkloadId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[SemesterId] [int] NOT NULL,
	[DayOfWork] [varchar](20) NOT NULL,
	[TimeInAM] [time](7) NULL,
	[TimeOutAM] [time](7) NULL,
	[TimeInPM] [time](7) NULL,
	[TimeOutPM] [time](7) NULL,
	[TimeInEvening] [time](7) NULL,
	[TimeOutEvening] [time](7) NULL,
 CONSTRAINT [PK_TWorkload] PRIMARY KEY CLUSTERED 
(
	[WorkloadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TAddress] ON 

INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (1, N'Sasa', N'Davao City', N'Davao Del Sur', N'Philippines', N'8000')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (2, N'Basa', N'Trento', N'Agusan Del Sur', N'Philippines', N'8505')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (3, N'Cebolin', N'Trento', N'Agusan Del Sur', N'Philippines', N'8505')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (4, N'Berseba', N'Bayugan City', N'Agusan Del Sur', N'Philippines', N'8502')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (5, N'Consuelo', N'Bunawan', N'Agusan Del Sur', N'Philippines', N'8506')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (6, N'Bliss', N'Bayugan City', N'Agusan Del Sur', N'Philippines', N'8502')
INSERT [dbo].[TAddress] ([AddressId], [Barangay], [Municipal_City], [Province], [Country], [ZipCode]) VALUES (7, N'San Teodoro', N'Bunawan', N'Agusan Del Sur', N'Philippines', N'8506')
SET IDENTITY_INSERT [dbo].[TAddress] OFF
SET IDENTITY_INSERT [dbo].[TDailyTimeRecord] ON 

INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (1, 1, CAST(N'2020-06-15' AS Date), CAST(N'08:02:49.9033333' AS Time), CAST(32.82 AS Decimal(18, 2)), CAST(N'12:00:00' AS Time), CAST(0.00 AS Decimal(18, 2)), CAST(N'08:03:21.3566667' AS Time), CAST(-296.65 AS Decimal(18, 2)), CAST(N'08:03:24.9300000' AS Time), CAST(N'08:05:39.6433333' AS Time), CAST(-549.35 AS Decimal(18, 2)), CAST(N'08:05:00.3033333' AS Time))
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (2, 2, CAST(N'2020-06-15' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, CAST(N'08:05:44.8000000' AS Time), CAST(-549.27 AS Decimal(18, 2)), NULL)
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (3, 1, CAST(N'2020-06-16' AS Date), CAST(N'08:10:48.4866667' AS Time), CAST(10.80 AS Decimal(18, 2)), CAST(N'08:11:20.8933333' AS Time), CAST(228.67 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (4, 2, CAST(N'2020-06-16' AS Date), CAST(N'08:11:57.2233333' AS Time), CAST(41.95 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (5, 1, CAST(N'2020-02-14' AS Date), CAST(N'08:23:55.5200000' AS Time), CAST(23.92 AS Decimal(18, 2)), CAST(N'08:24:36.0933333' AS Time), CAST(215.40 AS Decimal(18, 2)), CAST(N'18:54:48.2433333' AS Time), CAST(354.80 AS Decimal(18, 2)), NULL, NULL, NULL, NULL)
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (6, 1, CAST(N'2020-02-15' AS Date), CAST(N'09:10:37.2000000' AS Time), CAST(70.62 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TDailyTimeRecord] ([LogId], [EmployeeId], [CurrentDate], [TimeIn_AM], [TimeIn_AM_MinsLate], [TimeOut_AM], [UnderTime_AM], [TimeIn_PM], [TimeIn_PM_MinsLate], [TimeOut_PM], [TimeIn_Evening], [TimeIn_Evening_MinsLate], [TimeOut_Evening]) VALUES (7, 1, CAST(N'2020-02-16' AS Date), CAST(N'12:34:02.4333333' AS Time), CAST(274.03 AS Decimal(18, 2)), NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TDailyTimeRecord] OFF
SET IDENTITY_INSERT [dbo].[TDepartments] ON 

INSERT [dbo].[TDepartments] ([DepartmentId], [DepartmentName]) VALUES (1, N'Engineering And Information Sciences')
INSERT [dbo].[TDepartments] ([DepartmentId], [DepartmentName]) VALUES (2, N'Agriculture')
INSERT [dbo].[TDepartments] ([DepartmentId], [DepartmentName]) VALUES (3, N'Education')
INSERT [dbo].[TDepartments] ([DepartmentId], [DepartmentName]) VALUES (4, N'Basic Education')
SET IDENTITY_INSERT [dbo].[TDepartments] OFF
SET IDENTITY_INSERT [dbo].[TEmployeeBasicInfo] ON 

INSERT [dbo].[TEmployeeBasicInfo] ([EmployeeId], [LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], [PlaceOfBirth], [Citizenship], [Height], [Weight], [Religion], [ResidentialAddress1], [ResidentialAddress2], [CurrentAddress1], [CurrentAddress2], [Gender], [CivilStatus], [PicName]) VALUES (1, N'Ramon', N'Irene', N'Manuel', N'', CAST(N'1998-11-19' AS Date), N'Davao City', N'Philippine', N'', N'', N'Roman Catholic', N'NA', N'Basa, Trento, Agusan Del Sur, Philippines 8505', N'NA', N'Basa, Trento, Agusan Del Sur, Philippines 8505', N'Female', N'Single', N'Irene Ramon.pic')
INSERT [dbo].[TEmployeeBasicInfo] ([EmployeeId], [LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], [PlaceOfBirth], [Citizenship], [Height], [Weight], [Religion], [ResidentialAddress1], [ResidentialAddress2], [CurrentAddress1], [CurrentAddress2], [Gender], [CivilStatus], [PicName]) VALUES (2, N'Verona', N'Kharen', N'Dejarme', N'', CAST(N'1991-08-01' AS Date), N'Agusan Del Sur', N'Philippine', N'', N'', N'Roman Catholic', N'NA', N'Cebolin, Trento, Agusan Del Sur, Philippines 8505', N'', N'', N'Female', N'Single', N'Kharen Verona.pic')
INSERT [dbo].[TEmployeeBasicInfo] ([EmployeeId], [LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], [PlaceOfBirth], [Citizenship], [Height], [Weight], [Religion], [ResidentialAddress1], [ResidentialAddress2], [CurrentAddress1], [CurrentAddress2], [Gender], [CivilStatus], [PicName]) VALUES (3, N'Castaneras', N'Liecel', N'Taypen', N'', CAST(N'1991-03-08' AS Date), N'Bayugan', N'Philippine', N'', N'', N'Roman Catholic', N'Na', N'Bliss, Bayugan City, Agusan Del Sur, Philippines 8502', N'', N'', N'Female', N'Single', N'Liecel_Castaneras.pic')
INSERT [dbo].[TEmployeeBasicInfo] ([EmployeeId], [LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], [PlaceOfBirth], [Citizenship], [Height], [Weight], [Religion], [ResidentialAddress1], [ResidentialAddress2], [CurrentAddress1], [CurrentAddress2], [Gender], [CivilStatus], [PicName]) VALUES (4, N'Tabada', N'Manuel', N'T', N'', CAST(N'1985-03-07' AS Date), N'Agusan', N'Philippine', N'', N'', N'Roman Catholic', N'NA', N'Basa, Trento, Agusan Del Sur, Philippines 8505', N'', N'', N'Male', N'Single', N'Manuel_Tabada.pic')
INSERT [dbo].[TEmployeeBasicInfo] ([EmployeeId], [LastName], [FirstName], [MiddleName], [Suffix], [BirthDate], [PlaceOfBirth], [Citizenship], [Height], [Weight], [Religion], [ResidentialAddress1], [ResidentialAddress2], [CurrentAddress1], [CurrentAddress2], [Gender], [CivilStatus], [PicName]) VALUES (5, N'Qr', N'Asdf', N'T', N'', CAST(N'1981-02-19' AS Date), N'', N'Bulgarian', N'', N'', N'', N'asdfasdf', N'San Teodoro, Bunawan, Agusan Del Sur, Philippines 8506', N'', N'', N'Female', N'Widower', N'Asdf Qr.pic')
SET IDENTITY_INSERT [dbo].[TEmployeeBasicInfo] OFF
SET IDENTITY_INSERT [dbo].[TEmployeeContactInfo] ON 

INSERT [dbo].[TEmployeeContactInfo] ([Id], [EmployeeId], [SpouseName], [SpouseOccupation], [SpouseBirthDate], [FatherName], [FatherOccupation], [FatherBirthDate], [MotherName], [MotherOccupation], [MotherBirthDate], [ParentAddress1], [ParentAddress2], [ContactNum1], [ContactNum2], [EmailAddress], [ContactPersonName], [ContactPersonNumber], [ContactPersonAddress1], [ContactPersonAddress2]) VALUES (1, 1, N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'NA', N'Basa, Trento, Agusan Del Sur, Philippines 8505', N'09295487745', N'232-54981', N'rada@gmail.com', N'', N'', N'', N'')
INSERT [dbo].[TEmployeeContactInfo] ([Id], [EmployeeId], [SpouseName], [SpouseOccupation], [SpouseBirthDate], [FatherName], [FatherOccupation], [FatherBirthDate], [MotherName], [MotherOccupation], [MotherBirthDate], [ParentAddress1], [ParentAddress2], [ContactNum1], [ContactNum2], [EmailAddress], [ContactPersonName], [ContactPersonNumber], [ContactPersonAddress1], [ContactPersonAddress2]) VALUES (2, 2, N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[TEmployeeContactInfo] ([Id], [EmployeeId], [SpouseName], [SpouseOccupation], [SpouseBirthDate], [FatherName], [FatherOccupation], [FatherBirthDate], [MotherName], [MotherOccupation], [MotherBirthDate], [ParentAddress1], [ParentAddress2], [ContactNum1], [ContactNum2], [EmailAddress], [ContactPersonName], [ContactPersonNumber], [ContactPersonAddress1], [ContactPersonAddress2]) VALUES (3, 3, N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[TEmployeeContactInfo] ([Id], [EmployeeId], [SpouseName], [SpouseOccupation], [SpouseBirthDate], [FatherName], [FatherOccupation], [FatherBirthDate], [MotherName], [MotherOccupation], [MotherBirthDate], [ParentAddress1], [ParentAddress2], [ContactNum1], [ContactNum2], [EmailAddress], [ContactPersonName], [ContactPersonNumber], [ContactPersonAddress1], [ContactPersonAddress2]) VALUES (4, 4, N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'')
INSERT [dbo].[TEmployeeContactInfo] ([Id], [EmployeeId], [SpouseName], [SpouseOccupation], [SpouseBirthDate], [FatherName], [FatherOccupation], [FatherBirthDate], [MotherName], [MotherOccupation], [MotherBirthDate], [ParentAddress1], [ParentAddress2], [ContactNum1], [ContactNum2], [EmailAddress], [ContactPersonName], [ContactPersonNumber], [ContactPersonAddress1], [ContactPersonAddress2]) VALUES (5, 5, N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', N'', N'', N'', N'', N'', N'', N'')
SET IDENTITY_INSERT [dbo].[TEmployeeContactInfo] OFF
SET IDENTITY_INSERT [dbo].[TEmployeeEducation] ON 

INSERT [dbo].[TEmployeeEducation] ([Id], [EmployeeId], [Elementary], [ElemDateGraduated], [HighSchool], [HighSchoolDateGraduated], [Vocational], [VocationalCourse], [VocationalDateGraduated], [College], [CollegeCourse], [CollegeDateGraduated], [HighestEducAttainment], [EducationalBackgroundRemarks]) VALUES (1, 1, N'', CAST(N'2016-11-19' AS Date), N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'')
INSERT [dbo].[TEmployeeEducation] ([Id], [EmployeeId], [Elementary], [ElemDateGraduated], [HighSchool], [HighSchoolDateGraduated], [Vocational], [VocationalCourse], [VocationalDateGraduated], [College], [CollegeCourse], [CollegeDateGraduated], [HighestEducAttainment], [EducationalBackgroundRemarks]) VALUES (2, 2, N'', CAST(N'2016-11-19' AS Date), N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'')
INSERT [dbo].[TEmployeeEducation] ([Id], [EmployeeId], [Elementary], [ElemDateGraduated], [HighSchool], [HighSchoolDateGraduated], [Vocational], [VocationalCourse], [VocationalDateGraduated], [College], [CollegeCourse], [CollegeDateGraduated], [HighestEducAttainment], [EducationalBackgroundRemarks]) VALUES (3, 3, N'', CAST(N'2016-11-19' AS Date), N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'')
INSERT [dbo].[TEmployeeEducation] ([Id], [EmployeeId], [Elementary], [ElemDateGraduated], [HighSchool], [HighSchoolDateGraduated], [Vocational], [VocationalCourse], [VocationalDateGraduated], [College], [CollegeCourse], [CollegeDateGraduated], [HighestEducAttainment], [EducationalBackgroundRemarks]) VALUES (4, 4, N'', CAST(N'2016-11-19' AS Date), N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'')
INSERT [dbo].[TEmployeeEducation] ([Id], [EmployeeId], [Elementary], [ElemDateGraduated], [HighSchool], [HighSchoolDateGraduated], [Vocational], [VocationalCourse], [VocationalDateGraduated], [College], [CollegeCourse], [CollegeDateGraduated], [HighestEducAttainment], [EducationalBackgroundRemarks]) VALUES (5, 5, N'', CAST(N'2016-11-19' AS Date), N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'', CAST(N'2016-11-19' AS Date), N'', N'')
SET IDENTITY_INSERT [dbo].[TEmployeeEducation] OFF
SET IDENTITY_INSERT [dbo].[TEmployeeEmpInfo] ON 

INSERT [dbo].[TEmployeeEmpInfo] ([Id], [EmployeeId], [Designation], [DepartmentId], [EmploymentType], [BasicPay], [DateHired], [TINNo], [SSSNo], [PhilHealth], [PagIbigNo], [CharRefFullName1], [CharRefOccupation1], [CharRefContactNum1], [CharRefFullName2], [CharRefOccupation2], [CharRefContactNum2], [CharRefFullName3], [CharRefOccupation3], [CharRefContactNum3], [EmpStatus], [BasicPayOption]) VALUES (1, 1, N'Programmer', 1, N'Regular', CAST(11500.00 AS Decimal(18, 2)), CAST(N'2016-11-19' AS Date), N'   -   -', N'  -       -', N'  -         -', N'    -    -', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'Monthly')
INSERT [dbo].[TEmployeeEmpInfo] ([Id], [EmployeeId], [Designation], [DepartmentId], [EmploymentType], [BasicPay], [DateHired], [TINNo], [SSSNo], [PhilHealth], [PagIbigNo], [CharRefFullName1], [CharRefOccupation1], [CharRefContactNum1], [CharRefFullName2], [CharRefOccupation2], [CharRefContactNum2], [CharRefFullName3], [CharRefOccupation3], [CharRefContactNum3], [EmpStatus], [BasicPayOption]) VALUES (2, 2, N'Teacher', 4, N'Probationary', CAST(14000.00 AS Decimal(18, 2)), CAST(N'2019-11-19' AS Date), N'   -   -', N'  -       -', N'  -         -', N'    -    -', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'Monthly')
INSERT [dbo].[TEmployeeEmpInfo] ([Id], [EmployeeId], [Designation], [DepartmentId], [EmploymentType], [BasicPay], [DateHired], [TINNo], [SSSNo], [PhilHealth], [PagIbigNo], [CharRefFullName1], [CharRefOccupation1], [CharRefContactNum1], [CharRefFullName2], [CharRefOccupation2], [CharRefContactNum2], [CharRefFullName3], [CharRefOccupation3], [CharRefContactNum3], [EmpStatus], [BasicPayOption]) VALUES (3, 3, N'Teacher 1', 2, N'Regular', CAST(16000.00 AS Decimal(18, 2)), CAST(N'2016-11-19' AS Date), N'   -   -', N'  -       -', N'  -         -', N'    -    -', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'Monthly')
INSERT [dbo].[TEmployeeEmpInfo] ([Id], [EmployeeId], [Designation], [DepartmentId], [EmploymentType], [BasicPay], [DateHired], [TINNo], [SSSNo], [PhilHealth], [PagIbigNo], [CharRefFullName1], [CharRefOccupation1], [CharRefContactNum1], [CharRefFullName2], [CharRefOccupation2], [CharRefContactNum2], [CharRefFullName3], [CharRefOccupation3], [CharRefContactNum3], [EmpStatus], [BasicPayOption]) VALUES (4, 4, N'Principal', 3, N'Regular', CAST(22000.00 AS Decimal(18, 2)), CAST(N'2016-11-19' AS Date), N'   -   -', N'  -       -', N'  -         -', N'    -    -', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'Monthly')
INSERT [dbo].[TEmployeeEmpInfo] ([Id], [EmployeeId], [Designation], [DepartmentId], [EmploymentType], [BasicPay], [DateHired], [TINNo], [SSSNo], [PhilHealth], [PagIbigNo], [CharRefFullName1], [CharRefOccupation1], [CharRefContactNum1], [CharRefFullName2], [CharRefOccupation2], [CharRefContactNum2], [CharRefFullName3], [CharRefOccupation3], [CharRefContactNum3], [EmpStatus], [BasicPayOption]) VALUES (5, 5, N'Adfasdff Asdf', 1, N'Probationary', CAST(16000.00 AS Decimal(18, 2)), CAST(N'2016-11-19' AS Date), N'   -   -', N'  -       -', N'  -         -', N'    -    -', N'', N'', N'', N'', N'', N'', N'', N'', N'', N'Active', N'Monthly')
SET IDENTITY_INSERT [dbo].[TEmployeeEmpInfo] OFF
SET IDENTITY_INSERT [dbo].[TFingerPrint] ON 

INSERT [dbo].[TFingerPrint] ([FPId], [EmployeeId], [Finger], [Mask]) VALUES (7, 1, 2, 64)
INSERT [dbo].[TFingerPrint] ([FPId], [EmployeeId], [Finger], [Mask]) VALUES (8, 2, 3, 128)
SET IDENTITY_INSERT [dbo].[TFingerPrint] OFF
SET IDENTITY_INSERT [dbo].[TLeaveCredits] ON 

INSERT [dbo].[TLeaveCredits] ([Id], [EmployeeId], [VL], [SL], [CurrentYear]) VALUES (1, 1, 15, 15, 2020)
SET IDENTITY_INSERT [dbo].[TLeaveCredits] OFF
INSERT [dbo].[TLeaveCreditSettings] ([Id], [LeaveType], [NoDays]) VALUES (1, N'VL', 15)
INSERT [dbo].[TLeaveCreditSettings] ([Id], [LeaveType], [NoDays]) VALUES (2, N'SL', 15)
SET IDENTITY_INSERT [dbo].[TPayrollCutoffs] ON 

INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (1, 1, 2020, 1, CAST(N'2020-01-01' AS Date), CAST(N'2020-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (2, 1, 2020, 2, CAST(N'2020-01-16' AS Date), CAST(N'2020-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (3, 2, 2020, 1, CAST(N'2020-02-01' AS Date), CAST(N'2020-02-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (4, 2, 2020, 2, CAST(N'2020-02-16' AS Date), CAST(N'2020-02-29' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (5, 3, 2020, 1, CAST(N'2020-03-01' AS Date), CAST(N'2020-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (6, 3, 2020, 2, CAST(N'2020-03-16' AS Date), CAST(N'2020-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (7, 4, 2020, 1, CAST(N'2020-04-01' AS Date), CAST(N'2020-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (8, 4, 2020, 2, CAST(N'2020-04-16' AS Date), CAST(N'2020-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (9, 5, 2020, 1, CAST(N'2020-05-01' AS Date), CAST(N'2020-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (10, 5, 2020, 2, CAST(N'2020-05-16' AS Date), CAST(N'2020-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (11, 6, 2020, 1, CAST(N'2020-06-01' AS Date), CAST(N'2020-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (12, 6, 2020, 2, CAST(N'2020-06-16' AS Date), CAST(N'2020-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (13, 7, 2020, 1, CAST(N'2020-07-01' AS Date), CAST(N'2020-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (14, 7, 2020, 2, CAST(N'2020-07-16' AS Date), CAST(N'2020-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (15, 8, 2020, 1, CAST(N'2020-08-01' AS Date), CAST(N'2020-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (16, 8, 2020, 2, CAST(N'2020-08-16' AS Date), CAST(N'2020-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (17, 9, 2020, 1, CAST(N'2020-09-01' AS Date), CAST(N'2020-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (18, 9, 2020, 2, CAST(N'2020-09-16' AS Date), CAST(N'2020-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (19, 10, 2020, 1, CAST(N'2020-10-01' AS Date), CAST(N'2020-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (20, 10, 2020, 2, CAST(N'2020-10-16' AS Date), CAST(N'2020-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (21, 11, 2020, 1, CAST(N'2020-11-01' AS Date), CAST(N'2020-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (22, 11, 2020, 2, CAST(N'2020-11-16' AS Date), CAST(N'2020-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (23, 12, 2020, 1, CAST(N'2020-12-01' AS Date), CAST(N'2020-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (24, 12, 2020, 2, CAST(N'2020-12-16' AS Date), CAST(N'2020-12-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (25, 1, 2021, 1, CAST(N'2021-01-01' AS Date), CAST(N'2021-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (26, 1, 2021, 2, CAST(N'2021-01-16' AS Date), CAST(N'2021-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (27, 2, 2021, 1, CAST(N'2021-02-01' AS Date), CAST(N'2021-02-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (28, 2, 2021, 2, CAST(N'2021-02-16' AS Date), CAST(N'2021-02-28' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (29, 3, 2021, 1, CAST(N'2021-03-01' AS Date), CAST(N'2021-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (30, 3, 2021, 2, CAST(N'2021-03-16' AS Date), CAST(N'2021-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (31, 4, 2021, 1, CAST(N'2021-04-01' AS Date), CAST(N'2021-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (32, 4, 2021, 2, CAST(N'2021-04-16' AS Date), CAST(N'2021-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (33, 5, 2021, 1, CAST(N'2021-05-01' AS Date), CAST(N'2021-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (34, 5, 2021, 2, CAST(N'2021-05-16' AS Date), CAST(N'2021-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (35, 6, 2021, 1, CAST(N'2021-06-01' AS Date), CAST(N'2021-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (36, 6, 2021, 2, CAST(N'2021-06-16' AS Date), CAST(N'2021-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (37, 7, 2021, 1, CAST(N'2021-07-01' AS Date), CAST(N'2021-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (38, 7, 2021, 2, CAST(N'2021-07-16' AS Date), CAST(N'2021-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (39, 8, 2021, 1, CAST(N'2021-08-01' AS Date), CAST(N'2021-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (40, 8, 2021, 2, CAST(N'2021-08-16' AS Date), CAST(N'2021-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (41, 9, 2021, 1, CAST(N'2021-09-01' AS Date), CAST(N'2021-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (42, 9, 2021, 2, CAST(N'2021-09-16' AS Date), CAST(N'2021-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (43, 10, 2021, 1, CAST(N'2021-10-01' AS Date), CAST(N'2021-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (44, 10, 2021, 2, CAST(N'2021-10-16' AS Date), CAST(N'2021-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (45, 11, 2021, 1, CAST(N'2021-11-01' AS Date), CAST(N'2021-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (46, 11, 2021, 2, CAST(N'2021-11-16' AS Date), CAST(N'2021-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (47, 12, 2021, 1, CAST(N'2021-12-01' AS Date), CAST(N'2021-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (48, 12, 2021, 2, CAST(N'2021-12-16' AS Date), CAST(N'2021-12-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (49, 1, 2022, 1, CAST(N'2022-01-01' AS Date), CAST(N'2022-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (50, 1, 2022, 2, CAST(N'2022-01-16' AS Date), CAST(N'2022-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (51, 2, 2022, 1, CAST(N'2022-02-01' AS Date), CAST(N'2022-02-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (52, 2, 2022, 2, CAST(N'2022-02-16' AS Date), CAST(N'2022-02-28' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (53, 3, 2022, 1, CAST(N'2022-03-01' AS Date), CAST(N'2022-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (54, 3, 2022, 2, CAST(N'2022-03-16' AS Date), CAST(N'2022-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (55, 4, 2022, 1, CAST(N'2022-04-01' AS Date), CAST(N'2022-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (56, 4, 2022, 2, CAST(N'2022-04-16' AS Date), CAST(N'2022-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (57, 5, 2022, 1, CAST(N'2022-05-01' AS Date), CAST(N'2022-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (58, 5, 2022, 2, CAST(N'2022-05-16' AS Date), CAST(N'2022-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (59, 6, 2022, 1, CAST(N'2022-06-01' AS Date), CAST(N'2022-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (60, 6, 2022, 2, CAST(N'2022-06-16' AS Date), CAST(N'2022-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (61, 7, 2022, 1, CAST(N'2022-07-01' AS Date), CAST(N'2022-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (62, 7, 2022, 2, CAST(N'2022-07-16' AS Date), CAST(N'2022-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (63, 8, 2022, 1, CAST(N'2022-08-01' AS Date), CAST(N'2022-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (64, 8, 2022, 2, CAST(N'2022-08-16' AS Date), CAST(N'2022-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (65, 9, 2022, 1, CAST(N'2022-09-01' AS Date), CAST(N'2022-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (66, 9, 2022, 2, CAST(N'2022-09-16' AS Date), CAST(N'2022-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (67, 10, 2022, 1, CAST(N'2022-10-01' AS Date), CAST(N'2022-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (68, 10, 2022, 2, CAST(N'2022-10-16' AS Date), CAST(N'2022-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (69, 11, 2022, 1, CAST(N'2022-11-01' AS Date), CAST(N'2022-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (70, 11, 2022, 2, CAST(N'2022-11-16' AS Date), CAST(N'2022-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (71, 12, 2022, 1, CAST(N'2022-12-01' AS Date), CAST(N'2022-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (72, 12, 2022, 2, CAST(N'2022-12-16' AS Date), CAST(N'2022-12-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (73, 1, 2023, 1, CAST(N'2023-01-01' AS Date), CAST(N'2023-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (74, 1, 2023, 2, CAST(N'2023-01-16' AS Date), CAST(N'2023-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (75, 2, 2023, 1, CAST(N'2023-02-01' AS Date), CAST(N'2023-02-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (76, 2, 2023, 2, CAST(N'2023-02-16' AS Date), CAST(N'2023-02-28' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (77, 3, 2023, 1, CAST(N'2023-03-01' AS Date), CAST(N'2023-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (78, 3, 2023, 2, CAST(N'2023-03-16' AS Date), CAST(N'2023-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (79, 4, 2023, 1, CAST(N'2023-04-01' AS Date), CAST(N'2023-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (80, 4, 2023, 2, CAST(N'2023-04-16' AS Date), CAST(N'2023-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (81, 5, 2023, 1, CAST(N'2023-05-01' AS Date), CAST(N'2023-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (82, 5, 2023, 2, CAST(N'2023-05-16' AS Date), CAST(N'2023-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (83, 6, 2023, 1, CAST(N'2023-06-01' AS Date), CAST(N'2023-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (84, 6, 2023, 2, CAST(N'2023-06-16' AS Date), CAST(N'2023-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (85, 7, 2023, 1, CAST(N'2023-07-01' AS Date), CAST(N'2023-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (86, 7, 2023, 2, CAST(N'2023-07-16' AS Date), CAST(N'2023-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (87, 8, 2023, 1, CAST(N'2023-08-01' AS Date), CAST(N'2023-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (88, 8, 2023, 2, CAST(N'2023-08-16' AS Date), CAST(N'2023-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (89, 9, 2023, 1, CAST(N'2023-09-01' AS Date), CAST(N'2023-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (90, 9, 2023, 2, CAST(N'2023-09-16' AS Date), CAST(N'2023-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (91, 10, 2023, 1, CAST(N'2023-10-01' AS Date), CAST(N'2023-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (92, 10, 2023, 2, CAST(N'2023-10-16' AS Date), CAST(N'2023-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (93, 11, 2023, 1, CAST(N'2023-11-01' AS Date), CAST(N'2023-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (94, 11, 2023, 2, CAST(N'2023-11-16' AS Date), CAST(N'2023-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (95, 12, 2023, 1, CAST(N'2023-12-01' AS Date), CAST(N'2023-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (96, 12, 2023, 2, CAST(N'2023-12-16' AS Date), CAST(N'2023-12-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (97, 1, 2024, 1, CAST(N'2024-01-01' AS Date), CAST(N'2024-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (98, 1, 2024, 2, CAST(N'2024-01-16' AS Date), CAST(N'2024-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (99, 2, 2024, 1, CAST(N'2024-02-01' AS Date), CAST(N'2024-02-15' AS Date))
GO
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (100, 2, 2024, 2, CAST(N'2024-02-16' AS Date), CAST(N'2024-02-29' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (101, 3, 2024, 1, CAST(N'2024-03-01' AS Date), CAST(N'2024-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (102, 3, 2024, 2, CAST(N'2024-03-16' AS Date), CAST(N'2024-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (103, 4, 2024, 1, CAST(N'2024-04-01' AS Date), CAST(N'2024-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (104, 4, 2024, 2, CAST(N'2024-04-16' AS Date), CAST(N'2024-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (105, 5, 2024, 1, CAST(N'2024-05-01' AS Date), CAST(N'2024-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (106, 5, 2024, 2, CAST(N'2024-05-16' AS Date), CAST(N'2024-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (107, 6, 2024, 1, CAST(N'2024-06-01' AS Date), CAST(N'2024-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (108, 6, 2024, 2, CAST(N'2024-06-16' AS Date), CAST(N'2024-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (109, 7, 2024, 1, CAST(N'2024-07-01' AS Date), CAST(N'2024-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (110, 7, 2024, 2, CAST(N'2024-07-16' AS Date), CAST(N'2024-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (111, 8, 2024, 1, CAST(N'2024-08-01' AS Date), CAST(N'2024-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (112, 8, 2024, 2, CAST(N'2024-08-16' AS Date), CAST(N'2024-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (113, 9, 2024, 1, CAST(N'2024-09-01' AS Date), CAST(N'2024-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (114, 9, 2024, 2, CAST(N'2024-09-16' AS Date), CAST(N'2024-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (115, 10, 2024, 1, CAST(N'2024-10-01' AS Date), CAST(N'2024-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (116, 10, 2024, 2, CAST(N'2024-10-16' AS Date), CAST(N'2024-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (117, 11, 2024, 1, CAST(N'2024-11-01' AS Date), CAST(N'2024-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (118, 11, 2024, 2, CAST(N'2024-11-16' AS Date), CAST(N'2024-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (119, 12, 2024, 1, CAST(N'2024-12-01' AS Date), CAST(N'2024-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (120, 12, 2024, 2, CAST(N'2024-12-16' AS Date), CAST(N'2024-12-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (121, 1, 2025, 1, CAST(N'2025-01-01' AS Date), CAST(N'2025-01-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (122, 1, 2025, 2, CAST(N'2025-01-16' AS Date), CAST(N'2025-01-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (123, 2, 2025, 1, CAST(N'2025-02-01' AS Date), CAST(N'2025-02-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (124, 2, 2025, 2, CAST(N'2025-02-16' AS Date), CAST(N'2025-02-28' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (125, 3, 2025, 1, CAST(N'2025-03-01' AS Date), CAST(N'2025-03-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (126, 3, 2025, 2, CAST(N'2025-03-16' AS Date), CAST(N'2025-03-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (127, 4, 2025, 1, CAST(N'2025-04-01' AS Date), CAST(N'2025-04-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (128, 4, 2025, 2, CAST(N'2025-04-16' AS Date), CAST(N'2025-04-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (129, 5, 2025, 1, CAST(N'2025-05-01' AS Date), CAST(N'2025-05-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (130, 5, 2025, 2, CAST(N'2025-05-16' AS Date), CAST(N'2025-05-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (131, 6, 2025, 1, CAST(N'2025-06-01' AS Date), CAST(N'2025-06-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (132, 6, 2025, 2, CAST(N'2025-06-16' AS Date), CAST(N'2025-06-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (133, 7, 2025, 1, CAST(N'2025-07-01' AS Date), CAST(N'2025-07-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (134, 7, 2025, 2, CAST(N'2025-07-16' AS Date), CAST(N'2025-07-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (135, 8, 2025, 1, CAST(N'2025-08-01' AS Date), CAST(N'2025-08-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (136, 8, 2025, 2, CAST(N'2025-08-16' AS Date), CAST(N'2025-08-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (137, 9, 2025, 1, CAST(N'2025-09-01' AS Date), CAST(N'2025-09-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (138, 9, 2025, 2, CAST(N'2025-09-16' AS Date), CAST(N'2025-09-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (139, 10, 2025, 1, CAST(N'2025-10-01' AS Date), CAST(N'2025-10-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (140, 10, 2025, 2, CAST(N'2025-10-16' AS Date), CAST(N'2025-10-31' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (141, 11, 2025, 1, CAST(N'2025-11-01' AS Date), CAST(N'2025-11-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (142, 11, 2025, 2, CAST(N'2025-11-16' AS Date), CAST(N'2025-11-30' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (143, 12, 2025, 1, CAST(N'2025-12-01' AS Date), CAST(N'2025-12-15' AS Date))
INSERT [dbo].[TPayrollCutoffs] ([Id], [PayrollMonth], [PayrollYear], [PayrollPeriod], [PeriodStart], [PeriodEnd]) VALUES (144, 12, 2025, 2, CAST(N'2025-12-16' AS Date), CAST(N'2025-12-31' AS Date))
SET IDENTITY_INSERT [dbo].[TPayrollCutoffs] OFF
SET IDENTITY_INSERT [dbo].[TSemester] ON 

INSERT [dbo].[TSemester] ([SemesterId], [SemesterDesc], [SchoolYear], [StartDate], [EndDate], [IsActive]) VALUES (1, N'First Semester', N'2020-2021', CAST(N'2020-06-08' AS Date), CAST(N'2020-10-19' AS Date), 1)
INSERT [dbo].[TSemester] ([SemesterId], [SemesterDesc], [SchoolYear], [StartDate], [EndDate], [IsActive]) VALUES (2, N'Second Semester', N'2020-2021', CAST(N'2020-11-03' AS Date), CAST(N'2021-03-05' AS Date), 1)
INSERT [dbo].[TSemester] ([SemesterId], [SemesterDesc], [SchoolYear], [StartDate], [EndDate], [IsActive]) VALUES (3, N'Second Semester', N'2019-2020', CAST(N'2019-11-04' AS Date), CAST(N'2020-03-23' AS Date), 1)
SET IDENTITY_INSERT [dbo].[TSemester] OFF
SET IDENTITY_INSERT [dbo].[TUsers] ON 

INSERT [dbo].[TUsers] ([UserId], [UserName], [PasswordHash], [PasswordSalt], [LastName], [FirstName], [MiddleName]) VALUES (1, N'admin', 0x1E7F146B9BFD37CD5F16B25F1CDDD7678F01E7933055EFF8A487904C9CCC50A63AEA373DC05995AF9DA9A6DD1A024824DA8005A15CD29C01C698D1CE8D1481FD, 0xEEF51D9C8F613C6161BE31AC5F4B21EF3CB5FE41B5026B5E2234F9E69D952B4CC99302372DD1CBB3A312C0422536802D58E27312674A0EED84E1C9E60E721C75DD0432A644476526BA09112F91A674F45EDB7EA4000749A10D3A851A6E146C90FC8BE9ED6A9CBC57AF931A3756C2751F5CA58B6227D72708A0234BA7A2BC096A, N'Sebastian', N'John ', N'S')
INSERT [dbo].[TUsers] ([UserId], [UserName], [PasswordHash], [PasswordSalt], [LastName], [FirstName], [MiddleName]) VALUES (2, N'cmtans', 0x045CDDAF32FF7D13AD1A84CC2069D5A15F0762D3FFAEFCC92058C69F18191443E882BC9109749E833D773B9F0B3485E9C2C60E4FE3F9710D9E3EF7731F2A1FA0, 0xBC5CF70609113894BC730A915A8DA855A9549606E8245CD9E82AEC1020D0FB60C3C7F474C04BD3002EFF338CF14EC84D487BB612B5C32A3597656838B603F6D66454E1FC0AA18080B01A8377E71C3BDF531B789E4C22E70E6F2B2EE60F25CAC25E7A7D64C8A54BD1F8B7FD06C32CED18018C11B2D7C26FC90225719AB02A1A4F, N'Tan', N'Cindy', N'M')
SET IDENTITY_INSERT [dbo].[TUsers] OFF
SET IDENTITY_INSERT [dbo].[TWorkload] ON 

INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1, 1, 1, N'Monday', CAST(N'07:30:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (2, 1, 1, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (3, 1, 1, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (4, 1, 1, N'Thursday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (5, 1, 1, N'Friday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (6, 1, 1, N'Saturday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (7, 1, 1, N'Sunday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (9, 4, 1, N'Monday', CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (10, 4, 1, N'Tuesday', CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (11, 4, 1, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (12, 4, 1, N'Thursday', NULL, NULL, CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (13, 5, 1, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'11:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1013, 4, 1, N'Friday', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1014, 4, 1, N'Saturday', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1015, 2, 1, N'Monday', NULL, NULL, NULL, NULL, CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1016, 2, 1, N'Tuesday', CAST(N'07:30:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1017, 1, 3, N'Monday', CAST(N'07:30:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1018, 1, 3, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1019, 1, 3, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1020, 1, 3, N'Thursday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1021, 1, 3, N'Friday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1022, 1, 3, N'Saturday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1023, 1, 3, N'Sunday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'18:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1024, 4, 3, N'Monday', CAST(N'09:00:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1025, 4, 3, N'Tuesday', CAST(N'10:00:00' AS Time), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1026, 4, 3, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'12:00:00' AS Time), NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1027, 4, 3, N'Thursday', NULL, NULL, CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1028, 5, 3, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'11:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'19:00:00' AS Time), NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1029, 4, 3, N'Friday', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1030, 4, 3, N'Saturday', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1031, 2, 3, N'Monday', NULL, NULL, NULL, NULL, CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
INSERT [dbo].[TWorkload] ([WorkloadId], [EmployeeId], [SemesterId], [DayOfWork], [TimeInAM], [TimeOutAM], [TimeInPM], [TimeOutPM], [TimeInEvening], [TimeOutEvening]) VALUES (1032, 2, 3, N'Tuesday', CAST(N'07:30:00' AS Time), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(N'17:00:00' AS Time), CAST(N'17:15:00' AS Time), CAST(N'22:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[TWorkload] OFF
ALTER TABLE [dbo].[TEmployeeLeaves] ADD  CONSTRAINT [DF_TEmployeeLeaves_IsWithPay]  DEFAULT ((0)) FOR [IsWithPay]
GO
ALTER TABLE [dbo].[TSemester] ADD  CONSTRAINT [DF_TSemester_SemStatus]  DEFAULT ((0)) FOR [IsActive]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Address_Insert]
					@iStrBarangay varchar(50),
					@iStrMunicipal_City varchar(50),
					@iStrProvince varchar(50),
					@iStrCountry varchar(50),
					@iStrZipCode varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int);

	If not exists(Select 1 From dbo.TAddress where Barangay=@iStrBarangay and Municipal_City=@iStrMunicipal_City and Province=@iStrProvince)
		begin
			Insert Into dbo.TAddress(Barangay, Municipal_City, Province, Country, ZipCode)  output inserted.AddressId into @tb
				Values(@iStrBarangay, @iStrMunicipal_City, @iStrProvince, @iStrCountry, @iStrZipCode);

			Select Top 1 Id From @tb;
		end
	else Select -1;

	SET NOCOUNT OFF;

END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_Address_Select] @iStrSearch varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select top 100 AddressId, Barangay, Municipal_City, Province, Country, ZipCode From dbo.TAddress where 
		Barangay LIKE @iStrSearch+'%' OR 
		Municipal_City LIKE @iStrSearch+'%' OR
		Province LIKE @iStrSearch+'%' OR
		Country LIKE @iStrSearch+'%' OR
		ZipCode LIKE @iStrSearch+'%';

	SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Address_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_Address_Update] @iIntAddressId int, @iStrBarangay varchar(50),
					@iStrMunicipal_City varchar(50),
					@iStrProvince varchar(50),
					@iStrCountry varchar(50),
					@iStrZipCode varchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TAddress set Barangay=@iStrBarangay, Municipal_City=@iStrMunicipal_City,Province=@iStrProvince, Country=@iStrCountry, ZipCode=@iStrZipCode
	where AddressId=@iIntAddressId;

	Select @iIntAddressId as Result;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Department_Insert] @iStrDeptName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int);

	If not exists(Select 1 From dbo.TDepartments where DepartmentName=@iStrDeptName)
		begin
			Insert Into dbo.TDepartments(DepartmentName) output inserted.DepartmentId into @tb Values(@iStrDeptName); 

			Select Top 1 Id From @tb;
		end
	else Select -1;	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_Department_Select]	@iStrSearch varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select DepartmentId, DepartmentName From dbo.TDepartments where DepartmentName LIKE @iStrSearch+'%';

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_SelectForDTR]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Department_SelectForDTR]
AS
BEGIN
	SET NOCOUNT ON;

	Select 0 as DepartmentId,'' as DepartmentName Union all
	Select DepartmentId, DepartmentName From dbo.TDepartments;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Department_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_Department_Update] @iIntDeptId int, @iStrDeptName varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TDepartments set DepartmentName=@iStrDeptName where DepartmentId=@iIntDeptId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_DTR_GenerateLog]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_DTR_GenerateLog]
							@iDtFrom date,
							@iDtTo date,
							@iStrDept varchar(50)=''

AS
BEGIN
	SET NOCOUNT ON;

	Select 
		a.LogId,		
		a.CurrentDate,
		FORMAT(a.CurrentDate, 'dddd') Day_Name,
		dbo.fn_GetEmployeeDepartment(a.EmployeeId) Department,
		a.EmployeeId,
		dbo.fn_GetEmployeeFullName(a.EmployeeId) as EmployeeName,		
		dbo.fn_FormatTime(a.TimeIn_AM) as Morning_TimeIn,
		a.TimeIn_AM_MinsLate as Morning_LateInMins,
		dbo.fn_FormatTime(a.TimeOut_AM) as Morning_TimeOut,
		dbo.fn_FormatTime(a.TimeIn_PM) as Afternoon_TimeIn ,
		a.TimeIn_PM_MinsLate as Afternoon_LateInMins,
		dbo.fn_FormatTime(a.TimeOut_PM) as Afternoon_TimeOut,
		dbo.fn_FormatTime(a.TimeIn_Evening) as Evening_TimeIn,
		a.TimeIn_Evening_MinsLate as Evening_LateInMins,
		dbo.fn_FormatTime(a.TimeOut_Evening) as Evening_TimeOut
	From dbo.TDailyTimeRecord as a
	where a.CurrentDate >= @iDtFrom and a.CurrentDate <  DATEADD(DAY, 1, @iDtTo)
	and (dbo.fn_GetEmployeeDepartment(a.EmployeeId)=@iStrDept or @iStrDept='');

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_DTR_Log]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_DTR_Log]
					@iIntEmployeeId int,
					@iDtTimelog datetime,
					@iStrEvent varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	Declare @oResult as int=0;
	Declare @semesterId as int;
	Declare @logDate as date = Cast(@iDtTimelog as date);
	Declare @logTime as time = Cast(@iDtTimelog as time);
	Declare @minsLate as decimal(18,2);
	Declare @minsUnderTime as decimal(18,2);
	Declare @dayName as varchar(15) = FORMAT(@iDtTimelog, 'dddd');

	If Not Exists(Select 1 From dbo.TSemester where @logDate>=StartDate and @logDate<=EndDate and IsActive=1)
		Begin
			Set @oResult = -2;
		End
	Else
		Begin
			Select @semesterId=SemesterId From dbo.TSemester where @logDate>=StartDate and @logDate<=EndDate and IsActive=1;
			
			If Exists(Select 1 From TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId)
				Begin
					If @iStrEvent='IN_AM'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeInAM IS NOT NULL)
								Begin	
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeIn_AM IS NOT NULL)
										Begin
											Select @minsLate=DATEDIFF(SECOND,TimeInAM,@logTime) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId,CurrentDate,TimeIn_AM,TimeIn_AM_MinsLate)												
												Select @iIntEmployeeId,@logDate,@logTime,(@minsLate*1.0)/60;
											Else 
												Update dbo.TDailyTimeRecord Set TimeIn_AM=@logTime, TimeIn_AM_MinsLate=(@minsLate*1.0)/60 where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	
											Set @oResult=1;
										End
									Else
										Set @oResult = -4;
								End
							Else 
								Set @oResult = -3;							
						End
					Else If @iStrEvent='OUT_AM'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeOutAM IS NOT NULL)
								Begin
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeOut_AM IS NOT NULL)
										Begin
											Select @minsUnderTime=DATEDIFF(SECOND, @logTime,TimeOutAM) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId, CurrentDate, TimeOut_AM, UnderTime_AM)
													Values(@iIntEmployeeId,@logDate,@logTime, (@minsUnderTime*1.0)/60);
											Else 
												Update dbo.TDailyTimeRecord Set TimeOut_AM=@logTime, UnderTime_AM=(@minsUnderTime*1.0)/60 where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	

											Set @oResult = 2;
										End												
									Else 
										Set @oResult = -6;		
								End
							Else 
								Set @oResult = -5;		
						End
					Else If @iStrEvent='IN_PM'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeInPM IS NOT NULL)
								Begin
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeIn_PM IS NOT NULL)
										Begin
											Select @minsLate=DATEDIFF(SECOND,TimeInPM,@logTime) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId, CurrentDate, TimeIn_PM, TimeIn_PM_MinsLate)
													Values(@iIntEmployeeId,@logDate,@logTime, (@minsLate*1.0)/60);
											Else 
												Update dbo.TDailyTimeRecord Set TimeIn_PM=@logTime, TimeIn_PM_MinsLate=(@minsLate*1.0)/60 where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	

											Set @oResult = 3;
										End												
									Else 
										Set @oResult = -8;		
								End
							Else 
								Set @oResult = -7;		
						End
					Else If @iStrEvent='OUT_PM'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeOutPM IS NOT NULL)
								Begin
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeOut_PM IS NOT NULL)
										Begin
											--Select @minsUnderTime=DATEDIFF(SECOND, @logTime,TimeOutPM) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId, CurrentDate, TimeOut_PM)
													Values(@iIntEmployeeId,@logDate,@logTime);
											Else 
												Update dbo.TDailyTimeRecord Set TimeOut_PM=@logTime where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	

											Set @oResult = 4;
										End												
									Else 
										Set @oResult = -10;		
								End
							Else 
								Set @oResult = -9;		
						End
					Else If @iStrEvent='IN_EVE'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeInEvening IS NOT NULL)
								Begin
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeIn_Evening IS NOT NULL)
										Begin
											Select @minsLate=DATEDIFF(SECOND,TimeInEvening,@logTime) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId, CurrentDate, TimeIn_Evening, TimeIn_Evening_MinsLate)
													Values(@iIntEmployeeId,@logDate,@logTime, (@minsLate*1.0)/60);
											Else 
												Update dbo.TDailyTimeRecord Set TimeIn_Evening=@logTime, TimeIn_Evening_MinsLate=(@minsLate*1.0)/60 where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	

											Set @oResult = 5;
										End												
									Else 
										Set @oResult = -12;		
								End
							Else 
								Set @oResult = -11;		
						End
					Else If @iStrEvent='OUT_EVE'
						Begin
							If Exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName and TimeOutEvening IS NOT NULL)
								Begin
									If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate and TimeOut_Evening IS NOT NULL)
										Begin
											--Select @minsUnderTime=DATEDIFF(SECOND, @logTime,TimeOutPM) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@semesterId and DayOfWork=@dayName
											If Not Exists(Select 1 From dbo.TDailyTimeRecord where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate)
												Insert Into dbo.TDailyTimeRecord(EmployeeId, CurrentDate, TimeOut_Evening)
													Values(@iIntEmployeeId,@logDate,@logTime);
											Else 
												Update dbo.TDailyTimeRecord Set TimeOut_Evening=@logTime where EmployeeId=@iIntEmployeeId and CurrentDate=@logDate;	

											Set @oResult = 6;
										End												
									Else 
										Set @oResult = -14;		
								End
							Else 
								Set @oResult = -13;		
						End
				End
			Else
				Begin
					Set @oResult = -1;					
				End
		End
		
	/*
		1, 'Success Time IN_AM'
		2, 'Success Time OUT_AM'
		3, 'Success Time IN_PM'
		4, 'Success Time OUT_PM'
		4, 'Success Time IN_EVE'
		5, 'Success Time OUT_EVE'
		-1,'Employee no workload yet.'
		-2,'Semester not set-up'
		-3,'Employee no am login schedule for that day'
		-4,'Employee already am logged in'
		-5,'Employee no am logout schedule for that day'
		-6,'Employee already am logged out'
		-7,'Employee no pm login schedule for that day'
		-8,'Employee already pm logged in'
		-9,'Employee no pm logout schedule for that day'
		-10,'Employee already pm logged out'
		-11,'Employee no evening login schedule for that day'
		-12,'Employee already evening logged in'
		-13,'Employee no evening logout schedule for that day'
		-14,'Employee already evening logged out'
	*/
	Select @oResult as Result; 
	
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Employee_BasicInfo]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Employee_BasicInfo] @iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;

	Select a.EmployeeId, dbo.fn_GetEmployeeFullName(a.EmployeeId) EmployeeFullName, dbo.fn_GetEmployeeDepartment(a.EmployeeId) DepartmentName, PicName, b.EmploymentType 
	From dbo.TEmployeeBasicInfo as a
	Inner Join dbo.TEmployeeEmpInfo as b on a.EmployeeId=b.EmployeeId
	where a.EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Employee_SelectAll]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Employee_SelectAll] @iStrSearch varchar(75)
AS
BEGIN
	SET NOCOUNT ON;

	Select 
		a.EmployeeId, 
		RIGHT('0000'+CAST(a.EmployeeId AS VARCHAR(4)),4) as EmployeeIDNumber,
		Suffix,
		dbo.fn_GetEmployeeFullName(a.EmployeeId) as EmployeeFullName,
		b.Designation,
		dbo.fn_GetContactNumbers(c.ContactNum1, c.ContactNum2) as ContactNumbers,
		d.DepartmentName as Department
	From dbo.TEmployeeBasicInfo as a
	Left Join dbo.TEmployeeEmpInfo as b on a.EmployeeId=b.EmployeeId
	Left Join dbo.TEmployeeContactInfo as c on c.EmployeeId=a.EmployeeId
	Inner Join dbo.TDepartments as d on b.DepartmentId=d.DepartmentId
	where a.LastName Like @iStrSearch+'%' or
		a.FirstName Like @iStrSearch+'%' or
		a.MiddleName Like @iStrSearch+'%' or
		d.DepartmentName Like @iStrSearch+'%' or
		b.Designation Like @iStrSearch+'%' or
		RIGHT('0000'+CAST(a.EmployeeId AS VARCHAR(4)),4)  Like @iStrSearch+'%';
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_GetById]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeBasicInfo_GetById] 
					@iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;

	Select 
		a.EmployeeId,
		LastName,
		FirstName,
		MiddleName,
		Suffix,
		BirthDate,
		PlaceOfBirth,
		Citizenship,
		Height,
		Weight,
		Religion,
		ResidentialAddress1,
		ResidentialAddress2,
		CurrentAddress1,
		CurrentAddress2,
		Gender,
		CivilStatus,
		PicName
	From dbo.TEmployeeBasicInfo as a
	where a.EmployeeId=@iIntEmployeeId;

    SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeBasicInfo_Insert] 
					@iStrLastName as varchar(50)='',
					@iStrFirstName as varchar(50)='',
					@iStrMiddleName as varchar(50)='',
					@iStrSuffix as varchar(10)='',
					@iStrBirthDate as varchar(10)='',
					@iStrPlaceOfBirth as varchar(50)='',
					@iStrCitizenship as varchar(50)='',
					@iStrHeight as varchar(50)='',
					@iStrWeight as varchar(50)='',
					@iStrReligion as varchar(50)='',
					@iStrResidentialAddress1 as varchar(150)='',
					@iStrResidentialAddress2 as varchar(350)='',
					@iStrCurrentAddress1 as varchar(150)='',
					@iStrCurrentAddress2 as varchar(350)='',
					@iStrGender	varchar(6),
					@iStrPasswordHash varbinary(250)=null,
					@iStrPasswordSalt varbinary(250)=null,
					@iStrCivilStatus as varchar(10)='',
					@iStrPicName as varchar(300)=''

AS
BEGIN
	SET NOCOUNT ON;

	Declare @oResult as Int = 0;
	Declare @tb as table(id int);

	If Not Exists(Select 1 From dbo.TEmployeeBasicInfo where LastName=@iStrLastName and FirstName=@iStrFirstName and MiddleName=@iStrMiddleName and Suffix=@iStrSuffix)
		Begin
			Insert Into dbo.TEmployeeBasicInfo(LastName
			   ,FirstName
			   ,MiddleName
			   ,Suffix
			   ,BirthDate
			   ,PlaceOfBirth
			   ,Citizenship
			   ,Height
			   ,Weight
			   ,Religion
			   ,ResidentialAddress1
			   ,ResidentialAddress2
			   ,CurrentAddress1
			   ,CurrentAddress2
			   ,Gender
			   ,CivilStatus
			   ,PicName) output inserted.EmployeeId into @tb
			Values(@iStrLastName,
					@iStrFirstName,
					@iStrMiddleName,
					@iStrSuffix,
					@iStrBirthDate,
					@iStrPlaceOfBirth,
					@iStrCitizenship,
					@iStrHeight,
					@iStrWeight,
					@iStrReligion,
					@iStrResidentialAddress1,
					@iStrResidentialAddress2,
					@iStrCurrentAddress1,
					@iStrCurrentAddress2,
					@iStrGender,
					@iStrCivilStatus,
					@iStrPicName)

			Select Top 1 @oResult=Id From @tb;
		End
	Else Set @oResult = -1;

	Select @oResult Result;

    SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeBasicInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeBasicInfo_Update] 
					@iIntEmployeeId as int,
					@iStrLastName as varchar(50)='',
					@iStrFirstName as varchar(50)='',
					@iStrMiddleName as varchar(50)='',
					@iStrSuffix as varchar(10)='',
					@iStrBirthDate as varchar(10)='',
					@iStrPlaceOfBirth as varchar(50)='',
					@iStrCitizenship as varchar(50)='',
					@iStrHeight as varchar(50)='',
					@iStrWeight as varchar(50)='',
					@iStrReligion as varchar(50)='',
					@iStrResidentialAddress1 as varchar(150)='',
					@iStrResidentialAddress2 as varchar(350)='',
					@iStrCurrentAddress1 as varchar(150)='',
					@iStrCurrentAddress2 as varchar(350)='',
					@iStrGender	varchar(6),
					@iStrCivilStatus as varchar(10)='',
					@iStrPicName as varchar(300)=''
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TEmployeeBasicInfo
		SET 
			LastName=@iStrLastName,
			FirstName=@iStrFirstName,
			MiddleName=@iStrMiddleName,
			Suffix=@iStrSuffix,
			BirthDate=@iStrBirthDate,
			PlaceOfBirth=@iStrPlaceOfBirth,
			Citizenship=@iStrCitizenship,
			Height=@iStrHeight,
			Weight=@iStrWeight,
			Religion=@iStrReligion,
			ResidentialAddress1=@iStrResidentialAddress1,
			ResidentialAddress2=@iStrResidentialAddress2,
			CurrentAddress1=@iStrCurrentAddress1,
			CurrentAddress2=@iStrCurrentAddress2,
			Gender=@iStrGender,
			CivilStatus=@iStrCivilStatus,
			PicName = @iStrPicName
		Where EmployeeId = @iIntEmployeeId;

		
    SET NOCOUNT ON;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_GetByEmployeeId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_EmployeeContactInfo_GetByEmployeeId] 
							@iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;

	Select 
		EmployeeId,
		SpouseName,
		SpouseOccupation,
		SpouseBirthDate,
		FatherName,
		FatherOccupation,
		FatherBirthDate,
		MotherName,
		MotherOccupation,
		MotherBirthDate,
		ParentAddress1,
		ParentAddress2,
		ContactNum1,
		ContactNum2,
		EmailAddress,
		ContactPersonName,
		ContactPersonNumber,
		ContactPersonAddress1,
		ContactPersonAddress2		
	From dbo.TEmployeeContactInfo 
	Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_EmployeeContactInfo_Insert] 
							@iIntEmployeeId as int,
							@iStrSpouseName as varchar(50)='',
							@iStrSpouseOccupation as varchar(50)='',
							@iDtSpouseBirthDate as date,
							@iStrFatherName as varchar(50)='',
							@iStrFatherOccupation as varchar(50)='',
							@iDtFatherBirthDate as date,
							@iStrMotherName as varchar(50)='',
							@iStrMotherOccupation as varchar(50)='',
							@iDtMotherBirthDate as date,
							@iStrParentAddress1 as varchar(150)='',
							@iStrParentAddress2 as varchar(350)='',
							@iStrContactNum1 as varchar(25)='',
							@iStrContactNum2 as varchar(15)='',
							@iStrEmailAddress as varchar(100)='',
							@iStrContactPersonName as varchar(75)='',
							@iStrContactPersonNumber as varchar(15)='',
							@iStrContactPersonAddress1 as varchar(150)='',
							@iStrContactPersonAddress2 as varchar(350)=''
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TEmployeeContactInfo
           (EmployeeId
           ,SpouseName
           ,SpouseOccupation
           ,SpouseBirthDate
           ,FatherName
           ,FatherOccupation
           ,FatherBirthDate
           ,MotherName
           ,MotherOccupation
           ,MotherBirthDate
           ,ParentAddress1
           ,ParentAddress2
           ,ContactNum1
           ,ContactNum2
           ,EmailAddress
           ,ContactPersonName
           ,ContactPersonNumber
           ,ContactPersonAddress1
           ,ContactPersonAddress2)
	Values(
		@iIntEmployeeId,
		@iStrSpouseName,
		@iStrSpouseOccupation,
		@iDtSpouseBirthDate,
		@iStrFatherName,
		@iStrFatherOccupation,
		@iDtFatherBirthDate,
		@iStrMotherName,
		@iStrMotherOccupation,
		@iDtMotherBirthDate,
		@iStrParentAddress1,
		@iStrParentAddress2,
		@iStrContactNum1,
		@iStrContactNum2,
		@iStrEmailAddress,
		@iStrContactPersonName,
		@iStrContactPersonNumber,
		@iStrContactPersonAddress1,
		@iStrContactPersonAddress2
	);


    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeContactInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_EmployeeContactInfo_Update] 
							@iIntEmployeeId as int,
							@iStrSpouseName as varchar(50)='',
							@iStrSpouseOccupation as varchar(50)='',
							@iDtSpouseBirthDate as date,
							@iStrFatherName as varchar(50)='',
							@iStrFatherOccupation as varchar(50)='',
							@iDtFatherBirthDate as date,
							@iStrMotherName as varchar(50)='',
							@iStrMotherOccupation as varchar(50)='',
							@iDtMotherBirthDate as date,
							@iStrParentAddress1 as varchar(150)='',
							@iStrParentAddress2 as varchar(350)='',
							@iStrContactNum1 as varchar(25)='',
							@iStrContactNum2 as varchar(15)='',
							@iStrEmailAddress as varchar(100)='',
							@iStrContactPersonName as varchar(75)='',
							@iStrContactPersonNumber as varchar(15)='',
							@iStrContactPersonAddress1 as varchar(150)='',
							@iStrContactPersonAddress2 as varchar(350)=''
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TEmployeeContactInfo
		Set
			SpouseName=@iStrSpouseName,
			SpouseOccupation=@iStrSpouseOccupation,
			SpouseBirthDate=@iDtSpouseBirthDate,
			FatherName=@iStrFatherName,
			FatherOccupation=@iStrFatherOccupation,
			FatherBirthDate=@iDtFatherBirthDate,
			MotherName=@iStrMotherName,
			MotherOccupation=@iStrMotherOccupation,
			MotherBirthDate=@iDtMotherBirthDate,
			ParentAddress1=@iStrParentAddress1,
			ParentAddress2=@iStrParentAddress2,
			ContactNum1=@iStrContactNum1,
			ContactNum2=@iStrContactNum2,
			EmailAddress=@iStrEmailAddress,
			ContactPersonName=@iStrContactPersonName,
			ContactPersonNumber=@iStrContactPersonNumber,
			ContactPersonAddress1=@iStrContactPersonAddress1,
			ContactPersonAddress2=@iStrContactPersonAddress2
		Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_GetByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeEducation_GetByEmpId] 
							@iIntEmployeeId as int
							
AS
BEGIN
	SET NOCOUNT ON;

	Select 
		EmployeeId,
		Elementary,
		ElemDateGraduated,
		HighSchool,
		HighSchoolDateGraduated,
		Vocational,
		VocationalCourse,
		VocationalDateGraduated,
		College,
		CollegeCourse,
		CollegeDateGraduated,
		HighestEducAttainment,
		EducationalBackgroundRemarks
	From dbo.TEmployeeEducation
	Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_EmployeeEducation_Insert] 
							@iIntEmployeeId as int,
							@iStrElementary as varchar(150)='',
							@iDtElemDateGraduated as date,
							@iStrHighSchool as varchar(150)='',
							@iDtHighSchoolDateGraduated as date,
							@iStrVocational as varchar(150)='',
							@iStrVocationalCourse as varchar(150)='',
							@iDtVocationalDateGraduated as date,
							@iStrCollege as varchar(150)='',
							@iStrCollegeCourse as varchar(150)='',
							@iDtCollegeDateGraduated as date,
							@iStrHighestEducAttainment varchar(35)='',
							@iStrEducationalBackgroundRemarks as varchar(max)=''
							
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TEmployeeEducation
           (EmployeeId
           ,Elementary
           ,ElemDateGraduated
           ,HighSchool
           ,HighSchoolDateGraduated
           ,Vocational
           ,VocationalCourse
           ,VocationalDateGraduated
           ,College
           ,CollegeCourse
           ,CollegeDateGraduated
		   ,HighestEducAttainment
           ,EducationalBackgroundRemarks)
	Values(
		@iIntEmployeeId,
		@iStrElementary,
		@iDtElemDateGraduated,
		@iStrHighSchool,
		@iDtHighSchoolDateGraduated,
		@iStrVocational,
		@iStrVocationalCourse,
		@iDtVocationalDateGraduated,
		@iStrCollege,
		@iStrCollegeCourse,
		@iDtCollegeDateGraduated,
		@iStrHighestEducAttainment,
		@iStrEducationalBackgroundRemarks
	);


    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEducation_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_EmployeeEducation_Update] 
							@iIntEmployeeId as int,
							@iStrElementary as varchar(150)='',
							@iDtElemDateGraduated as date,
							@iStrHighSchool as varchar(150)='',
							@iDtHighSchoolDateGraduated as date,
							@iStrVocational as varchar(150)='',
							@iStrVocationalCourse as varchar(150)='',
							@iDtVocationalDateGraduated as date,
							@iStrCollege as varchar(150)='',
							@iStrCollegeCourse as varchar(150)='',
							@iDtCollegeDateGraduated as date,
							@iStrHighestEducAttainment varchar(35)='',
							@iStrEducationalBackgroundRemarks as varchar(max)=''
							
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TEmployeeEducation
		Set
			Elementary=@iStrElementary,
			ElemDateGraduated=@iDtElemDateGraduated,
			HighSchool=@iStrHighSchool,
			HighSchoolDateGraduated=@iDtHighSchoolDateGraduated,
			Vocational=@iStrVocational,
			VocationalCourse=@iStrVocationalCourse,
			VocationalDateGraduated=@iDtVocationalDateGraduated,
			College=@iStrCollege,
			CollegeCourse=@iStrCollegeCourse,
			CollegeDateGraduated=@iDtCollegeDateGraduated,
			HighestEducAttainment=@iStrHighestEducAttainment,
			EducationalBackgroundRemarks=@iStrEducationalBackgroundRemarks
	   Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_GetByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeEmpInfo_GetByEmpId] 
							@iIntEmployeeId as int
AS
BEGIN
	SET NOCOUNT ON;

	Select 
		EmployeeId,
		Designation,
		DepartmentId,
		EmploymentType,
		BasicPay,
		DateHired,
		TINNo,
		SSSNo,
		PhilHealth,
		PagIbigNo,
		CharRefFullName1,
		CharRefOccupation1,
		CharRefContactNum1,
		CharRefFullName2,
		CharRefOccupation2,
		CharRefContactNum2,
		CharRefFullName3,
		CharRefOccupation3,
		CharRefContactNum3,
		EmpStatus,
		BasicPayOption as BasicRateOption
	From dbo.TEmployeeEmpInfo
    Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeEmpInfo_Insert] 
							@iIntEmployeeId as int,
							@iStrDesignation as varchar(75)='',
							@iIntDepartment as int,
							@iStrEmploymentType as varchar(50)='',
							@iDecBasicPay as decimal(18,2),
							@iDtDateHired as date,
							@iStrTINNo as varchar(50)='',
							@iStrSSSNo as varchar(50)='',
							@iStrPhilHealth as varchar(50)='',
							@iStrPagIbigNo as varchar(50)='',
							@iStrCharRefFullName1 as varchar(75)='',
							@iStrCharRefOccupation1 as varchar(50)='',
							@iStrCharRefContactNum1 as varchar(15)='',
							@iStrCharRefFullName2 as varchar(75)='',
							@iStrCharRefOccupation2 as varchar(50)='',
							@iStrCharRefContactNum2 as varchar(15)='',
							@iStrCharRefFullName3 as varchar(75)='',
							@iStrCharRefOccupation3 as varchar(50)='',
							@iStrCharRefContactNum3 as varchar(15)='',
							@iStrEmpStatus as varchar(10)=NULL,
							@iStrBasicPayOption as varchar(10)
							
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.TEmployeeEmpInfo
           (EmployeeId
           ,Designation
           ,DepartmentId
           ,EmploymentType
           ,BasicPay
           ,DateHired
           ,TINNo
           ,SSSNo
           ,PhilHealth
           ,PagIbigNo
           ,CharRefFullName1
           ,CharRefOccupation1
           ,CharRefContactNum1
           ,CharRefFullName2
           ,CharRefOccupation2
           ,CharRefContactNum2
           ,CharRefFullName3
           ,CharRefOccupation3
           ,CharRefContactNum3
		   ,EmpStatus
		   ,BasicPayOption)
	Values(
		@iIntEmployeeId,
		@iStrDesignation,
		@iIntDepartment,							
		@iStrEmploymentType,
		@iDecBasicPay,
		@iDtDateHired,
		@iStrTINNo,
		@iStrSSSNo,
		@iStrPhilHealth,
		@iStrPagIbigNo,
		@iStrCharRefFullName1,
		@iStrCharRefOccupation1,
		@iStrCharRefContactNum1,
		@iStrCharRefFullName2,
		@iStrCharRefOccupation2,
		@iStrCharRefContactNum2,
		@iStrCharRefFullName3,
		@iStrCharRefOccupation3,
		@iStrCharRefContactNum3,
		@iStrEmpStatus,
		@iStrBasicPayOption
	);


    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_EmployeeEmpInfo_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_EmployeeEmpInfo_Update] 
							@iIntEmployeeId as int,
							@iStrDesignation as varchar(75)='',
							@iIntDepartment as int,
							@iStrEmploymentType as varchar(50)='',
							@iDecBasicPay as decimal(18,2),
							@iDtDateHired as date,
							@iStrTINNo as varchar(50)='',
							@iStrSSSNo as varchar(50)='',
							@iStrPhilHealth as varchar(50)='',
							@iStrPagIbigNo as varchar(50)='',
							@iStrCharRefFullName1 as varchar(75)='',
							@iStrCharRefOccupation1 as varchar(50)='',
							@iStrCharRefContactNum1 as varchar(15)='',
							@iStrCharRefFullName2 as varchar(75)='',
							@iStrCharRefOccupation2 as varchar(50)='',
							@iStrCharRefContactNum2 as varchar(15)='',
							@iStrCharRefFullName3 as varchar(75)='',
							@iStrCharRefOccupation3 as varchar(50)='',
							@iStrCharRefContactNum3 as varchar(15)='',
							@iStrEmpStatus as varchar(10)=NULL,
							@iStrBasicPayOption as varchar(10)
							
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TEmployeeEmpInfo
		Set			
			Designation=@iStrDesignation,
			DepartmentId=@iIntDepartment,
			EmploymentType=@iStrEmploymentType,
			BasicPay=@iDecBasicPay,
			DateHired=@iDtDateHired,
			TINNo=@iStrTINNo,
			SSSNo=@iStrSSSNo,
			PhilHealth=@iStrPhilHealth,
			PagIbigNo=@iStrPagIbigNo,
			CharRefFullName1=@iStrCharRefFullName1,
			CharRefOccupation1=@iStrCharRefOccupation1,
			CharRefContactNum1=@iStrCharRefContactNum1,
			CharRefFullName2=@iStrCharRefFullName2,
			CharRefOccupation2=@iStrCharRefOccupation2,
			CharRefContactNum2=@iStrCharRefContactNum2,
			CharRefFullName3=@iStrCharRefFullName3,
			CharRefOccupation3=@iStrCharRefOccupation3,
			CharRefContactNum3=@iStrCharRefContactNum3,
			EmpStatus=@istrEmpStatus,
			BasicPayOption=@iStrBasicPayOption
		Where EmployeeId=@iIntEmployeeId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_ByEmpId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_FingerPrint_ByEmpId] @iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;
	
	Select FPId, EmployeeId, Finger, Mask From dbo.TFingerPrint where EmployeeId=@iIntEmployeeId;	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_Delete]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_FingerPrint_Delete] @iIntEmployeeId as int,
											@iTIntFinger as tinyint,
											@iIntMask as int
AS
BEGIN
	SET NOCOUNT ON;

	Delete From dbo.TFingerPrint Where EmployeeId=@iIntEmployeeId and Finger=@iTIntFinger and Mask=@iIntMask;	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_FingerPrint_Insert] @iIntEmployeeId as int,
											@iTIntFinger as tinyint,
											@iIntMask as int
AS
BEGIN
	SET NOCOUNT ON;

	Delete From dbo.TFingerPrint where EmployeeId=@iIntEmployeeId and Finger=@iTIntFinger and Mask=@iIntMask;

	Insert Into dbo.TFingerPrint(EmployeeId, Finger, Mask) Values(@iIntEmployeeId, @iTIntFinger, @iIntMask);	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_FingerPrint_SelectAll]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_FingerPrint_SelectAll]
AS
BEGIN
	SET NOCOUNT ON;
	
	Select FPId, EmployeeId, Finger, Mask From dbo.TFingerPrint;	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_LeaveCredits_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_LeaveCredits_Select] @iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;

	if not exists(Select 1 From dbo.TLeaveCredits where EmployeeId=@iIntEmployeeId and CurrentYear=Year(GetDate()))
		Select 0 as VL,0 as SL
	else
		Select VL,SL From dbo.TLeaveCredits where EmployeeId=@iIntEmployeeId and CurrentYear=Year(GetDate());

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_LeaveCredits_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_LeaveCredits_Update] @iIntEmployeeId int
AS
BEGIN
	SET NOCOUNT ON;

	Declare @oResult as int = 0;
	Declare @VL as int=0;
	Declare @SL as int=0;

	Select @VL=NoDays From dbo.TLeaveCreditSettings Where LeaveType='VL';
	Select @SL=NoDays From dbo.TLeaveCreditSettings Where LeaveType='SL';

	if exists(Select 1 From dbo.TEmployeeEmpInfo where EmployeeId=@iIntEmployeeId And EmploymentType='Regular')
		begin
			if exists(Select 1 From dbo.TEmployeeEmpInfo where EmployeeId=@iIntEmployeeId and  DATEADD(year, 1, DateHired) <= cast(getdate() as date) and EmpStatus='Active')
				begin
					if exists(Select 1 from dbo.TLeaveCredits where EmployeeId=@iIntEmployeeId and CurrentYear=year(getdate()))
						Set @oResult = -3;
					else
						begin
							Insert Into dbo.TLeaveCredits(EmployeeId,VL,SL,CurrentYear)
								Values (@iIntEmployeeId,@VL,@SL,year(getdate()));
							Set @oResult =1;
						end
				end
			else	
				Set @oResult = -2;
		end
	else
		SET @oResult=-1;

	Select @oResult as Result;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Semester_Insert] @iStrSemesterDesc as varchar(50),	
								@iStrSchoolYear varchar(10),
								@iDtStartDate as date,
								@iDtEndDate as date,
								@iBitIsActive as bit = 1
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int);	
	If not exists(Select 1 From dbo.TSemester where SemesterDesc=@iStrSemesterDesc and SchoolYear=@iStrSchoolYear)
		begin
			Insert Into dbo.TSemester(SemesterDesc, SchoolYear, StartDate, EndDate, IsActive) output inserted.SemesterId
				Values(@iStrSemesterDesc, @iStrSchoolYear, @iDtStartDate, @iDtEndDate, @iBitIsActive);

			Select Top 1 Id From @tb;
		end
	else Select -1;
	
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Semester_Select] @iStrSearch varchar(250)
AS
BEGIN
	SET NOCOUNT ON;

	Select SemesterId,
		SemesterDesc,
		SchoolYear,
		StartDate,
		EndDate,
		IsActive From dbo.TSemester Where SemesterDesc Like '%'+@iStrSearch+'%' OR SchoolYear Like '%'+@iStrSearch+'%';

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Semester_SelectById] @iIntSemesterId int
AS
BEGIN
	SET NOCOUNT ON;

	Select SemesterId,
		SemesterDesc,
		SchoolYear,
		StartDate,
		EndDate,
		IsActive From dbo.TSemester Where SemesterId=@iIntSemesterId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_SelectDropdown]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Semester_SelectDropdown]
AS
BEGIN
	SET NOCOUNT ON;

	Select SemesterId, SemesterDesc+ ' (SY: ' + SchoolYear + ')' as SemesterSY  From dbo.TSemester where IsActive=1;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Semester_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Semester_Update] @iIntSemesterId as int, @iStrSemesterDesc as varchar(250),
								@iStrSchoolYear varchar(10),
								@iDtStartDate as date,
								@iDtEndDate as date,								
								@iBitIsActive as bit = 1
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TSemester Set 		
		SemesterDesc=@iStrSemesterDesc,
		SchoolYear = cast(year(@iDtStartDate) as varchar)+'-'+cast(year(@iDtStartDate)+1 as varchar),
		StartDate=@iDtStartDate,
		EndDate=@iDtEndDate,
		IsActive=@iBitIsActive Where SemesterId=@iIntSemesterId;
	
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_GetByUserName]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_SystemUser_GetByUserName] @iStrUserName varchar(64)
AS
BEGIN	
	SET NOCOUNT OFF;

	Select 
		UserId, PasswordHash, PasswordSalt from dbo.TUsers
	where UserName=@iStrUserName;
	

    SET NOCOUNT ON;
END




GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_SystemUser_Insert]
					@iStrUserName as varchar(50),
					@iBinPasswordHash as varbinary(256),
					@iBinPasswordSalt as varbinary(256),
					@iStrLastName as varchar(50),
					@iStrFirstName as varchar(50),
					@iStrMiddleName as varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int);

	If not exists(Select 1 From dbo.TUsers where LastName=@iStrLastName and FirstName=@iStrFirstName and MiddleName=@iStrMiddleName)
		begin
			Insert Into dbo.TUsers(UserName,
					PasswordHash,
					PasswordSalt,
					LastName,
					FirstName,
					MiddleName) output inserted.UserId
					Values(@iStrUserName,
									@iBinPasswordHash,
									@iBinPasswordSalt,
									@iStrLastName,
									@iStrFirstName,
									@iStrMiddleName);

			Select Top 1 Id From @tb;
		end
	else Select -1;	

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_ResetPassword]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_SystemUser_ResetPassword]
					@iIntUserId as int,					
					@iBinPasswordHash as varbinary(256),
					@iBinPasswordSalt as varbinary(256)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE dbo.TUsers 
	Set
		PasswordHash=@iBinPasswordHash,
		PasswordSalt=@iBinPasswordSalt
	where UserId=@iIntUserId;
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Select]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_SystemUser_Select]
					@iStrSearch as varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select UserId,
			UserName,
			dbo.fn_GetUserFullName(UserId) as UserFullName
		From dbo.TUsers 
		where UserName Like '%'+@iStrSearch+'%' OR
		LastName Like '%'+@iStrSearch+'%' OR
		FirstName Like '%'+@iStrSearch+'%' OR 
		MiddleName Like '%'+@iStrSearch+'%';
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_SystemUser_SelectById]
					@iIntUserId as varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Select UserId,
			UserName,
			dbo.fn_GetUserFullName(UserId) as UserFullName,
			LastName,
			FirstName,
			MiddleName
		From dbo.TUsers 
		where UserId=@iIntUserId;
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_SystemUser_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_SystemUser_Update]
					@iIntUserId as int,
					@iStrUserName as varchar(50),
					@iStrLastName as varchar(50),
					@iStrFirstName as varchar(50),
					@iStrMiddleName as varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TUsers Set 
		UserName=@iStrUserName,		
		LastName=@iStrLastName,
		FirstName=@iStrFirstName,
		MiddleName=@iStrMiddleName
	Where UserId=@iIntUserId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_ByEmpSemId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usp_Workload_ByEmpSemId] @iIntEmployeeId int, @iIntSemId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT WorkloadId
      ,DayOfWork
	  ,dbo.fn_GetEmployeeFullName(a.EmployeeId) as EmployeeFullName
			,e.Designation
			,d.DepartmentName
			,b.SemesterDesc +' (SY: '+b.SchoolYear+')' as Semester
      ,IIF(TimeInAM is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInAM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInAM
      ,IIF(TimeOutAM IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutAM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutAM
      ,IIF(TimeInPM IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInPM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInPM
      ,IIF(TimeOutPM is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutPM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutPM
	  ,IIF(TimeInEvening IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInEvening, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInEvening
      ,IIF(TimeOutEvening is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutEvening, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutEvening
	  ,(DATEDIFF(SECOND,ISNULL(TimeInAM,'00:00:00.0000000'), ISNULL(TimeOutAM,'00:00:00.0000000')) + DATEDIFF(SECOND,ISNULL(TimeInPM,'00:00:00.0000000'), ISNULL(TimeOutPM,'00:00:00.0000000'))
	  + DATEDIFF(SECOND,ISNULL(TimeInEvening,'00:00:00.0000000'), ISNULL(TimeOutEvening,'00:00:00.0000000')))* 1.00  / (60*60) as TotalNumberOfHours
  FROM dbo.TWorkload as a
  Inner Join dbo.TEmployeeEmpInfo as e on e.EmployeeId=a.EmployeeId
			Inner Join dbo.TSemester as b on a.SemesterId=b.SemesterId
			inner join dbo.TDepartments as d on d.DepartmentId=e.DepartmentId
  where a.EmployeeId=@iIntEmployeeId and a.SemesterId=@iIntSemId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_BySemId]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Usp_Workload_BySemId] @iIntSemId int
AS
BEGIN
	SET NOCOUNT ON;

	SELECT WorkloadId
      ,DayOfWork
	  ,dbo.fn_GetEmployeeFullName(a.EmployeeId) as EmployeeFullName
			,e.Designation
			,d.DepartmentName
			,b.SemesterDesc +' (SY: '+b.SchoolYear+')' as Semester
      ,IIF(TimeInAM is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInAM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInAM
      ,IIF(TimeOutAM IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutAM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutAM
      ,IIF(TimeInPM IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInPM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInPM
      ,IIF(TimeOutPM is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutPM, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutPM
	  ,IIF(TimeInEvening IS NULL,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeInEvening, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeInEvening
      ,IIF(TimeOutEvening is null,'-',REPLACE(REPLACE(ltrim(right(convert(varchar(25), TimeOutEvening, 100), 7)),'PM', ' PM'),'AM', ' AM')) as TimeOutEvening
	  ,(DATEDIFF(SECOND,ISNULL(TimeInAM,'00:00:00.0000000'), ISNULL(TimeOutAM,'00:00:00.0000000')) + DATEDIFF(SECOND,ISNULL(TimeInPM,'00:00:00.0000000'), ISNULL(TimeOutPM,'00:00:00.0000000'))
	  + DATEDIFF(SECOND,ISNULL(TimeInEvening,'00:00:00.0000000'), ISNULL(TimeOutEvening,'00:00:00.0000000')))* 1.00  / (60*60) as TotalNumberOfHours
  FROM dbo.TWorkload as a
  Inner Join dbo.TEmployeeEmpInfo as e on e.EmployeeId=a.EmployeeId
			Inner Join dbo.TSemester as b on a.SemesterId=b.SemesterId
			inner join dbo.TDepartments as d on d.DepartmentId=e.DepartmentId
  where a.SemesterId=@iIntSemId;

    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_Insert]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--https://www.codeproject.com/Questions/673111/Using-Time-7-DataType-in-Csharp
CREATE Procedure [dbo].[Usp_Workload_Insert]
					@iIntEmployeeId as int,
					@iIntSemesterId as int,
					@iStrDayOfWork as varchar(20), 
					@iTmTimeInAM as time(7)=NULL,
					@iTmTimeOutAM as time(7)=NULL,
					@iTmTimeInPM as time(7)=NULL,
					@iTmTimeOutPM as time(7)=NULL,
					@iTmTimeInEvening as time(7)=NULL,
					@iTmTimeOutEvening as time(7)=NULL
AS
BEGIN
	SET NOCOUNT ON;

	Declare @tb as table(id int); 

	If (Select count(1) From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@iIntSemesterId) > 6
		Select -2
	Else
		Begin
			If not exists(Select 1 From dbo.TWorkload where EmployeeId=@iIntEmployeeId and SemesterId=@iIntSemesterId and DayOfWork=@iStrDayOfWork)
				begin
					Insert Into dbo.TWorkload(EmployeeId,
									SemesterId,
									DayOfWork,
									TimeInAM,
									TimeOutAM,
									TimeInPM,
									TimeOutPM,
									TimeInEvening,
									TimeOutEvening)  output inserted.WorkloadId into @tb
						Values(@iIntEmployeeId,
							@iIntSemesterId,
							@iStrDayOfWork,
							@iTmTimeInAM,
							@iTmTimeOutAM,
							@iTmTimeInPM,
							@iTmTimeOutPM,
							@iTmTimeInEvening,
							@iTmTimeOutEvening);

					Select Top 1 Id From @tb;
				end
			else Select -1;
		End
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_SelectById]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Usp_Workload_SelectById]
					@iIntWorkloadId as int
AS
BEGIN
	SET NOCOUNT ON;

	Select WorkloadId,
			a.EmployeeId,
			dbo.fn_GetEmployeeFullName(a.EmployeeId) as EmployeeFullName,
			e.Designation,
			d.DepartmentName,
			b.SemesterDesc +' (SY: '+b.SchoolYear+')' as Semester,
			a.SemesterId,
			DayOfWork,
			TimeInAM,
			TimeOutAM,
			TimeInPM,
			TimeOutPM,
			TimeInEvening,
			TimeOutEvening From dbo.TWorkload as a 
			Inner Join dbo.TEmployeeEmpInfo as e on e.EmployeeId=a.EmployeeId
			Inner Join dbo.TSemester as b on a.SemesterId=b.SemesterId
			inner join dbo.TDepartments as d on d.DepartmentId=e.DepartmentId
	where WorkloadId=@iIntWorkloadId;
			
    SET NOCOUNT OFF;
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Workload_Update]    Script Date: 2/17/2020 12:07:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[Usp_Workload_Update]
					@iIntWorkloadId as int,
					@iIntEmployeeId as int,
					@iIntSemesterId as int,
					@iStrDayOfWork as varchar(20), 
					@iTmTimeInAM as time(7)=NULL,
					@iTmTimeOutAM as time(7)=NULL,
					@iTmTimeInPM as time(7)=NULL,
					@iTmTimeOutPM as time(7)=NULL,
					@iTmTimeInEvening as time(7)=NULL,
					@iTmTimeOutEvening as time(7)=NULL
AS
BEGIN
	SET NOCOUNT ON;

	Update dbo.TWorkload Set
			EmployeeId=@iIntEmployeeId,
			SemesterId=@iIntSemesterId,
			DayOfWork=@iStrDayOfWork,
			TimeInAM=@iTmTimeInAM,
			TimeOutAM=@iTmTimeOutAM,
			TimeInPM=@iTmTimeInPM,
			TimeOutPM=@iTmTimeOutPM,
			TimeInEvening=@iTmTimeInEvening,
			TimeOutEvening=@iTmTimeOutEvening
	where WorkloadId=@iIntWorkloadId;
	
    SET NOCOUNT OFF;
END
GO
