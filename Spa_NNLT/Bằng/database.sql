USE [master]
GO
/****** Object:  Database [QUANLY_SPA]    Script Date: 3/29/2025 9:21:40 PM ******/
CREATE DATABASE [QUANLY_SPA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QUANLY_SPA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QUANLY_SPA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QUANLY_SPA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QUANLY_SPA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QUANLY_SPA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLY_SPA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLY_SPA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLY_SPA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLY_SPA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QUANLY_SPA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLY_SPA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QUANLY_SPA] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLY_SPA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLY_SPA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLY_SPA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLY_SPA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLY_SPA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QUANLY_SPA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QUANLY_SPA] SET QUERY_STORE = ON
GO
ALTER DATABASE [QUANLY_SPA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QUANLY_SPA]
GO
/****** Object:  User [temma]    Script Date: 3/29/2025 9:21:40 PM ******/
CREATE USER [temma] FOR LOGIN [temma] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [temma]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [temma]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [temma]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [temma]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [temma]
GO
ALTER ROLE [db_datareader] ADD MEMBER [temma]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [temma]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [temma]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [temma]
GO
/****** Object:  Table [dbo].[tblDichVu]    Script Date: 3/29/2025 9:21:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDichVu](
	[madichvu] [varchar](10) NOT NULL,
	[ten] [nvarchar](40) NULL,
	[giadichvu] [varchar](10) NULL,
	[thoigian(h)] [varchar](5) NULL,
 CONSTRAINT [PK_tblDichVu] PRIMARY KEY CLUSTERED 
(
	[madichvu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[mahoadon] [varchar](10) NOT NULL,
	[makhachhang] [varchar](10) NOT NULL,
	[masanpham] [varchar](10) NULL,
	[madichvu] [varchar](10) NULL,
	[soluongsanpham] [varchar](2) NULL,
	[thanhtien] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachHang](
	[makhachhang] [varchar](10) NOT NULL,
	[ten] [nvarchar](30) NULL,
	[gioitinh] [tinyint] NULL,
	[sdt] [varchar](10) NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLichHen]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLichHen](
	[malichhen] [varchar](10) NOT NULL,
	[madichvu] [varchar](10) NULL,
	[manhanvien] [varchar](10) NULL,
	[thoigian] [datetime] NULL,
	[trangthai] [nvarchar](30) NULL,
 CONSTRAINT [PK_tblLichHen] PRIMARY KEY CLUSTERED 
(
	[malichhen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanVien]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanVien](
	[manhanvien] [varchar](10) NOT NULL,
	[tennhanvien] [nvarchar](30) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
	[sdt] [varchar](10) NULL,
	[job] [nvarchar](40) NOT NULL,
 CONSTRAINT [PK_tblNhanVien] PRIMARY KEY CLUSTERED 
(
	[manhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhong]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhong](
	[maphong] [varchar](10) NOT NULL,
	[loaiphong] [nvarchar](30) NULL,
	[tinhtrang] [nvarchar](30) NULL,
 CONSTRAINT [PK_tblPhong] PRIMARY KEY CLUSTERED 
(
	[maphong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQuannLy]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQuannLy](
	[maquanly] [varchar](10) NOT NULL,
	[tenquanly] [nvarchar](30) NOT NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [tinyint] NULL,
 CONSTRAINT [PK_tblQuannLy] PRIMARY KEY CLUSTERED 
(
	[maquanly] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSanPham]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSanPham](
	[masanpham] [varchar](10) NOT NULL,
	[tensanpham] [nvarchar](50) NULL,
	[giaban] [varchar](10) NULL,
	[soluongtonkho] [varchar](3) NULL,
 CONSTRAINT [PK_tblSanPham] PRIMARY KEY CLUSTERED 
(
	[masanpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblDichVu]  WITH CHECK ADD  CONSTRAINT [FK_tblDichVu_tblNhanVien] FOREIGN KEY([madichvu])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblDichVu] CHECK CONSTRAINT [FK_tblDichVu_tblNhanVien]
GO
ALTER TABLE [dbo].[tblDichVu]  WITH CHECK ADD  CONSTRAINT [FK_tblDichVu_tblQuannLy] FOREIGN KEY([madichvu])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblDichVu] CHECK CONSTRAINT [FK_tblDichVu_tblQuannLy]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblNhanVien] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblNhanVien]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblQuannLy] FOREIGN KEY([mahoadon])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblQuannLy]
GO
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblNhanVien] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblNhanVien]
GO
ALTER TABLE [dbo].[tblKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tblKhachHang_tblQuannLy] FOREIGN KEY([makhachhang])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblKhachHang] CHECK CONSTRAINT [FK_tblKhachHang_tblQuannLy]
GO
ALTER TABLE [dbo].[tblLichHen]  WITH CHECK ADD  CONSTRAINT [FK_tblLichHen_tblNhanVien] FOREIGN KEY([malichhen])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblLichHen] CHECK CONSTRAINT [FK_tblLichHen_tblNhanVien]
GO
ALTER TABLE [dbo].[tblLichHen]  WITH CHECK ADD  CONSTRAINT [FK_tblLichHen_tblQuannLy] FOREIGN KEY([malichhen])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblLichHen] CHECK CONSTRAINT [FK_tblLichHen_tblQuannLy]
GO
ALTER TABLE [dbo].[tblNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_tblNhanVien_tblQuannLy] FOREIGN KEY([manhanvien])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblNhanVien] CHECK CONSTRAINT [FK_tblNhanVien_tblQuannLy]
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblNhanVien] FOREIGN KEY([maphong])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblNhanVien]
GO
ALTER TABLE [dbo].[tblPhong]  WITH CHECK ADD  CONSTRAINT [FK_tblPhong_tblQuannLy] FOREIGN KEY([maphong])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblPhong] CHECK CONSTRAINT [FK_tblPhong_tblQuannLy]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblNhanVien] FOREIGN KEY([masanpham])
REFERENCES [dbo].[tblNhanVien] ([manhanvien])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblNhanVien]
GO
ALTER TABLE [dbo].[tblSanPham]  WITH CHECK ADD  CONSTRAINT [FK_tblSanPham_tblQuannLy] FOREIGN KEY([masanpham])
REFERENCES [dbo].[tblQuannLy] ([maquanly])
GO
ALTER TABLE [dbo].[tblSanPham] CHECK CONSTRAINT [FK_tblSanPham_tblQuannLy]
GO
/****** Object:  StoredProcedure [dbo].[chon_dichvu]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[chon_dichvu]
as
begin
SELECT [madichvu]
      ,[ten]
      ,[giadichvu]
      ,[thoigian(h)]
  FROM [dbo].[tblDichVu]
end
GO
/****** Object:  StoredProcedure [dbo].[sua_dichvu]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sua_dichvu]
(@madichvu varchar(10),
  @ten nvarchar(40),
  @giadichvu varchar(10),
  @thoigian varchar(5))
as

begin
UPDATE [dbo].[tblDichVu]
   SET [madichvu] = @madichvu
      ,[ten] = @ten
      ,[giadichvu] = @giadichvu 
      ,[thoigian(h)] = @thoigian
 WHERE madichvu = @madichvu
end
GO
/****** Object:  StoredProcedure [dbo].[them_dichvu]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[them_dichvu]
(@madichvu varchar(10)
           ,@ten nvarchar(40)
           ,@giadichvu varchar(10)
           ,@thoigian varchar(5))
as

begin
INSERT INTO [dbo].[tblDichVu]
           ([madichvu]
           ,[ten]
           ,[giadichvu]
           ,[thoigian(h)])
     VALUES
           (@madichvu
           ,@ten
           ,@giadichvu
           ,@thoigian)
end
GO
/****** Object:  StoredProcedure [dbo].[xoa_dichvu]    Script Date: 3/29/2025 9:21:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xoa_dichvu]
(@madichvu varchar(10))
as

begin
DELETE FROM [dbo].[tblDichVu]
      WHERE madichvu = @madichvu
end
GO
USE [master]
GO
ALTER DATABASE [QUANLY_SPA] SET  READ_WRITE 
GO
