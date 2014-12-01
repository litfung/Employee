USE [master]
GO
/****** Object:  Database [NewEmployeeDatabase]    Script Date: 12/2/2014 12:31:01 AM ******/
CREATE DATABASE [NewEmployeeDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NewEmployeeDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NewEmployeeDatabase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'NewEmployeeDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\NewEmployeeDatabase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [NewEmployeeDatabase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NewEmployeeDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NewEmployeeDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [NewEmployeeDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NewEmployeeDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NewEmployeeDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [NewEmployeeDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NewEmployeeDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NewEmployeeDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [NewEmployeeDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NewEmployeeDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NewEmployeeDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NewEmployeeDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [NewEmployeeDatabase]
GO
/****** Object:  Table [dbo].[tbl_city]    Script Date: 12/2/2014 12:31:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_city](
	[cit_Id] [int] IDENTITY(1,1) NOT NULL,
	[cit_name] [nchar](10) NOT NULL,
	[cit_couId] [int] NOT NULL,
 CONSTRAINT [PK_tbl] PRIMARY KEY CLUSTERED 
(
	[cit_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Country]    Script Date: 12/2/2014 12:31:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Country](
	[cou_Id] [int] IDENTITY(1,1) NOT NULL,
	[cou_Name] [nvarchar](128) NULL,
 CONSTRAINT [PK_tbl_Country] PRIMARY KEY CLUSTERED 
(
	[cou_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Employee]    Script Date: 12/2/2014 12:31:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Employee](
	[emp_Id] [int] IDENTITY(1,1) NOT NULL,
	[emp_Login] [nvarchar](64) NULL,
	[emp_Password] [nvarchar](64) NULL,
	[emp_CreateDate] [datetime] NULL,
	[emp_LastLogin] [datetime] NULL,
	[emp_IsRemove] [bit] NULL,
 CONSTRAINT [PK_tbl_Employee] PRIMARY KEY CLUSTERED 
(
	[emp_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_EmployeeDetails]    Script Date: 12/2/2014 12:31:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EmployeeDetails](
	[empdet_id] [int] IDENTITY(1,1) NOT NULL,
	[empdet_empId] [int] NOT NULL,
	[empdet_FirstName] [nvarchar](64) NOT NULL,
	[empdet_MiddleName] [nvarchar](64) NULL,
	[empdet_LastName] [nvarchar](64) NOT NULL,
	[empdet_CityId] [int] NOT NULL,
	[empdet_residentialAddress] [nvarchar](256) NOT NULL,
	[empdet_residentialPostCode] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_tbl_EmployeeDetails] PRIMARY KEY CLUSTERED 
(
	[empdet_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[tbl_city]  WITH CHECK ADD  CONSTRAINT [FK_tbl_city_tbl_Country] FOREIGN KEY([cit_couId])
REFERENCES [dbo].[tbl_Country] ([cou_Id])
GO
ALTER TABLE [dbo].[tbl_city] CHECK CONSTRAINT [FK_tbl_city_tbl_Country]
GO
ALTER TABLE [dbo].[tbl_EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbl_EmployeeDetails_tbl_city] FOREIGN KEY([empdet_CityId])
REFERENCES [dbo].[tbl_city] ([cit_Id])
GO
ALTER TABLE [dbo].[tbl_EmployeeDetails] CHECK CONSTRAINT [FK_tbl_EmployeeDetails_tbl_city]
GO
ALTER TABLE [dbo].[tbl_EmployeeDetails]  WITH CHECK ADD  CONSTRAINT [FK_tbl_EmployeeDetails_tbl_Employee] FOREIGN KEY([empdet_empId])
REFERENCES [dbo].[tbl_Employee] ([emp_Id])
GO
ALTER TABLE [dbo].[tbl_EmployeeDetails] CHECK CONSTRAINT [FK_tbl_EmployeeDetails_tbl_Employee]
GO
USE [master]
GO
ALTER DATABASE [NewEmployeeDatabase] SET  READ_WRITE 
GO
