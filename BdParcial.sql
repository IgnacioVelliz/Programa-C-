USE [master]
GO
/****** Object:  Database [Parcial]    Script Date: 23/9/2020 17:16:31 ******/
CREATE DATABASE [Parcial]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parcial', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Parcial.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parcial_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Parcial_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Parcial] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parcial].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parcial] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parcial] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parcial] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parcial] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parcial] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parcial] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parcial] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parcial] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parcial] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parcial] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parcial] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parcial] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parcial] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parcial] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parcial] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parcial] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parcial] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parcial] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parcial] SET RECOVERY FULL 
GO
ALTER DATABASE [Parcial] SET  MULTI_USER 
GO
ALTER DATABASE [Parcial] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parcial] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parcial] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parcial] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Parcial] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Parcial', N'ON'
GO
ALTER DATABASE [Parcial] SET QUERY_STORE = OFF
GO
USE [Parcial]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[IdProducto] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Stock] [int] NOT NULL,
	[PrecioUni] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[IdSucursal] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](50) NULL,
	[Localidad] [nvarchar](50) NULL,
	[Zona] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[IdSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [nvarchar](50) NOT NULL,
	[IdSucursal] [nvarchar](50) NOT NULL,
	[IdProducto] [nvarchar](50) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[PrecioUni] [int] NOT NULL,
	[Importe] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Producto] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Producto] ([IdProducto])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Producto]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Sucursal] FOREIGN KEY([IdSucursal])
REFERENCES [dbo].[Sucursal] ([IdSucursal])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Sucursal]
GO
/****** Object:  StoredProcedure [dbo].[AbmProducto]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AbmProducto]
@Seleccionar int, @IdProducto nvarchar(50), @Descripcion nvarchar(50), @Stock int, @PrecioUni int
as
BEGIN
if(@Seleccionar = 1)
	insert into Producto values (@IdProducto, @Descripcion, @Stock, @PrecioUni)
else if(@Seleccionar = 2)	
	delete from Producto where Producto.IdProducto = @IdProducto
else if(@Seleccionar = 3)
	update Producto set Producto.Descripcion = @Descripcion, Producto.Stock = @Stock, Producto.PrecioUni = @PrecioUni
	where Producto.IdProducto = @IdProducto
END
GO
/****** Object:  StoredProcedure [dbo].[AbmSucursal]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AbmSucursal]
@Seleccionar int, @IdSucursal nvarchar(50), @Direccion nvarchar(50), @Localidad nvarchar(50),@Zona nvarchar(50)
as
BEGIN
if(1=@Seleccionar)
	begin
	insert into Sucursal values (@IdSucursal, @Direccion, @Localidad, @Zona)
	end
else if(2=@Seleccionar)
	begin	
	delete from Sucursal where Sucursal.IdSucursal = @IdSucursal
	end
else if(3=@Seleccionar)
	begin	
	update Sucursal set Direccion = @Direccion, Localidad = @Localidad, Zona=@Zona
	where Sucursal.IdSucursal = @IdSucursal
	end
END
GO
/****** Object:  StoredProcedure [dbo].[AgregarVenta]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarVenta]
@IdVentas nvarchar(50), @IdSucursal nvarchar(50), @IdProducto nvarchar(50), @Cantidad int, @PrecioUni int, @Importe int
as
begin
insert into Venta values(@IdVentas, @IdSucursal, @IdProducto, @Cantidad, @PrecioUni, @Importe)
end
GO
/****** Object:  StoredProcedure [dbo].[CargarImporte]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[CargarImporte]
@IdVenta nvarchar(50)
as
begin
select Venta.Importe from Venta
where Venta.IdVenta = @IdVenta
end
GO
/****** Object:  StoredProcedure [dbo].[ContarVentas]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ContarVentas]
as
begin
select COUNT(*) from Venta
end
GO
/****** Object:  StoredProcedure [dbo].[ContVenPorSucursal]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ContVenPorSucursal]
@Sucursal nvarchar(50)
as
begin
select COUNT(*) from Venta 
where Venta.IdSucursal = @Sucursal
end
GO
/****** Object:  StoredProcedure [dbo].[ListarProducto]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarProducto]
as
begin
select * from Producto
end
GO
/****** Object:  StoredProcedure [dbo].[ListarPrVentas]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ListarPrVentas]
as
begin
select * from Producto
where Stock > 0
end
GO
/****** Object:  StoredProcedure [dbo].[ListarSucursal]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarSucursal]
as
begin
select * from Sucursal
end
GO
/****** Object:  StoredProcedure [dbo].[ListarVenta]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarVenta]
as
begin
select * from Venta
end
GO
/****** Object:  StoredProcedure [dbo].[PromedioVentaGen]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[PromedioVentaGen]
as
begin
select AVG(Venta.Importe) from Venta 
end
GO
/****** Object:  StoredProcedure [dbo].[PromedioVentaSuc]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PromedioVentaSuc]
@Sucursal nvarchar(50)
as
begin
select AVG(Venta.Importe) from Venta 
where Venta.IdSucursal = @Sucursal
end
GO
/****** Object:  StoredProcedure [dbo].[RestarStock]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RestarStock]
@Seleccionar int, @IdProducto nvarchar(50), @Stock int
as
Begin
if(@seleccionar=1)
	begin
	select Producto.Stock from Producto
	where Producto.IdProducto = @IdProducto
	end
else if(@seleccionar=2)
	begin
	update Producto set Stock = @Stock
	where Producto.IdProducto = @IdProducto
	end
End
GO
/****** Object:  StoredProcedure [dbo].[SucursalMax]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SucursalMax]
as
begin
select Venta.IdProducto, count(Venta.IdProducto) from Venta 
group by (Venta.IdProducto) 
order by (count(Venta.IdProducto)) desc
end
GO
/****** Object:  StoredProcedure [dbo].[SucursalMin]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SucursalMin]
as
begin
select Venta.IdProducto, count(Venta.IdProducto) from Venta 
group by (Venta.IdProducto) 
order by (count(Venta.IdProducto)) asc
end
GO
/****** Object:  StoredProcedure [dbo].[SumarVenGen]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SumarVenGen]
as
begin
select sum(Venta.Importe) from Venta 
end
GO
/****** Object:  StoredProcedure [dbo].[SumarVenSuc]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[SumarVenSuc]
@Sucursal nvarchar(50)
as
begin
select sum(Venta.Importe) from Venta 
where Venta.IdSucursal = @Sucursal
end
GO
/****** Object:  StoredProcedure [dbo].[VentaPorSucursal]    Script Date: 23/9/2020 17:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VentaPorSucursal]
@Sucursal nvarchar(50)
as
begin
select * from Venta 
where Venta.IdSucursal=@Sucursal
end
GO
USE [master]
GO
ALTER DATABASE [Parcial] SET  READ_WRITE 
GO
