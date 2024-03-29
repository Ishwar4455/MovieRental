USE [master]
GO
/****** Object:  Database [RentedMovie]    Script Date: 17/09/2019 11:29:45 AM ******/
CREATE DATABASE [RentedMovie]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentedMovie', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentedMovie.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RentedMovie_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RentedMovie_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RentedMovie] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentedMovie].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentedMovie] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentedMovie] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentedMovie] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentedMovie] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentedMovie] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentedMovie] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentedMovie] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentedMovie] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentedMovie] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentedMovie] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentedMovie] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentedMovie] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentedMovie] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentedMovie] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentedMovie] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentedMovie] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentedMovie] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentedMovie] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentedMovie] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentedMovie] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentedMovie] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentedMovie] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentedMovie] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RentedMovie] SET  MULTI_USER 
GO
ALTER DATABASE [RentedMovie] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentedMovie] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentedMovie] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentedMovie] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RentedMovie] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RentedMovie] SET QUERY_STORE = OFF
GO
USE [RentedMovie]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL,
	[ReleaseDate] [date] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_Movies]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[v_Movies] AS
Select [MovieID]
      ,[Title]
      ,[Rating]
      ,[Year]
	  ,Genre
	  ,Plot
      ,[Rental_Cost] from Movies

GO
/****** Object:  Table [dbo].[Customer]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LoginID] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MoviesIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [datetime] NULL,
	[DateReturned] [datetime] NULL,
 CONSTRAINT [PK_RentedMovies] PRIMARY KEY CLUSTERED 
(
	[RMID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (8, N'Rohit', N'khatri', N'84coronation road', N'022889278')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (9, N'bob', N'singh', N'2/513 manukau', N'02536389978')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (12, N'Sukh', N'randhawa', N'8 hill road', N'0227614256')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (13, N'Netin', N'singh', N'78 botany road', N'022678539')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (14, N'Guri', N'singh', N'78 rose avenue', N'022764578')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (15, N'Jaskirat', N'sandhu', N'8 wenty street', N'022872626')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (17, N'Jashan', N'virk', N'45 hillside road', N'0226544257')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (18, N'Guri', N'dhillon', N'98 mount roskill', N'0278795568')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (23, N'Joban', N'sandhu', N'78train road', N'0299299029')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (24, N'Simran', N'singh', N'35 west avenue', N'0229282889')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([ID], [LoginID], [Password]) VALUES (1, N'Ishwer', N'Ishwer@123')
SET IDENTITY_INSERT [dbo].[Login] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (4, NULL, N'3 ideots', NULL, 20.0000, NULL, N'Two friends are searching for their long lost companion. They revisit their college days and recall the memories of their friend who inspired them to think differently, even as the rest of the world called them "idiots".', N'Comedy', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (7, NULL, N'Sholey', NULL, 15.0000, NULL, N'Action and drama movie', N'Adventure', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (8, NULL, N'Race3', NULL, 10.0000, NULL, N'Shamsher Singh (Anil Kapoor) owns a private island Al-Shifa for trading arms. Sikander Singh (Salman Khan) is Shamsher''s step son, while Sanjana (Daisy Shah) and Sooraj (Saqib Saleem) are his twin children. Yash (Bobby Deol) is a close associate at Shamsher''s empire and Sikander''s confidante and Raghuvendra or more commonly known as Raghu chahcha(Sharat Saxena) is the bodyguard and close confidate to Shamsher. In a flashback scene, it is revealed that Rana Vijay (Freddy Daruwala) is Shamsher''s business rival and he creates problems for Shamsher''s family business. As both Sanjana and Sooraj age to 25 years, their family lawyer explains the will of their deceased mother (Nishigandha Wad). As per the will, the twins are entitled for the rest of 50% of property as joint patner (25% share each), and the rest 50% for Sikander.', N'Action', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (10, NULL, N'Singham', NULL, 30.0000, NULL, N'ajirao Singham (Ajay Devgn) who is now the Deputy Commissioner of Police, gets transferred to Mumbai and he discovers that one of his team members (Mahesh) is found dead inside an ambulance with massive bags of money. Bajirao decides to unearth the truth behind it and in this process, he collides with a powerful and fraudulent religious leader, Satyaraj Chandar a.k.a. Babaji (Amole Gupte), who has high-profile connections with corrupt politicians.', N'Action ', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (11, NULL, N'Animals lover', NULL, 18.0000, NULL, N'lovers of animals how to behave with them', N'Adventures', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (12, NULL, N'Gadar', NULL, 20.0000, NULL, N'Fight against love and countries .', N'Love story ', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (13, NULL, N'Milkha singh', NULL, 10.0000, NULL, N'Race for their country to decrease descrimination', N'Struggle', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (15, NULL, N'Josh ', NULL, 17.0000, NULL, N'Descrimination against love', N'Action', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (16, NULL, N' The king', NULL, 12.0000, NULL, N'To do their rights .', N'Biography', NULL)
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre], [ReleaseDate]) VALUES (17, NULL, N'Nariniya', NULL, 10.0000, NULL, N'the story about half man and animals', N'Adventures', NULL)
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (1, 6, 24, CAST(N'2019-09-17T10:43:04.337' AS DateTime), NULL)
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (2, 4, 24, CAST(N'2019-09-17T10:43:54.640' AS DateTime), CAST(N'2019-09-17T10:44:38.743' AS DateTime))
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (3, 15, 17, CAST(N'2019-09-17T11:20:11.180' AS DateTime), NULL)
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (4, 8, 12, CAST(N'2019-09-17T11:20:43.590' AS DateTime), NULL)
INSERT [dbo].[RentedMovies] ([RMID], [MoviesIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (5, 13, 23, CAST(N'2019-09-17T11:21:06.327' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
/****** Object:  StoredProcedure [dbo].[GetMoviesRentalList]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMoviesRentalList]
(
@rentalType char(1)
)
AS
BEGIN
IF(@rentalType='A')
BEGIN
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID 
END
else
SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID where DateReturned is  null
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCustomers]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteCustomers]
@customerID int
AS
BEGIN

delete from Customer where CustID=@customerID

END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteMovies]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteMovies]
@movieID int
AS
BEGIN

delete from Movies where MovieID=@movieID
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetCustomerList]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetCustomerList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
	SELECT [CustID]
      ,[FirstName]
      ,[LastName]
      ,[Address]
      ,[Phone]
  FROM [dbo].[Customer]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetMovieList]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_GetMovieList]
	-- Add the parameters for the stored procedure here
	
AS
BEGIN
SELECT [MovieID]
      ,[Title]
	  ,[Genre]
      ,[Rental_Cost]
      ,Plot
  FROM [dbo].[Movies]
END

GO
/****** Object:  StoredProcedure [dbo].[sp_GetRentalList]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetRentalList]
AS
BEGIN

SelecT RentedMovies.RMID, FirstName, LastName, Address, Title, Rental_Cost, DateRented ,DateReturned from RentedMovies
join Customer on RentedMovies.CustIDFK = Customer.CustID
join Movies on RentedMovies.MoviesIDFK = Movies.MovieID


END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertRentalIssueMovie]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertRentalIssueMovie]
(
@customerID int,
@movieID int
)
AS

BEGIN


INSERT INTO [dbo].[RentedMovies]
           ([MoviesIDFK]
           ,[CustIDFK]
           ,[DateRented]
           )
     VALUES
           (@movieID
           ,@customerID
           ,GETDATE()
           )
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateCustomer]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateCustomer]
@FirstName nvarchar(255)
,@LastName nvarchar(255)
,@Address nvarchar(255)
,@Phone nvarchar(255)
,@CustID int=0
AS
BEGIN
IF(@CustID >0)
BEGIN
UPDATE [dbo].[Customer]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      ,[Address] = @Address
      ,[Phone] = @Phone
 WHERE CustID = @CustID
END
ELSE
BEGIN
INSERT INTO [dbo].[Customer]
           ([FirstName]
           ,[LastName]
           ,[Address]
           ,[Phone])
     VALUES
           (@FirstName
           ,@LastName
           ,@Address
           ,@Phone)

END


END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUpdateMovies]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertUpdateMovies]
(
@Rating nvarchar(50)=null
,@Title nvarchar(255)
,@Year nvarchar(255)=null
,@Rental_Cost money
,@Copies nvarchar(50)=null
,@Plot ntext
,@Genre nvarchar(50)
,@MovieID int =0
)
AS
BEGIN

if(@MovieID >0)
BEGIN

UPDATE [dbo].[Movies]
   SET [Rating] = @Rating
      ,[Title] = @Title
      ,[Year] = @Year
      ,[Rental_Cost] = @Rental_Cost
      ,[Copies] = @Copies
      ,[Plot] = @Plot
      ,[Genre] = @Genre
 WHERE MovieID = @MovieID

END
ELSE
BEGIN



INSERT INTO [dbo].[Movies]
           ([Rating]
           ,[Title]
           ,[Year]
           ,[Rental_Cost]
           ,[Copies]
           ,[Plot]
           ,[Genre])
     VALUES
           (@Rating
           ,@Title
           ,@Year
           ,@Rental_Cost
           ,@Copies
           ,@Plot
           ,@Genre)
END
END


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateRentalReturnMovie]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateRentalReturnMovie]
(
@rentalID int
)
AS

BEGIN


UPDATE [dbo].[RentedMovies]
   SET  [DateReturned] = GETDATE()
 WHERE RMID =@rentalID
END

GO
/****** Object:  StoredProcedure [dbo].[userLogin]    Script Date: 17/09/2019 11:29:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--exec userLogin 'mk','welcome'
CREATE procedure [dbo].[userLogin] 
@userID varchar(100),
@pwd Nvarchar(510)
as
Begin
		
select * from Login where LoginID=@userID and Password=@pwd

	
End

GO
USE [master]
GO
ALTER DATABASE [RentedMovie] SET  READ_WRITE 
GO
