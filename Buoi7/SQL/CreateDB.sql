USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 24/10/2022 09:51:43 ******/
CREATE DATABASE [QLSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSinhVien.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSinhVien_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSinhVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSinhVien', N'ON'
GO
USE [QLSinhVien]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 24/10/2022 09:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQua](
	[MaSV] [nvarchar](20) NOT NULL,
	[MaMH] [nvarchar](20) NOT NULL,
	[Diem] [float] NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 24/10/2022 09:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [nvarchar](20) NOT NULL,
	[TenKhoa] [nvarchar](50) NULL,
 CONSTRAINT [PK__Khoa__653904054BCAF508] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Lop]    Script Date: 24/10/2022 09:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lop](
	[MaLop] [nvarchar](20) NOT NULL,
	[TenLop] [nvarchar](50) NULL,
	[MaKhoa] [nvarchar](20) NULL,
 CONSTRAINT [PK__Lop__3B98D273E1B35201] PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 24/10/2022 09:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonHoc](
	[MaMH] [nvarchar](20) NOT NULL,
	[TenMH] [nvarchar](50) NULL,
 CONSTRAINT [PK__MonHoc__2725DFD98C349629] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 24/10/2022 09:51:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [nvarchar](20) NOT NULL,
	[TenSV] [nvarchar](50) NULL,
	[NgSinh] [datetime] NULL,
	[MaLop] [nvarchar](20) NULL,
 CONSTRAINT [PK__SinhVien__2725081A0326D13B] PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'1', N'1', 5.2)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'1', N'2', 9.9)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'2', N'1', 1.4)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'2', N'2', 6.5)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'2', N'3', 9.2)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'3', N'1', 4.8)
GO
INSERT [dbo].[KetQua] ([MaSV], [MaMH], [Diem]) VALUES (N'3', N'2', 4.5)
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTP', N'Công Nghệ Thực Phẩm')
GO
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (N'CNTT', N'Công Nghệ Thông Tin')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'01DHTP1', N'Thực phẩm 1', N'CNTP')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'11DHTH1', N'Tin học 1', N'CNTT')
GO
INSERT [dbo].[Lop] ([MaLop], [TenLop], [MaKhoa]) VALUES (N'11DHTH2', N'Tin học 2', N'CNTT')
GO
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'1', N'NMLT')
GO
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'2', N'Nấu cơm')
GO
INSERT [dbo].[MonHoc] ([MaMH], [TenMH]) VALUES (N'3', N'Code dạo')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgSinh], [MaLop]) VALUES (N'1', N'NVA', NULL, N'11DHTH1')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgSinh], [MaLop]) VALUES (N'2', N'NVB', NULL, N'11DHTH2')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgSinh], [MaLop]) VALUES (N'3', N'NVC', NULL, N'11DHTH2')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgSinh], [MaLop]) VALUES (N'4', N'VND', NULL, N'11DHTH1')
GO
INSERT [dbo].[SinhVien] ([MaSV], [TenSV], [NgSinh], [MaLop]) VALUES (N'5', N'VNF', NULL, N'01DHTP1')
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_MonHoc] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MonHoc] ([MaMH])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_MonHoc]
GO
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_SinhVien] FOREIGN KEY([MaSV])
REFERENCES [dbo].[SinhVien] ([MaSV])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_SinhVien]
GO
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([MaLop])
REFERENCES [dbo].[Lop] ([MaLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
