USE [master]
GO
/****** Object:  Database [CanteenOrderingSystem]    Script Date: 11/15/2020 3:09:00 PM ******/
CREATE DATABASE [CanteenOrderingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CanteenOrderingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CanteenOrderingSystem.ndf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CanteenOrderingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\CanteenOrderingSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CanteenOrderingSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CanteenOrderingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CanteenOrderingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CanteenOrderingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CanteenOrderingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CanteenOrderingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CanteenOrderingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [CanteenOrderingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [CanteenOrderingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CanteenOrderingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CanteenOrderingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CanteenOrderingSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CanteenOrderingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CanteenOrderingSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CanteenOrderingSystem', N'ON'
GO
ALTER DATABASE [CanteenOrderingSystem] SET QUERY_STORE = OFF
GO
USE [CanteenOrderingSystem]
GO
/****** Object:  Table [dbo].[account]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](60) NOT NULL,
	[password] [nvarchar](32) NOT NULL,
	[fullname] [varchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[phonenumber] [nvarchar](12) NOT NULL,
	[id_role] [int] NOT NULL,
	[deletedAt] [datetime] NULL,
 CONSTRAINT [PK__user__3213E83F95A8CE9B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[account_role]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account_role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](10) NOT NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cart]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[id_user] [int] NOT NULL,
	[id_products] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[createdAt] [datetime] NOT NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC,
	[id_products] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[company]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[company](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_user] [int] NOT NULL,
	[totalprice] [money] NOT NULL,
	[createdAt] [datetime] NOT NULL,
	[deletedAt] [datetime] NULL,
	[address] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_details]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_details](
	[id_order] [int] NOT NULL,
	[id_products] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [money] NOT NULL,
	[createdAt] [datetime] NOT NULL,
	[deletedAt] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_order] ASC,
	[id_products] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[origin]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[origin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[deletedAt] [datetime] NULL,
 CONSTRAINT [PK__origin__3213E83F077AFC81] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[price] [money] NOT NULL,
	[volume] [int] NULL,
	[ingredient] [text] NULL,
	[id_productsType] [int] NOT NULL,
	[id_origin] [int] NULL,
	[id_sugarLevel] [int] NULL,
	[id_company] [int] NULL,
	[deletedAt] [datetime] NULL,
	[image] [image] NULL,
 CONSTRAINT [PK__products__3213E83FA9257410] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products_type]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products_type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
	[deletedAt] [datetime] NULL,
 CONSTRAINT [PK__products__3213E83FB6FF84FB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sugar_level]    Script Date: 11/15/2020 3:09:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sugar_level](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](20) NOT NULL,
	[deletedAt] [datetime] NULL,
 CONSTRAINT [PK__sugerLev__3213E83FC3727B13] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (2, N'thang@gmail.com', N'202CB962AC59075B964B07152D234B70', N'Thang Tran', CAST(N'2000-05-02' AS Date), N'0123456787', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (3, N'thang3@gmail.com', N'202CB962AC59075B964B07152D234B70', N'Thang Tran', CAST(N'2000-05-02' AS Date), N'0123456786', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1003, N'thang@gmai.com', N'202cb962ac59075b964b07152d234b70', N'THaNG Tran', CAST(N'2000-06-13' AS Date), N'0123134412', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1004, N'thang213@gmail.com', N'202cb962ac59075b964b07152d234b70', N'FKaO asdkoASD', CAST(N'2000-06-13' AS Date), N'0809182301', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1005, N'thang123@gmail.com', N'e33986039ee7aac9d6e3f40a4a69edef', N'Thang Tran', CAST(N'2000-10-12' AS Date), N'0390932093', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1006, N'thang144@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Minh Thang', CAST(N'2000-12-22' AS Date), N'+84123993024', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1007, N'thangdbrr@gmailmcom.com', N'4297f44b13955235245b2497399d7a93', N'Thang Tr', CAST(N'2020-11-10' AS Date), N'0923123124', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1008, N'thang22@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Tran Thang', CAST(N'2000-12-10' AS Date), N'0293929321', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1009, N'thang223@gmail.com', N'2cfd4560539f887a5e420412b370b361', N'Tran thang', CAST(N'2000-12-20' AS Date), N'0129392321', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1010, N'thang222@gmail.com', N'161ffa10df89f2ae92da4ccf9d8b7f9d', N'ollokoko aDkaso', CAST(N'2020-11-03' AS Date), N'0129309203', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1011, N'thang1231@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Mnh Thang', CAST(N'2000-12-20' AS Date), N'0293993923', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1012, N'thang2313@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Minh Thang', CAST(N'2000-12-20' AS Date), N'0239921939', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1013, N'thang123124@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Mnh Thang', CAST(N'2000-12-22' AS Date), N'0123342332', 4, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1014, N'thang213421@gmail.com', N'202cb962ac59075b964b07152d234b70', N'trhan thang', CAST(N'2000-12-02' AS Date), N'0912939293', 1, NULL)
INSERT [dbo].[account] ([id], [email], [password], [fullname], [birthday], [phonenumber], [id_role], [deletedAt]) VALUES (1015, N'thang2314@gmail.com', N'202cb962ac59075b964b07152d234b70', N'Thang Tran', CAST(N'2000-12-20' AS Date), N'0129394129', 1, NULL)
SET IDENTITY_INSERT [dbo].[account] OFF
GO
SET IDENTITY_INSERT [dbo].[account_role] ON 

INSERT [dbo].[account_role] ([id], [name], [deletedAt]) VALUES (1, N'admin', NULL)
INSERT [dbo].[account_role] ([id], [name], [deletedAt]) VALUES (4, N'user', NULL)
SET IDENTITY_INSERT [dbo].[account_role] OFF
GO
SET IDENTITY_INSERT [dbo].[products_type] ON 

INSERT [dbo].[products_type] ([id], [name], [deletedAt]) VALUES (1, N'Coke', NULL)
SET IDENTITY_INSERT [dbo].[products_type] OFF
GO
ALTER TABLE [dbo].[account]  WITH CHECK ADD FOREIGN KEY([id_role])
REFERENCES [dbo].[account_role] ([id])
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD FOREIGN KEY([id_products])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[cart]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD FOREIGN KEY([id_user])
REFERENCES [dbo].[account] ([id])
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD FOREIGN KEY([id_order])
REFERENCES [dbo].[order] ([id])
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD FOREIGN KEY([id_products])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([id_company])
REFERENCES [dbo].[company] ([id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([id_origin])
REFERENCES [dbo].[origin] ([id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD FOREIGN KEY([id_productsType])
REFERENCES [dbo].[products_type] ([id])
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK__products__id_sug__7A672E12] FOREIGN KEY([id_sugarLevel])
REFERENCES [dbo].[sugar_level] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK__products__id_sug__7A672E12]
GO
USE [master]
GO
ALTER DATABASE [CanteenOrderingSystem] SET  READ_WRITE 
GO
