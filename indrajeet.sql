USE [master]
GO
/****** Object:  Database [TestMangement]    Script Date: 11/4/2022 3:16:48 PM ******/
CREATE DATABASE [TestMangement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TestMangement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestMangement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TestMangement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TestMangement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TestMangement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TestMangement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TestMangement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TestMangement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TestMangement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TestMangement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TestMangement] SET ARITHABORT OFF 
GO
ALTER DATABASE [TestMangement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TestMangement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TestMangement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TestMangement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TestMangement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TestMangement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TestMangement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TestMangement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TestMangement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TestMangement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TestMangement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TestMangement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TestMangement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TestMangement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TestMangement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TestMangement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TestMangement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TestMangement] SET RECOVERY FULL 
GO
ALTER DATABASE [TestMangement] SET  MULTI_USER 
GO
ALTER DATABASE [TestMangement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TestMangement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TestMangement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TestMangement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TestMangement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TestMangement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TestMangement', N'ON'
GO
ALTER DATABASE [TestMangement] SET QUERY_STORE = OFF
GO
USE [TestMangement]
GO
/****** Object:  Table [dbo].[tblStaffInformation]    Script Date: 11/4/2022 3:16:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStaffInformation](
	[StaffId] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](250) NULL,
	[PhoneNo] [nvarchar](16) NULL,
	[EmailId] [nvarchar](255) NULL,
	[Gender] [char](6) NULL,
	[AddressInfo] [nvarchar](max) NULL,
	[CityId] [int] NULL,
	[PINCode] [int] NULL,
	[StatusId] [nchar](10) NULL,
	[Password] [nvarchar](10) NULL,
	[StaffRegistrationDate] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblStaffInformation] ON 

INSERT [dbo].[tblStaffInformation] ([StaffId], [FullName], [PhoneNo], [EmailId], [Gender], [AddressInfo], [CityId], [PINCode], [StatusId], [Password], [StaffRegistrationDate]) VALUES (2, N'ashish Ostwal', N'9287578667', N'ashish@gmail.com', N'Male  ', NULL, NULL, NULL, NULL, N'A1', NULL)
INSERT [dbo].[tblStaffInformation] ([StaffId], [FullName], [PhoneNo], [EmailId], [Gender], [AddressInfo], [CityId], [PINCode], [StatusId], [Password], [StaffRegistrationDate]) VALUES (3, N'Vitthal Sakunde', N'8615968789', N'vitthal@gmail.com', N'Male  ', NULL, NULL, NULL, NULL, N'A2', NULL)
INSERT [dbo].[tblStaffInformation] ([StaffId], [FullName], [PhoneNo], [EmailId], [Gender], [AddressInfo], [CityId], [PINCode], [StatusId], [Password], [StaffRegistrationDate]) VALUES (4, N'Sanket', N'898574528', N'Sanket@gmai;l.com', N'Male  ', N'Pune', 2, 40218, N'5         ', N'A6', CAST(N'2022-02-02' AS Date))
INSERT [dbo].[tblStaffInformation] ([StaffId], [FullName], [PhoneNo], [EmailId], [Gender], [AddressInfo], [CityId], [PINCode], [StatusId], [Password], [StaffRegistrationDate]) VALUES (5, N'Muskan nadaf', N'897865780', N'muskan@gmail.com', N'Female', N'warje,Pune', 1, 40218, N'3         ', N'A4', CAST(N'2022-04-23' AS Date))
INSERT [dbo].[tblStaffInformation] ([StaffId], [FullName], [PhoneNo], [EmailId], [Gender], [AddressInfo], [CityId], [PINCode], [StatusId], [Password], [StaffRegistrationDate]) VALUES (6, N'Ankita patil', N'808787808', N'ankita@gmail.com', N'Female', N'Null Stop,Pune', 2, 30398, N'1         ', N'A6', CAST(N'2022-07-12' AS Date))
SET IDENTITY_INSERT [dbo].[tblStaffInformation] OFF
GO
USE [master]
GO
ALTER DATABASE [TestMangement] SET  READ_WRITE 
GO
