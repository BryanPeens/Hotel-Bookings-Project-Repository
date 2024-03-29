USE [HotelPerfect]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type in (N'U'))
DROP TABLE [dbo].[tblUsers]
GO
/****** Object:  Table [dbo].[tblSuites]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSuites]') AND type in (N'U'))
DROP TABLE [dbo].[tblSuites]
GO
/****** Object:  Table [dbo].[tblSuiteOptions]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSuiteOptions]') AND type in (N'U'))
DROP TABLE [dbo].[tblSuiteOptions]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEmployee]') AND type in (N'U'))
DROP TABLE [dbo].[tblEmployee]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblClient]') AND type in (N'U'))
DROP TABLE [dbo].[tblClient]
GO
USE [master]
GO
/****** Object:  Database [HotelPerfect]    Script Date: 2018-02-21 9:11:44 PM ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'HotelPerfect')
DROP DATABASE [HotelPerfect]
GO
/****** Object:  Database [HotelPerfect]    Script Date: 2018-02-21 9:11:44 PM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'HotelPerfect')
BEGIN
CREATE DATABASE [HotelPerfect]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelPerfect', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HotelPerfect.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HotelPerfect_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\HotelPerfect_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [HotelPerfect] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelPerfect].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelPerfect] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelPerfect] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelPerfect] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelPerfect] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelPerfect] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelPerfect] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelPerfect] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelPerfect] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelPerfect] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelPerfect] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelPerfect] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelPerfect] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelPerfect] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelPerfect] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelPerfect] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelPerfect] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelPerfect] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelPerfect] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelPerfect] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelPerfect] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelPerfect] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelPerfect] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelPerfect] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelPerfect] SET  MULTI_USER 
GO
ALTER DATABASE [HotelPerfect] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelPerfect] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelPerfect] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelPerfect] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [HotelPerfect] SET DELAYED_DURABILITY = DISABLED 
GO
USE [HotelPerfect]
GO
/****** Object:  Table [dbo].[tblClient]    Script Date: 2018-02-21 9:11:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblClient]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblClient](
	[clientID] [int] IDENTITY(1,1) NOT NULL,
	[clientName] [nvarchar](50) NOT NULL,
	[clientSurname] [nvarchar](50) NOT NULL,
	[clientIDnumber] [int] NOT NULL,
	[clienttelephoneNumber] [int] NOT NULL,
 CONSTRAINT [PK_tblClient] PRIMARY KEY CLUSTERED 
(
	[clientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 2018-02-21 9:11:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblEmployee]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblEmployee](
	[employeeId] [int] IDENTITY(1,1) NOT NULL,
	[emploeeName] [nvarchar](50) NOT NULL,
	[employeeSurname] [nvarchar](50) NOT NULL,
	[employeePhoneNum] [int] NOT NULL,
	[LoginId] [int] NOT NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[employeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tblSuiteOptions]    Script Date: 2018-02-21 9:11:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSuiteOptions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblSuiteOptions](
	[optionID] [int] IDENTITY(1,1) NOT NULL,
	[optionName] [nvarchar](500) NOT NULL,
	[optionPrice] [decimal](18, 0) NOT NULL,
	[perDay] [bit] NOT NULL CONSTRAINT [DF_tblSuiteOptions_perDay]  DEFAULT ((0)),
 CONSTRAINT [PK_tblSuiteOptions] PRIMARY KEY CLUSTERED 
(
	[optionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tblSuites]    Script Date: 2018-02-21 9:11:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblSuites]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblSuites](
	[suiteID] [int] IDENTITY(1,1) NOT NULL,
	[suiteName] [nvarchar](50) NOT NULL,
	[suiteDescription] [nvarchar](50) NOT NULL,
	[maxPatrons] [int] NOT NULL,
	[costpppn] [money] NOT NULL,
 CONSTRAINT [PK_tblSuites] PRIMARY KEY CLUSTERED 
(
	[suiteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 2018-02-21 9:11:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tblUsers]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tblUsers](
	[userID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[tblSuiteOptions] ON 

INSERT [dbo].[tblSuiteOptions] ([optionID], [optionName], [optionPrice], [perDay]) VALUES (1, N'Bed and Breakfast', CAST(100 AS Decimal(18, 0)), 1)
INSERT [dbo].[tblSuiteOptions] ([optionID], [optionName], [optionPrice], [perDay]) VALUES (2, N'Dinner, Bed and Breakfast', CAST(180 AS Decimal(18, 0)), 1)
INSERT [dbo].[tblSuiteOptions] ([optionID], [optionName], [optionPrice], [perDay]) VALUES (3, N'12 Roses', CAST(60 AS Decimal(18, 0)), 0)
INSERT [dbo].[tblSuiteOptions] ([optionID], [optionName], [optionPrice], [perDay]) VALUES (4, N'24 Roses', CAST(120 AS Decimal(18, 0)), 0)
INSERT [dbo].[tblSuiteOptions] ([optionID], [optionName], [optionPrice], [perDay]) VALUES (5, N'Champagne', CAST(60 AS Decimal(18, 0)), 0)
SET IDENTITY_INSERT [dbo].[tblSuiteOptions] OFF
SET IDENTITY_INSERT [dbo].[tblSuites] ON 

INSERT [dbo].[tblSuites] ([suiteID], [suiteName], [suiteDescription], [maxPatrons], [costpppn]) VALUES (1, N'Hibuscus Suite', N'Timeless romance Luxury Suite', 2, 350.0000)
INSERT [dbo].[tblSuites] ([suiteID], [suiteName], [suiteDescription], [maxPatrons], [costpppn]) VALUES (2, N'Acacia Garden Suite', N'African elegance tatch & rock', 2, 350.0000)
INSERT [dbo].[tblSuites] ([suiteID], [suiteName], [suiteDescription], [maxPatrons], [costpppn]) VALUES (3, N'Bouganvillea Suite', N'Luxurious indulgence Queen size', 2, 350.0000)
INSERT [dbo].[tblSuites] ([suiteID], [suiteName], [suiteDescription], [maxPatrons], [costpppn]) VALUES (4, N'Mango Grovce Suite', N'Wild and Fantastic King size Bed and heated floors', 2, 450.0000)
SET IDENTITY_INSERT [dbo].[tblSuites] OFF
SET IDENTITY_INSERT [dbo].[tblUsers] ON 

INSERT [dbo].[tblUsers] ([userID], [username]) VALUES (1, N'ABBA')
SET IDENTITY_INSERT [dbo].[tblUsers] OFF
USE [master]
GO
ALTER DATABASE [HotelPerfect] SET  READ_WRITE 
GO
