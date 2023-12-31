USE [master]
GO
/****** Object:  Database [QuizApp]    Script Date: 12/22/2023 10:55:28 AM ******/
CREATE DATABASE [QuizApp]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuizApp', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuizApp.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuizApp_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuizApp_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuizApp] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuizApp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuizApp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuizApp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuizApp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuizApp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuizApp] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuizApp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuizApp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuizApp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuizApp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuizApp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuizApp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuizApp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuizApp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuizApp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuizApp] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuizApp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuizApp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuizApp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuizApp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuizApp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuizApp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuizApp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuizApp] SET RECOVERY FULL 
GO
ALTER DATABASE [QuizApp] SET  MULTI_USER 
GO
ALTER DATABASE [QuizApp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuizApp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuizApp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuizApp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuizApp] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuizApp] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuizApp] SET QUERY_STORE = OFF
GO
USE [QuizApp]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 12/22/2023 10:55:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Question] [nvarchar](max) NOT NULL,
	[A] [nvarchar](max) NOT NULL,
	[B] [nvarchar](max) NOT NULL,
	[C] [nvarchar](max) NOT NULL,
	[D] [nvarchar](max) NOT NULL,
	[CorrectAnswer] [nvarchar](max) NOT NULL,
	[Marks] [decimal](18, 2) NOT NULL,
	[HasMultipleAnswers] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (1, N'Pakistan was established in:', N'1947', N'1948', N'1949', N'1950', N'1947', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (2, N'Who is the founder of Pakistan?', N'Quaid - e - Azam', N'Liaquat Ali Khan', N'Allama Iqbal', N'Zardari', N'Quaid - e - Azam', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (3, N'Pakistan won the ODI world cup in  year:', N'1999', N'1997', N'1992', N'2019', N'1992', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (11, N'shortest day of the year is:', N'21 dec', N'22 dec', N'23 dec', N'24 dec', N'21 dec~23 dec~24 dec', CAST(1.50 AS Decimal(18, 2)), 1)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (12, N'longest day of the year is:', N'21 jun', N'22 jun', N'23 jun', N'24 jun', N'22 jun~23 jun', CAST(1.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (13, N'this class has ____ students.', N'1', N'18', N'19', N'23', N'18', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (14, N'HTML stands for:', N'hyper text markup language', N'hyper text markup locator', N'hyperstar text markup language', N'hyper test markup language', N'hyper text markup language', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (15, N'2 + 2 = ?', N'4', N'22', N'6', N'7', N'4~22', CAST(1.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (18, N'CSS Stands For :', N'Cascading Style Sheets', N'Cascade Styler Sheets', N'Hyper Style Sheets ', N'Cascade Sheets', N'Cascading Style Sheets', CAST(0.50 AS Decimal(18, 2)), 0)
INSERT [dbo].[Question] ([Id], [Question], [A], [B], [C], [D], [CorrectAnswer], [Marks], [HasMultipleAnswers]) VALUES (20, N'Karachi is the biggest city of?', N'India', N'Pakistan', N'Switzerland', N'US', N'Pakistan', CAST(0.50 AS Decimal(18, 2)), 0)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
ALTER TABLE [dbo].[Question] ADD  DEFAULT ((1)) FOR [Marks]
GO
ALTER TABLE [dbo].[Question] ADD  DEFAULT ((0)) FOR [HasMultipleAnswers]
GO
USE [master]
GO
ALTER DATABASE [QuizApp] SET  READ_WRITE 
GO
