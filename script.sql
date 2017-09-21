USE [master]
GO
/****** Object:  Database [EmployeeData]    Script Date: 21-09-2017 17:47:11 ******/
CREATE DATABASE [EmployeeData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeData', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EmployeeData.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EmployeeData_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\EmployeeData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EmployeeData] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeData] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeData] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EmployeeData] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EmployeeData]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 21-09-2017 17:47:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Employee Name] [varchar](50) NOT NULL,
	[EmployeeId] [varchar](10) NOT NULL,
	[DOB] [date] NOT NULL,
	[DOJ] [date] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [EmployeeData] SET  READ_WRITE 
GO
