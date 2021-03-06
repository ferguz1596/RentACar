USE [master]
GO
/****** Object:  Database [RentACar]    Script Date: 02/06/2018 11:22:39 a. m. ******/
CREATE DATABASE [RentACar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RentACar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentACar.mdf' , SIZE = 12480KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RentACar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\RentACar_log.ldf' , SIZE = 6400KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RentACar] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RentACar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RentACar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RentACar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RentACar] SET ARITHABORT OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RentACar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RentACar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RentACar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RentACar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RentACar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RentACar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RentACar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RentACar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RentACar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RentACar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RentACar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RentACar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RentACar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RentACar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RentACar] SET RECOVERY FULL 
GO
ALTER DATABASE [RentACar] SET  MULTI_USER 
GO
ALTER DATABASE [RentACar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RentACar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RentACar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RentACar] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RentACar] SET DELAYED_DURABILITY = DISABLED 
GO
USE [RentACar]
GO
/****** Object:  UserDefinedFunction [dbo].[Inicio_Sesion]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Inicio_Sesion] 
(
@Users nvarchar(50),
@Pass nvarchar(40)

)
RETURNS int
AS
BEGIN
	-- Declare the return variable here
	DECLARE @Resultado INT
	set @Resultado = 0

	-- Add the T-SQL statements to compute the return value here
	if exists (SELECT USUARIO FROM Empleados WHERE usuario = @Users AND contrasenia = @Pass)
	begin 
	set @Resultado  = 1
	end 

	-- Return the result of the function
	RETURN @Resultado

END

GO
/****** Object:  Table [dbo].[Autos]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autos](
	[matricula] [nvarchar](8) NOT NULL,
	[marca] [nvarchar](50) NULL,
	[modelo] [nvarchar](50) NULL,
	[color] [nvarchar](20) NULL,
	[anio] [nvarchar](4) NULL,
	[tipo] [nvarchar](20) NULL,
	[capacidad] [int] NULL,
	[estadoAuto] [int] NULL,
	[imagenAuto] [image] NULL,
	[montoRenta] [float] NULL,
	[adquiridoA] [nvarchar](100) NULL,
	[fechaAdquisicion] [datetime] NULL,
	[observacionesAuto] [nvarchar](max) NULL,
	[descEstadoAuto] [nvarchar](max) NULL,
 CONSTRAINT [PK__Autos__30962D1415502753] PRIMARY KEY CLUSTERED 
(
	[matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[DUI] [nvarchar](10) NOT NULL,
	[nombresCliente] [nvarchar](50) NULL,
	[apellidosCliente] [nvarchar](50) NULL,
	[edadCliente] [int] NULL,
	[nLicencia] [nvarchar](17) NULL,
	[dirCliente] [nvarchar](100) NULL,
	[telCliente] [nvarchar](9) NULL,
 CONSTRAINT [PK__Cliente__C03671B801232056] PRIMARY KEY CLUSTERED 
(
	[DUI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ControlRenta]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlRenta](
	[idControlRenta] [int] IDENTITY(1,1) NOT NULL,
	[idEmpleado] [int] NULL,
	[idRenta] [int] NULL,
	[idDevolucion] [int] NULL,
 CONSTRAINT [PK__ControlR__04CAF3C900D39005] PRIMARY KEY CLUSTERED 
(
	[idControlRenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Devolucion]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Devolucion](
	[idDevolucion] [int] IDENTITY(1,1) NOT NULL,
	[matriculaAutoD] [nvarchar](8) NULL,
	[DUICliente] [nvarchar](10) NULL,
	[fechaDevolucion] [datetime] NULL,
	[estadoAuto] [int] NULL,
	[cobroAdicional] [float] NULL,
	[idRentaD] [int] NULL,
	[idEmpleado] [int] NULL,
 CONSTRAINT [PK__Devoluci__BFAF069AAFD81BE1] PRIMARY KEY CLUSTERED 
(
	[idDevolucion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombresEmpleado] [nvarchar](50) NULL,
	[apellidosEmpleado] [nvarchar](50) NULL,
	[telefono] [nvarchar](9) NULL,
	[correo] [nvarchar](50) NULL,
	[estadoEmpleado] [nvarchar](50) NULL,
	[usuario] [nvarchar](50) NULL,
	[contrasenia] [nvarchar](50) NULL,
	[cargo] [nvarchar](20) NULL,
	[privilegio] [int] NULL,
	[DUIEmpleado] [nvarchar](10) NULL,
	[sexo] [int] NULL,
	[direccionEmpleado] [nvarchar](200) NULL,
	[imagenEmpleado] [image] NULL,
 CONSTRAINT [PK__Empleado__5295297CDB9F8304] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Factura]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[idRenta] [int] NULL,
	[idDevolucion] [int] NULL,
	[montoF] [float] NULL,
	[cobroAdicionalF] [float] NULL,
	[montoTotal] [float] NULL,
 CONSTRAINT [PK__Factura__3CD5687E7B8C8C29] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Notify]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notify](
	[Notificacion] [nvarchar](50) NOT NULL
) ON [PRIMARY]

GO
UPDATE STATISTICS [dbo].[Notify] WITH ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Table [dbo].[Privilegio]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Privilegio](
	[idPrivilegio] [int] IDENTITY(1,1) NOT NULL,
	[NomPrivilegio] [nvarchar](50) NULL,
 CONSTRAINT [PK_Privilegio] PRIMARY KEY CLUSTERED 
(
	[idPrivilegio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Renta]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Renta](
	[idRenta] [int] IDENTITY(1,1) NOT NULL,
	[matriculaAutoR] [nvarchar](8) NULL,
	[DUICliente] [nvarchar](10) NULL,
	[fechaEntregaR] [datetime] NULL,
	[fechaDevolucionR] [datetime] NULL,
	[monto] [float] NULL,
	[estadoRenta] [int] NULL,
	[idEmpleado] [int] NULL,
 CONSTRAINT [PK__Renta__8643C7EF41E4AAB4] PRIMARY KEY CLUSTERED 
(
	[idRenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reparacion]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reparacion](
	[idReparacion] [int] IDENTITY(1,1) NOT NULL,
	[idTaller] [int] NULL,
	[matriculaAutoRep] [nvarchar](8) NULL,
	[costo] [float] NULL,
	[descripcionRep] [nvarchar](100) NULL,
	[fechaIngreso] [datetime] NULL,
	[fechaEgreso] [datetime] NULL,
	[motivos] [nvarchar](15) NULL,
 CONSTRAINT [PK__Reparaci__4E5D15A652F13DE0] PRIMARY KEY CLUSTERED 
(
	[idReparacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Taller]    Script Date: 02/06/2018 11:22:39 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taller](
	[idTaller] [int] IDENTITY(1,1) NOT NULL,
	[nomTaller] [nvarchar](50) NULL,
	[dirTaller] [nvarchar](50) NULL,
	[telTaller] [nvarchar](9) NULL,
	[encargadoTaller] [nvarchar](100) NULL,
 CONSTRAINT [PK__Taller__449E029F681D76F6] PRIMARY KEY CLUSTERED 
(
	[idTaller] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ControlRenta]  WITH CHECK ADD  CONSTRAINT [FK_ControlRenta_Devolucion] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[Devolucion] ([idDevolucion])
GO
ALTER TABLE [dbo].[ControlRenta] CHECK CONSTRAINT [FK_ControlRenta_Devolucion]
GO
ALTER TABLE [dbo].[ControlRenta]  WITH CHECK ADD  CONSTRAINT [FK_ControlRenta_Empleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([idEmpleado])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ControlRenta] CHECK CONSTRAINT [FK_ControlRenta_Empleados]
GO
ALTER TABLE [dbo].[ControlRenta]  WITH CHECK ADD  CONSTRAINT [FK_ControlRenta_Renta] FOREIGN KEY([idRenta])
REFERENCES [dbo].[Renta] ([idRenta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ControlRenta] CHECK CONSTRAINT [FK_ControlRenta_Renta]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Autos] FOREIGN KEY([matriculaAutoD])
REFERENCES [dbo].[Autos] ([matricula])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [FK_Devolucion_Autos]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Cliente] FOREIGN KEY([DUICliente])
REFERENCES [dbo].[Cliente] ([DUI])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [FK_Devolucion_Cliente]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Empleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [FK_Devolucion_Empleados]
GO
ALTER TABLE [dbo].[Devolucion]  WITH CHECK ADD  CONSTRAINT [FK_Devolucion_Renta] FOREIGN KEY([idRentaD])
REFERENCES [dbo].[Renta] ([idRenta])
GO
ALTER TABLE [dbo].[Devolucion] CHECK CONSTRAINT [FK_Devolucion_Renta]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Privilegio] FOREIGN KEY([privilegio])
REFERENCES [dbo].[Privilegio] ([idPrivilegio])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Privilegio]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Devolucion] FOREIGN KEY([idDevolucion])
REFERENCES [dbo].[Devolucion] ([idDevolucion])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Devolucion]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Renta] FOREIGN KEY([idRenta])
REFERENCES [dbo].[Renta] ([idRenta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Renta]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Autos] FOREIGN KEY([matriculaAutoR])
REFERENCES [dbo].[Autos] ([matricula])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Autos]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Cliente] FOREIGN KEY([DUICliente])
REFERENCES [dbo].[Cliente] ([DUI])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Cliente]
GO
ALTER TABLE [dbo].[Renta]  WITH CHECK ADD  CONSTRAINT [FK_Renta_Empleados] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[Empleados] ([idEmpleado])
GO
ALTER TABLE [dbo].[Renta] CHECK CONSTRAINT [FK_Renta_Empleados]
GO
ALTER TABLE [dbo].[Reparacion]  WITH CHECK ADD  CONSTRAINT [FK_Reparacion_Autos] FOREIGN KEY([matriculaAutoRep])
REFERENCES [dbo].[Autos] ([matricula])
GO
ALTER TABLE [dbo].[Reparacion] CHECK CONSTRAINT [FK_Reparacion_Autos]
GO
ALTER TABLE [dbo].[Reparacion]  WITH CHECK ADD  CONSTRAINT [FK_Reparacion_Taller] FOREIGN KEY([idTaller])
REFERENCES [dbo].[Taller] ([idTaller])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Reparacion] CHECK CONSTRAINT [FK_Reparacion_Taller]
GO
/****** Object:  StoredProcedure [dbo].[ACT_RENTA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ACT_RENTA]
@idRenta INT, @resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	UPDATE Renta SET estadoRenta = 2 WHERE idRenta = @idRenta
	IF((SELECT estadoRenta FROM Renta WHERE idRenta = @idRenta) = 2)
	BEGIN
		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[Actualizar_Usuario]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Actualizar_Usuario] 
@usuario nvarchar(50),
@nContra nvarchar(50),
@correo nvarchar(100),
@direccion nvarchar(200),
@telefono nvarchar(9)
as
begin
	update empleados set usuario = @Usuario, contrasenia = @nContra, correo = @correo, direccionEmpleado = @direccion, telefono = @telefono
	where usuario = @usuario
end


GO
/****** Object:  StoredProcedure [dbo].[Add_Usuario]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Add_Usuario] @Dui nvarchar(10), @nombres nvarchar(50), @apellidos nvarchar (50), @sexo int, @direccion nvarchar(200),
@telefono nvarchar(9), @cargo nvarchar(20), @privilegio int, @correo nvarchar(50), @contra nvarchar(50), @usuario nvarchar(50), @imagenEmp image, @estado int
as
begin
	if not exists (select * from empleados where DUIEmpleado = @Dui)
	insert into Empleados (nombresEmpleado, apellidosEmpleado, telefono, correo, usuario, contrasenia, cargo, privilegio, DUIEmpleado, sexo, direccionEmpleado, imagenEmpleado, estadoEmpleado)
	values (@nombres, @apellidos, @telefono, @correo, @usuario, @contra, @cargo, @privilegio, @Dui, @sexo, @direccion, @imagenEmp, @estado)
end

GO
/****** Object:  StoredProcedure [dbo].[AGG_AUTOS]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AGG_AUTOS]
@matricula NVARCHAR(8), @marca NVARCHAR(50), @modelo NVARCHAR(50),
@color NVARCHAR(20), @anio NVARCHAR(4), @tipo NVARCHAR(20),
@capacidad INT, @imagenAuto IMAGE, @montoRenta FLOAT,
@adquiridoA NVARCHAR(100), @fechaAdqui DATETIME, @observaciones NVARCHAR(MAX),
@resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	IF (NOT EXISTS(SELECT * FROM Autos WHERE matricula=@matricula))
	BEGIN
		INSERT INTO Autos(matricula, marca, modelo, color, anio, tipo, capacidad, estadoAuto,
		imagenAuto, montoRenta, adquiridoA, fechaAdquisicion, observacionesAuto)
		VALUES (@matricula, @marca, @modelo, @color, @anio, @tipo, @capacidad, 1,
		@imagenAuto, @montoRenta, @adquiridoA, @fechaAdqui, @observaciones)

		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[AGGAUTOS_TALLER]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AGGAUTOS_TALLER]
@idTaller INT, @matriculaARep NVARCHAR(8), @motivos NVARCHAR(15),
@descripcion NVARCHAR(100), @fechaIngreso DATETIME, @resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	DECLARE @operacion INT, @valor1 INT, @valor2 INT
	SET @operacion = 1
	IF (@operacion = 1)
	BEGIN

	SELECT @valor1 = COUNT(*) FROM Reparacion  
	

	INSERT INTO Reparacion(idTaller, matriculaAutoRep, descripcionRep, fechaIngreso, motivos)
	VALUES (@idTaller, @matriculaARep, @descripcion, @fechaIngreso, @motivos)

	SELECT @valor2 = COUNT(*) FROM Reparacion  
	END

	IF (@operacion = 1)
	BEGIN
	UPDATE Autos SET estadoAuto = 3 WHERE matricula = @matriculaARep
	END
	
	IF((SELECT estadoAuto FROM Autos WHERE matricula = @matriculaARep) = 3 AND @valor1<@valor2)
	BEGIN
		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[Agregar_ClienteSP]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[Agregar_ClienteSP]
 @dui nvarchar(50),
 @Nombres nvarchar(50),
 @APELLIDO nvarchar(50),
 @edad int,
 @nLicencia nvarchar(40),
 @DIR nvarchar(50),
 @tel nvarchar(50)

 as 
 begin 
  
  if not exists (select * from Cliente where DUI = UPPER(@dui))
  
   insert into Cliente (DUI,nombresCliente,apellidosCliente,edadCliente,nLicencia,dirCliente,telCliente)
   values (@dui,@Nombres,@APELLIDO,@edad,@nLicencia,@DIR,@tel)

   end


GO
/****** Object:  StoredProcedure [dbo].[Alterar_Renta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Alterar_Renta]
@idFac int,
@matricula nvarchar(8),
@DUI nvarchar(10),
@fecha1 date,
@fecha2 date,
@monto nvarchar (50)
as 
begin
update Renta set DUICliente = @DUI , matriculaAutoR = @matricula, fechaEntregaR = @fecha1, fechaDevolucionR = @fecha2 , monto = @monto Where idRenta = @idFac
update Factura set  montoTotal=@monto where idFactura=@idFac
SELECT idFactura ,DUICliente,matriculaAutoR,fechaEntregaR,fechaDevolucionR,monto,estadoRenta from 
Factura inner join Renta on Factura.idRenta = Renta.idRenta 
end

GO
/****** Object:  StoredProcedure [dbo].[CON_DatosRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CON_DatosRenta]
@idRenta INT
AS
BEGIN
	SELECT Renta.matriculaAutoR, Renta.DUICliente, Renta.fechaEntregaR,
	Renta.fechaDevolucionR, Renta.monto, Autos.marca, Autos.modelo,
	Autos.color, Autos.anio, Autos.imagenAuto,
	(Cliente.nombresCliente +' '+ Cliente.apellidosCliente) AS NomCompleto
	FROM Renta INNER JOIN Autos ON Renta.matriculaAutoR = Autos.matricula
	INNER JOIN Cliente ON Renta.DUICliente = Cliente.DUI
	WHERE idRenta = @idRenta
END

GO
/****** Object:  StoredProcedure [dbo].[CON_FACTURA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CON_FACTURA]
AS
BEGIN
	SELECT idRenta,matriculaAutoR,DUICliente,fechaEntregaR,fechaDevolucionR,monto FROM Renta WHERE estadoRenta = 1
END

GO
/****** Object:  StoredProcedure [dbo].[CONS_TALLERES]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[CONS_TALLERES]
AS
BEGIN
	SELECT idTaller, nomTaller FROM Taller
END

GO
/****** Object:  StoredProcedure [dbo].[DEVOLVER_AUTO]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEVOLVER_AUTO]
@matricula VARCHAR(8), @estadoAuto int, @descEstadoAuto NVARCHAR(MAX),
@resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	UPDATE Autos SET estadoAuto = @estadoAuto, descEstadoAuto = @descEstadoAuto
	WHERE matricula = @matricula
	IF((SELECT estadoAuto FROM Autos WHERE matricula = @matricula) = @estadoAuto)
	BEGIN
		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[ELIM_AUTOS]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIM_AUTOS]
@matricula NVARCHAR(8), @motivos NVARCHAR(MAX), @resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	UPDATE Autos SET estadoAuto = 4, descEstadoAuto = @motivos WHERE matricula = @matricula
	IF((SELECT estadoAuto FROM Autos WHERE matricula = @matricula) = 4)
	BEGIN
		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[Eliminar_auto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Eliminar_auto]
@auto nvarchar(10),
@fecha_egreso date,
@monto float,
@observaciones nvarchar(200)
as
begin
	if exists(select * from Reparacion 
	where matriculaAutoRep = @auto)
	update Reparacion set fechaEgreso = @fecha_egreso,
	costo = @monto
	where matriculaAutoRep = @auto and @fecha_egreso >= fechaIngreso
	update Autos set observacionesAuto = @observaciones
	where matricula = @auto
end



GO
/****** Object:  StoredProcedure [dbo].[EnviarContra]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EnviarContra]
@correo nvarchar(100),
@contra nvarchar(100) output
as
	if exists(select * from empleados where correo = @correo)
	
begin
	select @contra = contrasenia from Empleados
	return
end

GO
/****** Object:  StoredProcedure [dbo].[evaluarExiste]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[evaluarExiste]
@correo nvarchar(100),
@mensaje varchar(100) output
as
	if not exists(select * from empleados where correo = @correo)
	begin
	(select @mensaje = 'Correo no existe')
	return 
end 

GO
/****** Object:  StoredProcedure [dbo].[Filtrar_ClienteSP]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[Filtrar_ClienteSP]
@Ape nvarchar(50)
as 
begin 

select * from Cliente where apellidosCliente like @Ape + '%'

end


GO
/****** Object:  StoredProcedure [dbo].[GenerarReporte]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GenerarReporte]
@fechaI date,
@fechaII date
as 
begin

 SELECT  idRenta,matriculaAutoR,DUICliente,fechaEntregaR,fechaDevolucionR,monto,estadoRenta,nombresCliente,apellidosCliente       
FROM            dbo.Renta INNER JOIN
                         dbo.Cliente ON dbo.Renta.DUICliente = dbo.Cliente.DUI
						 where fechaEntregaR between @fechaI and @fechaII

 end

GO
/****** Object:  StoredProcedure [dbo].[GenerarTicketK]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create procedure [dbo].[GenerarTicketK]
as 
begin

 SELECT top(1) idRenta,matriculaAutoR,DUICliente,fechaEntregaR,monto,estadoRenta,nombresCliente,apellidosCliente   
FROM            dbo.Renta INNER JOIN
                         dbo.Cliente ON dbo.Renta.DUICliente = dbo.Cliente.DUI 
						order by idRenta desc




 end
GO
/****** Object:  StoredProcedure [dbo].[IN_DEVOLUCION]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[IN_DEVOLUCION]
@idRentaD int, @matriculaAD nvarchar(8), @DUI_CAD nvarchar(10),
@fechaDevolucion DATE, @estadoAuto INT, @cobroAD float,
@resultado NVARCHAR(1) OUTPUT
AS
BEGIN
	DECLARE @valor1 INT, @valor2 INT

	SELECT @valor1 = COUNT(*) FROM Devolucion

	INSERT INTO Devolucion(matriculaAutoD, DUICliente, fechaDevolucion, estadoAuto, cobroAdicional, idRentaD)
	VALUES (@matriculaAD, @DUI_CAD, @fechaDevolucion, @estadoAuto, @cobroAD, @idRentaD)

	SELECT @valor2 = COUNT(*) FROM Devolucion

	IF(@valor1<@valor2)
	BEGIN
		SET @resultado = '1'
	END
	ELSE
	BEGIN
		SET @resultado = '0'
	END
END

GO
/****** Object:  StoredProcedure [dbo].[Inicio_SesionSP]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  

   create procedure [dbo].[Inicio_SesionSP]
    @User nvarchar(40),
	@Contra nvarchar(40)
	as 
	begin 

	select usuario, contrasenia,privilegio,nombresEmpleado FROM Empleados WHERE usuario = @User and contrasenia = @Contra
	end


GO
/****** Object:  StoredProcedure [dbo].[LIST_FACTURA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LIST_FACTURA] 
AS 
BEGIN 
SELECT idFactura ,DUICliente,matriculaAutoR,fechaEntregaR,fechaDevolucionR,montoTotal,estadoRenta from 
Factura inner join Renta on Factura.idRenta = Renta.idRenta 
end

GO
/****** Object:  StoredProcedure [dbo].[List_RentaSP]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
crEATE procedure [dbo].[List_RentaSP]
as 
begin 

select * from Renta
end

GO
/****** Object:  StoredProcedure [dbo].[Listar_UsuarioSP]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE procedure [dbo].[Listar_UsuarioSP]

	as
	begin
	SELECT *  FROM Cliente
	end
	

GO
/****** Object:  StoredProcedure [dbo].[SP_ActEstadoAuto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ActEstadoAuto]
@param int,
@matr nvarchar(50)
	AS
BEGIN
	
	SET NOCOUNT ON;
	UPDATE Autos SET estadoAuto = @param WHERE matricula = @matr
END


GO
/****** Object:  StoredProcedure [dbo].[SP_AutoTicketRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_AutoTicketRenta]
	@matricula nvarchar(50)
AS
BEGIN
	SELECT a.tipo,a.marca,a.modelo FROM Autos as a WHERE matricula = @matricula
END

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarMatricula]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarMatricula]
	@matricula nvarchar(50),
	@tipo nvarchar(50),
	@marca nvarchar(50),
	@modelo nvarchar(50),
	@color nvarchar(50)
AS
BEGIN
	IF @tipo = 'Tipo' AND @marca = 'Marca' AND @modelo = '' AND @color = ''
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE matricula 
		like '%'+ @matricula+ '%'
	ELSE IF @tipo != 'Tipo' AND @marca = 'Marca' AND @modelo = '' AND @color = '' 
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE matricula 
		like '%'+ @matricula+ '%' AND tipo = @tipo
	ELSE IF  @tipo != 'Tipo' AND @marca != 'Marca' AND @modelo = '' AND @color = ''  
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE matricula 
		like '%'+ @matricula+ '%' AND tipo = @tipo AND marca = @marca 
	ELSE IF @tipo != 'Tipo' AND @marca != 'Marca' AND @modelo != '' AND @color = ''  
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE matricula 
		like '%'+ @matricula+ '%' AND tipo = @tipo AND marca = @marca AND modelo = @modelo
	ELSE
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE matricula 
		like '%'+ @matricula+ '%' AND tipo = @tipo AND marca = @marca AND modelo = @modelo AND color = @color
END


GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarTaller]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_BuscarTaller]
	@nombre nvarchar(50)
AS
BEGIN
	SELECT * FROM Taller WHERE nomTaller like '%'+@nombre+'%'
END


GO
/****** Object:  StoredProcedure [dbo].[SP_ClinteTicketRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ClinteTicketRenta]
	@cliente nvarchar(50)
AS
BEGIN
	SELECT nombresCliente,apellidosCliente FROM Cliente WHERE DUI = @cliente
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ConsultarTaller]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ConsultarTaller]
AS
BEGIN
	SELECT * FROM Taller 
END

/****** Object:  StoredProcedure [dbo].[SP_EliminarTaller]    Script Date: 18/05/2018 03:51:13 p. m. ******/
SET ANSI_NULLS ON

GO
/****** Object:  StoredProcedure [dbo].[SP_egresarTaller]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_egresarTaller] 
	@matricula nvarchar(50),
	@fechaEgreso datetime,
	@motivos nvarchar(50),
	@monto float
AS
BEGIN
	UPDATE Reparacion SET costo = @monto,fechaEgreso = @fechaEgreso,motivos =@motivos WHERE matriculaAutoRep = @matricula
END

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarTaller]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EliminarTaller]
	@nombre nvarchar(50),
	@result varchar(1) OUTPUT
AS
BEGIN
	IF EXISTS(SELECT nomTaller FROM Taller WHERE nomTaller = @nombre)
	BEGIN
		DELETE FROM Taller WHERE nomTaller = @nombre
		SET @result = '1'
	END
	ELSE
	BEGIN
		SET @result = '0'
	END
END


GO
/****** Object:  StoredProcedure [dbo].[SP_EmpleadoTicketRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EmpleadoTicketRenta]
	@user nvarchar(50)
AS
BEGIN
	SELECT nombresEmpleado,apellidosEmpleado FROM Empleados WHERE usuario = @user
END
GO
/****** Object:  StoredProcedure [dbo].[SP_EspecificacionAutos]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EspecificacionAutos]
@matricula nvarchar(50)
AS
BEGIN
	SELECT marca,modelo,color,anio,montoRenta FROM Autos WHERE matricula = @matricula
END


GO
/****** Object:  StoredProcedure [dbo].[SP_EstadoAuto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EstadoAuto]
	@matricula nvarchar(50)
AS
BEGIN
	UPDATE Autos SET estadoAuto = 2 WHERE matricula = @matricula
END

GO
/****** Object:  StoredProcedure [dbo].[SP_EstadoUsuario]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_EstadoUsuario]
	@usuario nvarchar(50)
AS
BEGIN
	UPDATE Empleados SET estadoEmpleado = 2 WHERE idEmpleado = @usuario
END

GO
/****** Object:  StoredProcedure [dbo].[SP_extraerIdRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_extraerIdRenta]
AS
BEGIN
	SELECT idRenta FROM Renta ORDER BY idRenta DESC
END

GO
/****** Object:  StoredProcedure [dbo].[SP_ImagenRenta]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ImagenRenta]
@matricula NVARCHAR(8)
AS
BEGIN
	SELECT imagenAuto FROM Autos WHERE matricula = @matricula
END

GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarTaller]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertarTaller]
	@nombre nvarchar(50),
	@Encargado nvarchar(100),
	@dir nvarchar(50),
	@tel nvarchar(9),
	@result varchar(1) OUTPUT
AS
BEGIN
	IF NOT EXISTS(SELECT nomTaller FROM Taller WHERE nomTaller = @nombre)
		BEGIN
			INSERT INTO Taller(nomTaller,dirTaller,telTaller,encargadoTaller) VALUES(@nombre,@dir,@tel,@Encargado)
			SET @result = '1'
		END
	ELSE
		BEGIN
			SET @result = '0'
		END
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertCliente]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertCliente]
	@dui nvarchar(50),
	@nombre nvarchar(50),
	@apel nvarchar(50),
	@edad int,
	@lic nvarchar(50),
	@dir nvarchar(50),
	@tel nvarchar(50),
	@result varchar(1) OUTPUT
AS
BEGIN
	IF NOT EXISTS(SELECT dui FROM Cliente WHERE dui = @dui )
		BEGIN
			INSERT INTO Cliente(DUI,nombresCliente,apellidosCliente,edadCliente,nLicencia,dirCliente,telCliente) 
			VALUES(@dui,@nombre,@apel,@edad,@lic,@dir,@tel)

			SET @result = '1'
		END
	ELSE
		BEGIN
			SET @result = '0'
		END
END


GO
/****** Object:  StoredProcedure [dbo].[SP_InsertRentaAuto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_InsertRentaAuto]
	@matricula nvarchar(50),
	@Dui nvarchar(50),
	@fecha1 datetime,
	@fecha2 datetime,
	@monto float,
	@estadoRenta int
AS
BEGIN
	INSERT INTO Renta(matriculaAutoR,DUICliente,fechaEntregaR,fechaDevolucionR,monto,estadoRenta) 
	VALUES(@matricula,@Dui,@fecha1,@fecha2,@monto,@estadoRenta)
END


GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarCliente]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_ModificarCliente]
	-- Add the parameters for the stored procedure here
	@Dui nvarchar(10), 
	@nombreClientes nvarchar(50),
	@apellidoCliente nvarchar(50),
	@edadCliente int,
	@nLicencia nvarchar (17),
	@dirCliente nvarchar (100),
	@telCliente nvarchar(9)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update Cliente set nombresCliente = @nombreClientes, apellidosCliente = @apellidoCliente,
	edadCliente = @edadCliente, @nLicencia = @nLicencia, dirCliente = @dirCliente, telCliente = @telCliente where DUI = @Dui


END


GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionarAuto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeleccionarAuto]
@param int
	AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE estadoAuto = @param
END


GO
/****** Object:  StoredProcedure [dbo].[SP_SeleccionAutoFiltros]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SeleccionAutoFiltros] 
@estado int,
	@tipo nvarchar(50),
	@marca nvarchar(50),
	@modelo nvarchar(50),
	@color nvarchar(50)
AS
BEGIN
	IF @tipo != 'Tipo' AND @marca = 'Marca' AND @modelo = '' AND @color = ''
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE tipo = @tipo AND estadoAuto =@estado
	ELSE IF @tipo != 'Tipo' AND @marca != 'Marca' AND @modelo = '' AND @color = ''
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE tipo = @tipo AND marca = @marca AND estadoAuto =@estado
	ELSE IF @tipo != 'Tipo' AND @marca != 'Marca' AND @modelo != '' AND @color = ''
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE tipo = @tipo AND marca = @marca 
			AND modelo = @modelo AND estadoAuto =@estado
	ELSE
		SELECT matricula,marca,modelo,color,tipo,montoRenta,capacidad FROM Autos WHERE tipo = @tipo AND marca = @marca 
			AND modelo = @modelo AND color = @color AND estadoAuto =@estado
END

GO
/****** Object:  StoredProcedure [dbo].[SP_TarifaAuto]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TarifaAuto] 
	@matricula nvarchar(50)
AS
BEGIN
	SELECT montoRenta FROM Autos WHERE matricula = @matricula
END

GO
/****** Object:  StoredProcedure [dbo].[Sp_TicketDev]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create procedure [dbo].[Sp_TicketDev]
 @idrenta int 
 as 
 begin
 SELECT top(1) idRenta,matriculaAutoR,DUICliente,fechaEntregaR,fechaDevolucionR,monto,estadoRenta,nombresCliente,apellidosCliente   
FROM            dbo.Renta INNER JOIN
                         dbo.Cliente ON dbo.Renta.DUICliente = dbo.Cliente.DUI 
						 where idRenta = @idrenta
						order by idRenta desc
 end
GO
/****** Object:  StoredProcedure [dbo].[validaActualizacion]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[validaActualizacion]
@usuario nvarchar(100),
@usua nvarchar(1) output
as
begin
	if exists(select * from empleados where usuario = @usuario)
	begin
		set @usua = '1'
	end
	else
	begin
		set @usua = '2'
	end
end

GO
/****** Object:  StoredProcedure [dbo].[validarUsuario]    Script Date: 02/06/2018 11:22:40 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[validarUsuario]
@usuario nvarchar(100),
@usua nvarchar(1) output
as
begin
	if exists(select * from empleados where usuario = @usuario)
	begin
		set @usua = '1'
	end
	else
	begin
		set @usua = '2'
	end
end

GO
/****** Object:  Statistic [_WA_Sys_00000002_0F975522]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000002_0F975522] ON [dbo].[Autos]([marca]) WITH STATS_STREAM = 0x01000000010000000000000000000000E3CAAB07000000000904000000000000C903000000000000E7020000E7000000640000000000000028D00000000000000700000056E57F01E6A800001D000000000000001D0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A0000000100000010000000734F23410000E84100000000734F2341000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000A00100000000000055020000000000005D0200000000000050000000000000006F000000000000008C00000000000000AB00000000000000CC00000000000000F1000000000000000E010000000000002F010000000000005A010000000000007D010000000000003000100000008040000000000000803F04000001001F0041007500640069003000100000000040000000000000803F04000001001D0042004D0057003000100000008040000000000000803F04000001001F0046006F0072006400300010000000A040000000000000803F0400000100210048006F006E00640061003000100000008040000000000000803F040000010025004800790075006E00640061006900300010000000803F000000000000803F04000001001D004B00690061003000100000008040000000000000803F040000010021004D0061007A0064006100300010000000803F000000000000803F04000001002B004D00690074007300750062006900730068006900300010000000803F000000000000803F040000010023004E0069007300730061006E003000100000004040000000000000803F0400000100230054006F0079006F0074006100FF01000000000000000B00000008000000280000002800000000000000000000002A000000410075006400690046006F007200640048006F006E0064006100790075006E006400610069004B00690061004D0061007A006400610069007400730075006200690073006800690054006F0079006F00740061000B000000400000000082040000008204040000C001080000820409000001060D00008103130000C001160000810417000001091B00000106240000001D00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000003_0F975522]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_0F975522] ON [dbo].[Autos]([modelo]) WITH STATS_STREAM = 0x01000000010000000000000000000000CEC0A9A200000000F106000000000000B106000000000000E7020023E7000000640000000000000028D00000000000400700000058E57F01E6A800001D000000000000001D000000000000000000803F8C2E3A3D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000140000001400000001000000100000004F239C410000E841000000004F239C4100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001300000000000000000000000000000004040000000000003D050000000000004505000000000000A000000000000000C300000000000000EE000000000000001B01000000000000500100000000000079010000000000009801000000000000B701000000000000E8010000000000001F0200000000000056020000000000008B02000000000000B002000000000000E7020000000000002003000000000000470300000000000076030000000000009103000000000000B803000000000000E903000000000000300010000000803F000000000000803F0400000100230041006300630065006E007400300010000000803F000000000000803F04000001002B004100630063006F0072006400200032002E003000300010000000803F000000000000803F04000001002D004100630063006F0072006400200032002E0030006900300010000000803F000000000000803F0400000100350043006900760069006300200031002E0034002000530070006F0072007400300010000000803F000000000000803F0400000100290043006900760069006300200031002E003800300010000000803F000000000000803F04000001001F00430052002D0056003000100000000040000000000000803F04000001001F00430058002D0035003000100000000040000000000000803F0400000100310045006C0061006E007400720061002000530070006F0072007400300010000000803F000000000000803F04000001003700480069006C0075007800200044006F00750062006C0065002000430061006200300010000000803F000000000000803F040000010037004C0061006E006300650072002000530070006F00720074006200610063006B00300010000000803F000000000000803F040000010035004C0061006E006400200043007200750069007300650072002000560038003000100000000040000000000000803F040000010025004D0061007A0064006100200033003000100000000040000000000000803F040000010037004D0075007300740061006E006700200046006100730074006200610063006B00300010000000803F000000000000803F040000010039004E0061007600610072006100200044006F00750062006C0065002000430061006200300010000000803F000000400000803F040000010027005200410056003400200032002E0030003000100000000040000000000000803F04000001002F005300330020004C0069006D006F007500730069006E006500300010000000803F000000000000803F04000001001B0053003400300010000000803F000000000000803F04000001002700530061006E00740061002000460065003000100000000040000000000000803F040000010031005400720061006E0073006900740020004B006F006D00620069003000100000000040000000000000803F04000001001B0058003400FF01000000000000000B0000000B000000280000002800000000000000000000006200000041006300630065006E00740043006900760069006300200031002E0034002000530070006F007200740058002D00350045006C0061006E007400720061002000530070006F00720074004C0061006E006300650072002000530070006F00720074006200610063006B004D0061007A00640061002000330075007300740061006E006700200046006100730074006200610063006B00520038005300330020004C0069006D006F007500730069006E00650061006E0074006100200046006500580034000F00000040000000008106000000C001060000810E0700000103150000810D1800008110250000C0013500008106360000010F3C000081024B0000C0014D0000810B4E000001075900000102600000001D00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000004_0F975522]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000004_0F975522] ON [dbo].[Autos]([color]) WITH STATS_STREAM = 0x0100000001000000000000000000000075C3FF37000000001C03000000000000DC02000000000000E7020061E7000000280000000000000028D00000006500720700000060E57F01E6A800001D000000000000001D0000000000000000000000ABAA2A3E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006000000060000000100000010000000B1DC13410000E84100000000B1DC1341000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000F2000000000000006801000000000000700100000000000030000000000000004F0000000000000072000000000000009100000000000000B200000000000000D300000000000000300010000000A040000000000000803F04000001001F0041007A0075006C00300010000000A040000000000000803F0400000100230042006C0061006E0063006F003000100000008040000000000000803F04000001001F004700720069007300300010000000E040000000000000803F040000010021004E006500670072006F00300010000000803F000000000000803F0400000100210050006C00610074006100300010000000E040000000000000803F04000001001F0052006F006A006F00FF01000000000000000B00000005000000280000002800000000000000000000001700000041007A0075006C0042006C0061006E0063006F0047007200690073004E006500670072006F0052006F006A006F000600000040000000008204000000820604000081040A000083050E00000304130000001D00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000006_0F975522]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000006_0F975522] ON [dbo].[Autos]([tipo]) WITH STATS_STREAM = 0x010000000100000000000000000000002991AA1400000000BB030000000000007B03000000000000E7020000E7000000280000000000000028D00000000000000700000055E57F01E6A800001D000000000000001D0000000000000000000000ABAA2A3E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000006000000060000000100000010000000F734D2410000E84100000000F734D2410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000003A0100000000000007020000000000000F02000000000000300000000000000069000000000000009200000000000000B700000000000000F0000000000000001D010000000000003000100000004040000000000000803F0400000100390043006F0075007000E9002000280032002000700075006500720074006100730029003000100000000040000000000000803F04000001002900480061007400630068006200610063006B003000100000000040000000000000803F040000010025005000690063006B002D00550070003000100000004041000000000000803F04000001003900530065006400E1006E002000280034002000500075006500720074006100730029003000100000000041000000000000803F04000001002D0054006F0064006F00740065007200720065006E006F003000100000000040000000000000803F04000001001D00560061006E00FF01000000000000000B00000006000000280000002800000000000000000000004000000043006F0075007000E900200028003200200070007500650072007400610073002900480061007400630068006200610063006B005000690063006B002D0055007000530065006400E1006E0020002800340020005000750065007200740061007300290054006F0064006F00740065007200720065006E006F00560061006E000700000040000000008111000000810911000081071A00008411210000830B32000001033D0000001D00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000008_0F975522]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000008_0F975522] ON [dbo].[Autos]([estadoAuto]) WITH STATS_STREAM = 0x010000000100000000000000000000006CE0BAA700000000CB010000000000008B01000000000000380200103800000004000A00000000000000000001001D00070000000CDF7F01E6A800001D000000000000001D00000000000000000000000000803F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000010000000100000014000000000080400000E84100000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000001F0000000000000027000000000000000800000000000000100014000000E841000000000000803F010000000400001D00000000000000
GO
/****** Object:  Statistic [PK__Autos__30962D1415502753]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Autos]([PK__Autos__30962D1415502753]) WITH STATS_STREAM = 0x01000000010000000000000000000000832BC7C200000000B7070000000000007707000000000000E7030000E7000000100000000000000028D000000100000007000000ECA97601E6A800001D000000000000001D000000000000000000803FCB3D0D3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001B0000001B0000000100000010000000000080410000E8410000000000008041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000F50400000000000003060000000000000B06000000000000D800000000000000FF0000000000000026010000000000004D0100000000000074010000000000009B01000000000000C201000000000000E901000000000000100200000000000037020000000000005E020000000000008502000000000000AC02000000000000D302000000000000FA02000000000000210300000000000048030000000000006F030000000000009603000000000000BD03000000000000E4030000000000000B04000000000000320400000000000059040000000000008004000000000000A704000000000000CE04000000000000300010000000803F000000000000803F0400000100270050003100390032002D00320035003800300010000000803F000000000000803F0400000100270050003300340036002D00350038003600300010000000803F000000000000803F0400000100270050003400350036002D00310035003900300010000000803F000000000000803F0400000100270050003400360035002D00340034003500300010000000803F000000000000803F0400000100270050003400390031002D00390037003900300010000000803F000000000000803F0400000100270050003500300037002D00380031003600300010000000803F000000000000803F0400000100270050003500390033002D00370034003400300010000000803F000000000000803F0400000100270050003500390035002D00300039003300300010000000803F000000000000803F0400000100270050003600300030002D00310036003500300010000000803F000000000000803F0400000100270050003600300030002D00320035003300300010000000803F000000000000803F0400000100270050003600300030002D00320038003600300010000000803F000000000000803F0400000100270050003600350030002D00380036003400300010000000803F000000000000803F0400000100270050003600380032002D00320030003800300010000000803F000000000000803F0400000100270050003600380038002D00380034003400300010000000803F000000000000803F0400000100270050003600390030002D00340034003700300010000000803F000000000000803F0400000100270050003700310030002D00320038003000300010000000803F000000000000803F0400000100270050003700360031002D00390031003900300010000000803F000000000000803F0400000100270050003800330039002D00340039003400300010000000803F000000000000803F0400000100270050003800340035002D00350031003300300010000000803F000000000000803F0400000100270050003800380032002D00340032003000300010000000803F000000000000803F0400000100270050003800380037002D00330032003900300010000000803F000000000000803F0400000100270050003800390030002D00300035003000300010000000803F000000000000803F0400000100270050003800390038002D00380037003700300010000000803F000000000000803F0400000100270050003900300036002D00370030003400300010000000803F000000400000803F0400000100270050003900350033002D00300038003800300010000000803F000000000000803F0400000100270050003900360038002D00320037003900300010000000803F000000000000803F0400000100270050003900390036002D00320036003400FF01000000000000000B0000000B000000280000002800000000000000000000004A00000050003100390032002D003200350038003400360035002D003400340035003500390033002D003700340034003600300030002D00310036003500350030002D00380036003400390030002D003400340037003700360031002D003900310039003800380032002D00340032003000390038002D003800370037003900320034002D00320038003700360038002D0032003700390010000000400000000040010000008107010000810708000081070F0000C001160000810617000081061D000001062300008107290000C0013000008106310000010637000040013D000081063E00000106440000001D00000000000000, ROWCOUNT = 30, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000003_117F9D94]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_117F9D94] ON [dbo].[Cliente]([apellidosCliente]) WITH STATS_STREAM = 0x01000000010000000000000000000000696CC5060000000097020000000000005702000000000000E7020000E7000000640000000000000028D0000027005000070000007FF47F01E6A8000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000D84100000040000000000000D8410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000007400000000000000E300000000000000EB0000000000000010000000000000004300000000000000300010000000803F000000000000803F0400000100330050006500720065007A002000510075006900F1006F006E0065007300300010000000803F000000000000803F0400000100310052006900760061007300200052006F00730061006C0065007300FF01000000000000000200000002000000280000002800000000000000000000001B00000050006500720065007A002000510075006900F1006F006E006500730052006900760061007300200052006F00730061006C0065007300030000004000000000810E000000010D0E0000000200000000000000
GO
/****** Object:  Statistic [PK__Cliente__C03671B801232056]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Cliente]([PK__Cliente__C03671B801232056]) WITH STATS_STREAM = 0x010000000100000000000000000000003FAF5EAE000000007B020000000000003B02000000000000E7030000E7000000140000000000000028D0000000000000070000000BAA7601E6A8000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000A04100000040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000006600000000000000C700000000000000CF0000000000000010000000000000003B00000000000000300010000000803F000000000000803F04000001002B00320036003400380039003300360035002D003900300010000000803F000000000000803F04000001002B00330034003600380038003900320033002D003900FF010000000000000002000000020000002800000028000000000000000000000014000000320036003400380039003300360035002D003900330034003600380038003900320033002D003900030000004000000000810A000000010A0A0000000200000000000000, ROWCOUNT = 11, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK__ControlR__04CAF3C900D39005]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[ControlRenta]([PK__ControlR__04CAF3C900D39005]) WITH STATS_STREAM = 0x01000000010000000000000000000000ED0358EE0000000040000000000000000000000000000000380300003800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [_WA_Sys_00000002_15502E78]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000002_15502E78] ON [dbo].[Devolucion]([matriculaAutoD]) WITH STATS_STREAM = 0x010000000100000000000000000000006EB495CD000000006E020000000000002E02000000000000E702E868E7000000100000000000000028D000000000000007000000F6A97601E6A8000002000000000000000200000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000010000000000080410000004000000000000080410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000005E00000000000000BA00000000000000C20000000000000010000000000000003700000000000000300010000000803F000000000000803F0400000100270050003100390032002D00320035003800300010000000803F000000000000803F0400000100270050003400350036002D00310035003900FF01000000000000000200000002000000280000002800000000000000000000000F00000050003100390032002D003200350038003400350036002D00310035003900040000004000000000400100000081070100000107080000000200000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000003_15502E78]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_15502E78] ON [dbo].[Devolucion]([DUICliente]) WITH STATS_STREAM = 0x010000000100000000000000000000006DB4DDCD000000007B020000000000003B02000000000000E7020000E7000000140000000000000028D0000002000000070000000DAA7601E6A8000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000A04100000040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000006600000000000000C700000000000000CF0000000000000010000000000000003B00000000000000300010000000803F000000000000803F04000001002B00320036003400380039003300360035002D003900300010000000803F000000000000803F04000001002B00330034003600380038003900320033002D003900FF010000000000000002000000020000002800000028000000000000000000000014000000320036003400380039003300360035002D003900330034003600380038003900320033002D003900030000004000000000810A000000010A0A0000000200000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000007_15502E78]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000007_15502E78] ON [dbo].[Devolucion]([idRentaD]) WITH STATS_STREAM = 0x010000000100000000000000000000003FF6277A00000000EA01000000000000AA01000000000000380200003800000004000A00000000000000000000000000070000001AAA7601E6A8000002000000000000000200000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000014000000000080400000004000000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000003E00000000000000460000000000000010000000000000002700000000000000100014000000803F000000000000803FEC030000040000100014000000803F000000000000803FED0300000400000200000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000008_15502E78]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000008_15502E78] ON [dbo].[Devolucion]([idEmpleado]) WITH STATS_STREAM = 0x010000000100000000000000000000008294B56200000000A401000000000000640100000000000038020A023800000004000A000000000000000000010000000700000015AA7601E6A8000002000000000000000200000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000140000000000000000000040000000400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000008000000000000000200000000000000
GO
/****** Object:  Statistic [PK__Devoluci__BFAF069AAFD81BE1]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Devolucion]([PK__Devoluci__BFAF069AAFD81BE1]) WITH STATS_STREAM = 0x01000000010000000000000000000000ED0358EE0000000040000000000000000000000000000000380300003800000004000A00000000000000000000000000, ROWCOUNT = 11, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000002_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000002_173876EA] ON [dbo].[Empleados]([nombresEmpleado]) WITH STATS_STREAM = 0x010000000100000000000000000000006276B81600000000E304000000000000A304000000000000E702E868E7000000640000000000000028D000000100000007000000BDCC7900E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A0000000100000010000000CDCCBC410000204100000000CDCCBC4100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001300000000000000000000000000000022020000000000002F03000000000000370300000000000050000000000000007B00000000000000AA00000000000000D7000000000000000A01000000000000370100000000000064010000000000009101000000000000C801000000000000F901000000000000300010000000803F000000000000803F04000001002B0041004E0041002000490053004100420045004C00300010000000803F000000000000803F04000001002F004A004F0053004500200041004E0054004F004E0049004F00300010000000803F000000000000803F04000001002D004A004F005300450020004300410052004C004F005300300010000000803F000000000000803F040000010033004A004F005300450020004600520041004E0043004900530043004F00300010000000803F000000000000803F04000001002D004A004F005300450020004D0041004E00550045004C00300010000000803F000000000000803F04000001002D004A00550041004E0020004300410052004C004F005300300010000000803F000000000000803F04000001002D004A00550041004E0020004D0041004E00550045004C00300010000000803F000000000000803F040000010037004D004100520049004100200043004F004E00430045005000430049004F004E00300010000000803F000000000000803F040000010031004D004100520049004100200044004F004C004F00520045005300300010000000803F000000000000803F040000010029004D00410052004900410020004D0041005200FF01000000000000000A0000000A000000280000002800000000000000000000004C00000041004E0041002000490053004100420045004C004A004F0053004500200041004E0054004F004E0049004F004300410052004C004F0053004600520041004E0043004900530043004F004D0041004E00550045004C00550041004E0020004300410052004C004F0053004D004100520049004100200043004F004E00430045005000430049004F004E0044004F004C004F005200450053000F0000004000000000810A000000C0010A0000C0040B000081070F0000810616000081091C0000010625000040042B000081062F000001062500004006350000810A3B000081074500000103350000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000003_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_173876EA] ON [dbo].[Empleados]([apellidosEmpleado]) WITH STATS_STREAM = 0x01000000010000000000000000000000723E8E950000000060050000000000002005000000000000E7020000E7000000640000000000000028D000000000000007000000BDCC7900E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A00000001000000100000003333D34100002041000000003333D3410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000003E02000000000000AC03000000000000B40300000000000050000000000000007F00000000000000C000000000000000F10000000000000028010000000000005F010000000000008E01000000000000B701000000000000E4010000000000001102000000000000300010000000803F000000000000803F04000001002F0041004E0054004F004E002000430041004E0054004F005300300010000000803F000000000000803F040000010041004300480049004E004300480049004C004C0041002000560049004C004C00410052005200450041004C00300010000000803F000000000000803F0400000100310043004F004D0041005300200043004F004C004C00410044004F00300010000000803F000000000000803F04000001003700470055004900520041004F002000460045005200520041004E00440049005A00300010000000803F000000000000803F040000010037004D004F004E0045004400450052004F00200042004100540041004C004C004100300010000000803F000000000000803F04000001002F004E00410052005600410045005A0020004F00520054004100300010000000803F000000000000803F040000010029004E0041005600410053002000560041004C00300010000000803F000000000000803F04000001002D0054004500520041004E00200041004C0041004D004F00300010000000803F000000000000803F04000001002D005600490047004F0020005400520049004C004C004F00300010000000803F000000000000803F04000001002D0056004900560045005300200043004800450043004100FF01000000000000000A0000000A000000280000002800000000000000000000007F00000041004E0054004F004E002000430041004E0054004F0053004300480049004E004300480049004C004C0041002000560049004C004C00410052005200450041004C004F004D0041005300200043004F004C004C00410044004F00470055004900520041004F002000460045005200520041004E00440049005A004D004F004E0045004400450052004F00200042004100540041004C004C0041004E00410052005600410045005A0020004F005200540041005600410053002000560041004C0054004500520041004E00200041004C0041004D004F005600490047004F0020005400520049004C004C004F005600450053002000430048004500430041000E0000004000000000810C000000C0010C000081140D0000010C21000081102D000081103D0000C0024D0000810A4F00000107590000810B60000040026B000081096D00000109760000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000004_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000004_173876EA] ON [dbo].[Empleados]([telefono]) WITH STATS_STREAM = 0x010000000100000000000000000000008B53480D0000000088040000000000004804000000000000E7020000E7000000120000000000000028D000000100000007000000BCCC7900E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A000000010000001000000000009041000020410000000000009041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000EA01000000000000D402000000000000DC0200000000000050000000000000007900000000000000A200000000000000CB00000000000000F4000000000000001D0100000000000046010000000000006F010000000000009801000000000000C101000000000000300010000000803F000000000000803F0400000100290032003100350034002D003500340035003100300010000000803F000000000000803F0400000100290032003200320033002D003400310035003100300010000000803F000000000000803F0400000100290032003200340035002D003500370038003100300010000000803F000000000000803F0400000100290032003200350034002D003500340035003100300010000000803F000000000000803F0400000100290037003100320031002D003200310032003500300010000000803F000000000000803F0400000100290037003200350034002D003500340034003400300010000000803F000000000000803F0400000100290037003800310032002D003600330032003100300010000000803F000000000000803F0400000100290037003800340035002D003500340035003100300010000000803F000000000000803F0400000100290037003800340035002D003500340035003400300010000000803F000000000000803F0400000100290037003800350034002D003500340035003100FF01000000000000000A0000000A000000280000002800000000000000000000003800000032003100350034002D0035003400350031003200320033002D003400310035003100340035002D00350037003800310037003100320031002D0032003100320035003200350034002D0035003400340034003800310032002D003600330032003100340035002D003500340035003100100000004000000000C0010000008108010000400109000081070A000081071100000107020000400118000081081900008108210000400129000081072A0000C006310000810137000001010300000107020000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000005_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000005_173876EA] ON [dbo].[Empleados]([correo]) WITH STATS_STREAM = 0x01000000010000000000000000000000514D63920000000067060000000000002706000000000000E702803FE7000000640000000000000028D000000035003407000000BACC7900E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A00000001000000100000009A99214200002041000000009A992142000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000CA02000000000000B304000000000000BB0400000000000050000000000000008500000000000000CA0000000000000005010000000000003E010000000000008101000000000000C6010000000000000D0200000000000048020000000000008502000000000000300010000000803F000000000000803F04000001003500610073006400400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010045006600720061006E0063006900730063006F0031003200400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F04000001003B004A00610075006E0031003200400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010039004A006F00730065004100400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010043006A006F00730065006300610072006C006F007300400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010045004A006F00730065006D0061006E00750065006C003500400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010047006A00750061006E006300610072006C006F00730031003200400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F04000001003B006D0061007200690061004400400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F04000001003D004D00610072006900610053006200400079006F0070006D00610069006C002E0063006F006D00300010000000803F000000000000803F040000010045006D0043006F006E00630065007000630069006F006E00400079006F0070006D00610069006C002E0063006F006D00FF01000000000000000A0000000A00000028000000280000000000000000000000BA000000610073006400400079006F0070006D00610069006C002E0063006F006D006600720061006E0063006900730063006F0031003200400079006F0070006D00610069006C002E0063006F006D004A00610075006E0031003200400079006F0070006D00610069006C002E0063006F006D006F00730065004100400079006F0070006D00610069006C002E0063006F006D006300610072006C006F007300400079006F0070006D00610069006C002E0063006F006D006D0061006E00750065006C003500400079006F0070006D00610069006C002E0063006F006D00750061006E006300610072006C006F00730031003200400079006F0070006D00610069006C002E0063006F006D006D0061007200690061004400400079006F0070006D00610069006C002E0063006F006D0053006200400079006F0070006D00610069006C002E0063006F006D0043006F006E00630065007000630069006F006E00400079006F0070006D00610069006C002E0063006F006D000F0000004000000000810F00000081170F0000C0012600008111270000C003380000810D3B0000811248000001135A000001176D00004001840000C004850000810D890000010E9600000116A40000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000006_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000006_173876EA] ON [dbo].[Empleados]([estadoEmpleado]) WITH STATS_STREAM = 0x01000000010000000000000000000000FD2DA615000000000B02000000000000CB01000000000000E7020061E7000000640000000000000028D00000006D006107000000B9CC7900E7A800000A000000000000000A00000000000000000000000000803F00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100000001000000010000001000000000000040000020410000000000000040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000210000000000000057000000000000005F0000000000000008000000000000003000100000002041000000000000803F040000010019003100FF01000000000000000A00000001000000280000002800000000000000000000000100000031000200000040000000000A01000000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000007_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000007_173876EA] ON [dbo].[Empleados]([usuario]) WITH STATS_STREAM = 0x0100000001000000000000000000000084953070000000002804000000000000E803000000000000E7020000E7000000640000000000000028D0000001000000070000007E697100E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A000000010000001000000033334341000020410000000033334341000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000B00100000000000074020000000000007C02000000000000500000000000000071000000000000009C00000000000000BD00000000000000DE00000000000000FF000000000000002401000000000000430100000000000068010000000000008B01000000000000300010000000803F000000000000803F0400000100210041004E00410031003200300010000000803F000000000000803F04000001002B0043006F006E00630065007000630069006F006E00300010000000803F000000000000803F040000010021004600720061006E003200300010000000803F000000000000803F040000010021004A006F00730065003200300010000000803F000000000000803F040000010021004A006F00730065004300300010000000803F000000000000803F040000010025004A006F00730065006D0031003000300010000000803F000000000000803F04000001001F004A00750061006E00300010000000803F000000000000803F040000010025006A00750061006E00430031003200300010000000803F000000000000803F040000010023004D0061007200690061003200300010000000803F000000000000803F040000010025006D00610072006900610044003100FF01000000000000000A0000000A000000280000002800000000000000000000002A00000041004E0041003100320043006F006E00630065007000630069006F006E004600720061006E0032004A006F007300650032006D0031003000750061006E004300310032004D0061007200690061003200440031000E00000040000000008105000000810A05000081050F0000C001140000C00315000081011800008101050000010319000041031C000001031F0000400522000081012700000102280000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000008_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000008_173876EA] ON [dbo].[Empleados]([contrasenia]) WITH STATS_STREAM = 0x010000000100000000000000000000004B9D398D00000000A5030000000000006503000000000000E7020000E7000000640000000000000028D000007F000000070000007D697100E7A800000A000000000000000A00000000000000000000002549123E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000007000000070000000100000010000000CDCC5C410000204100000000CDCC5C410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000003901000000000000F101000000000000F90100000000000038000000000000005B000000000000007E00000000000000A300000000000000C800000000000000ED000000000000001401000000000000300010000000803F000000000000803F0400000100230041006E006100310032003300300010000000803F000000000000803F0400000100230044006F006C00310032003300300010000000803F000000000000803F040000010025004600720061006E003100320033003000100000004040000000000000803F040000010025006A006F00730065003100320033003000100000000040000000000000803F040000010025004A00750061006E00310032003300300010000000803F000000000000803F040000010027004D006100720069006100310032003300300010000000803F000000000000803F040000010025006D0043006F006E00310032003300FF01000000000000000A00000007000000280000002800000000000000000000002E00000041006E00610031003200330044006F006C003100320033004600720061006E003100320033006A006F0073006500310032003300750061006E003100320033004D00610072006900610031003200330043006F006E003100320033000A00000040000000008106000000810606000081070C0000C001130000830614000002061A0000400120000081072100000106280000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000009_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000009_173876EA] ON [dbo].[Empleados]([cargo]) WITH STATS_STREAM = 0x01000000010000000000000000000000EE505B5600000000E602000000000000A602000000000000E702E868E7000000280000000000000028D000008101050007000000B7CC7900E7A800000A000000000000000A00000000000000000000000000803E00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000400000004000000010000001000000000009841000020410000000000009841000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000C40000000000000032010000000000003A01000000000000200000000000000047000000000000006C000000000000009700000000000000300010000000803F000000000000803F04000001002700470065006E00720065006E00740065003000100000000040000000000000803F0400000100250047006500720065006E00740065003000100000008040000000000000803F04000001002B00530075007000650072007600690073006F0072003000100000004040000000000000803F04000001002D00530075007000650072007600690073006F0072006100FF01000000000000000A000000040000002800000028000000000000000000000013000000470065006E00720065006E0074006500530075007000650072007600690073006F0072006100060000004000000000C00200000081060200000205030000440A0800000301120000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_0000000A_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_0000000A_173876EA] ON [dbo].[Empleados]([privilegio]) WITH STATS_STREAM = 0x01000000010000000000000000000000CE4C775400000000CB010000000000008B01000000000000380206023800000004000A00000000000000000000000A0007000000B6CC7900E7A800000A000000000000000A00000000000000000000000000803F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000010000000100000014000000000080400000204100000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000001F00000000000000270000000000000008000000000000001000140000002041000000000000803F010000000400000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_0000000B_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_0000000B_173876EA] ON [dbo].[Empleados]([DUIEmpleado]) WITH STATS_STREAM = 0x01000000010000000000000000000000A7A2552300000000D7040000000000009704000000000000E7021000E7000000140000000000000028D00000002B005307000000B5CC7900E7A800000A000000000000000A0000000000000000000000CDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000A0000000A00000001000000100000000000A04100002041000000000000A041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000FE0100000000000023030000000000002B0300000000000050000000000000007B00000000000000A600000000000000D100000000000000FC00000000000000270100000000000052010000000000007D01000000000000A801000000000000D301000000000000300010000000803F000000000000803F04000001002B00300030003000310032003100320033002D003400300010000000803F000000000000803F04000001002B00300031003200300030003100320031002D003400300010000000803F000000000000803F04000001002B00300031003200300031003200310032002D003200300010000000803F000000000000803F04000001002B00310032003300310032003300310035002D003400300010000000803F000000000000803F04000001002B00320033003100320033003100320033002D003300300010000000803F000000000000803F04000001002B00340035003600300031003000310032002D003400300010000000803F000000000000803F04000001002B00340035003600310034003600370038002D003200300010000000803F000000000000803F04000001002B00340035003600340035003000300030002D003400300010000000803F000000000000803F04000001002B00340036003500360034003500360035002D003400300010000000803F000000000000803F04000001002B00370038003900340034003500360035002D003500FF01000000000000000A0000000A0000002800000028000000000000000000000058000000300030003000310032003100320033002D00340031003200300030003100320031002D00340031003200310032002D003200310032003300310032003300310035002D003400320033003100320033003100320033002D003300340035003600300031003000310032002D003400310034003600370038002D003200340035003000300030002D00340036003500360034003500360035002D003400370038003900340034003500360035002D0035000F0000004000000000C001000000810901000040030A000081060D00000106130000810A190000810A230000C0012D0000C0022E00008107300000810737000001073E00000109450000010A4E0000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_0000000C_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_0000000C_173876EA] ON [dbo].[Empleados]([sexo]) WITH STATS_STREAM = 0x010000000100000000000000000000005C1C726000000000EA01000000000000AA01000000000000380234003800000004000A0000000000000000003400300007000000B3CC7900E7A800000A000000000000000A00000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000014000000000080400000204100000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000003E00000000000000460000000000000010000000000000002700000000000000100014000000C040000000000000803F010000000400001000140000008040000000000000803F020000000400000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_0000000D_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_0000000D_173876EA] ON [dbo].[Empleados]([direccionEmpleado]) WITH STATS_STREAM = 0x010000000100000000000000000000007B9799680000000050040000000000001004000000000000E7020000E7000000900100000000000028D000000000000007000000B2CC7900E7A800000A000000000000000A0000000000000000000000398EE33D0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000090000000900000001000000100000009A99894100002041000000009A998941000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000013000000000000000000000000000000AD010000000000009C02000000000000A40200000000000048000000000000007700000000000000A400000000000000C500000000000000EA000000000000000B010000000000002C0100000000000057010000000000008401000000000000300010000000803F000000000000803F04000001002F004300680061006C006100740065006E0061006E0067006F00300010000000803F000000000000803F04000001002D0043006900750064006100640020004100720063006500300010000000803F000000000000803F0400000100210043006F006C006F006E00300010000000803F000000000000803F040000010025004C006F0075007200640065007300300010000000803F000000000000803F040000010021004D006F00720061007300300010000000803F000000000000803F040000010021004F007000690063006F00300010000000803F000000000000803F04000001002B00530061006E0074006100200041006E00740061003000100000000040000000000000803F04000001002D00530061006E007400610020005400650063006C006100300010000000803F000000000000803F0400000100290053006F0079006100700061006E0067006F00FF01000000000000000A0000000900000028000000280000000000000000000000420000004300680061006C006100740065006E0061006E0067006F0069007500640061006400200041007200630065006F006C006F006E004C006F00750072006400650073004D006F007200610073004F007000690063006F00530061006E0074006100200041006E00740061005400650063006C0061006F0079006100700061006E0067006F000D0000004000000000C001000000810B010000810A0C0000010416000081071A00008105210000810526000040012B0000C0052C00008104310000020535000001083A0000000A00000000000000
GO
/****** Object:  Statistic [_WA_Sys_0000000E_173876EA]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_0000000E_173876EA] ON [dbo].[Empleados]([imagenEmpleado]) WITH STATS_STREAM = 0x010000000100000000000000000000005F5BDAD000000000A40100000000000064010000000000002202002122000000FFFF0000000000000000000000803F0007000000B1CC7900E7A800000A000000000000000A00000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000100000000000000000002041000020410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000008000000000000000A00000000000000
GO
/****** Object:  Statistic [PK__Empleado__5295297CDB9F8304]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Empleados]([PK__Empleado__5295297CDB9F8304]) WITH STATS_STREAM = 0x01000000010000000000000000000000FF2B5B930000000066020000000000002602000000000000380300003800000004000A0000000000000000000000000007000000A4CC7900E7A800000A000000000000000A000000000000000000803FCDCCCC3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000600000006000000010000001400000000008040000020410000000000008040000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000000000000000000000000000BA00000000000000C200000000000000300000000000000047000000000000005E0000000000000075000000000000008C00000000000000A300000000000000100014000000803F000000000000803F01000000040000100014000000803F0000803F0000803F03000000040000100014000000803F0000803F0000803F05000000040000100014000000803F0000803F0000803F07000000040000100014000000803F0000803F0000803F09000000040000100014000000803F000000000000803F0A0000000400000A00000000000000, ROWCOUNT = 15, PAGECOUNT = 1
GO
/****** Object:  Statistic [PK__Factura__3CD5687E7B8C8C29]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Factura]([PK__Factura__3CD5687E7B8C8C29]) WITH STATS_STREAM = 0x01000000010000000000000000000000ED0358EE0000000040000000000000000000000000000000380300003800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [PK_Privilegio]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Privilegio]([PK_Privilegio]) WITH STATS_STREAM = 0x01000000010000000000000000000000ED0358EE0000000040000000000000000000000000000000380300003800000004000A00000000000000000000000000, ROWCOUNT = 2, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000002_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000002_1CF15040] ON [dbo].[Renta]([matriculaAutoR]) WITH STATS_STREAM = 0x0100000001000000000000000000000054B87E47000000006E020000000000002E02000000000000E7020000E7000000100000000000000028D00000010000000700000030AA7601E6A8000002000000000000000200000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000010000000000080410000004000000000000080410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000005E00000000000000BA00000000000000C20000000000000010000000000000003700000000000000300010000000803F000000000000803F0400000100270050003100390032002D00320035003800300010000000803F000000000000803F0400000100270050003400350036002D00310035003900FF01000000000000000200000002000000280000002800000000000000000000000F00000050003100390032002D003200350038003400350036002D00310035003900040000004000000000400100000081070100000107080000000200000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000003_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_1CF15040] ON [dbo].[Renta]([DUICliente]) WITH STATS_STREAM = 0x0100000001000000000000000000000076187826000000007B020000000000003B02000000000000E7020000E7000000140000000000000028D00000020000000700000033AA7601E6A8000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000A04100000040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000006600000000000000C700000000000000CF0000000000000010000000000000003B00000000000000300010000000803F000000000000803F04000001002B00320036003400380039003300360035002D003900300010000000803F000000000000803F04000001002B00330034003600380038003900320033002D003900FF010000000000000002000000020000002800000028000000000000000000000014000000320036003400380039003300360035002D003900330034003600380038003900320033002D003900030000004000000000810A000000010A0A0000000200000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000004_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000004_1CF15040] ON [dbo].[Renta]([fechaEntregaR]) WITH STATS_STREAM = 0x01000000010000000000000000000000C0E6757A00000000800500000000000040050000000000003D0200003D0000000800170300000000000000000100000007000000F21B8B00EEA80000200000000000000020000000000000000000803FCB3D0D3D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001C0000001C000000010000001800000000000041000000420000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000000000000000000000000000D403000000000000DC03000000000000E000000000000000FB00000000000000160100000000000031010000000000004C01000000000000670100000000000082010000000000009D01000000000000B801000000000000D301000000000000EE01000000000000090200000000000024020000000000003F020000000000005A0200000000000075020000000000009002000000000000AB02000000000000C602000000000000E102000000000000FC02000000000000170300000000000032030000000000004D03000000000000680300000000000083030000000000009E03000000000000B903000000000000100018000000803F000000000000803F000000001AF8FFFF040000100018000000803F000000000000803F0000000024F8FFFF040000100018000000803F000000000000803F0000000027F8FFFF040000100018000000803F000000000000803F0000000028F8FFFF040000100018000000803F000000000000803F000000002DF8FFFF0400001000180000000040000000000000803F0000000032F8FFFF0400001000180000004040000000000000803F0000000035F8FFFF040000100018000000803F000000000000803FF0190301E6A80000040000100018000000803F000000000000803F28CB0801E6A80000040000100018000000803F000000000000803FEAF67F01E6A80000040000100018000000803F000000000000803F9B2D1901EAA80000040000100018000000803F000000000000803F8EE61901EAA80000040000100018000000803F000000000000803FA1B61C01EAA80000040000100018000000803F000000000000803FDD291D01EAA80000040000100018000000803F000000000000803F87562001EAA80000040000100018000000803F000000000000803F3E002101EAA80000040000100018000000803F000000000000803FA2382201EAA80000040000100018000000803F000000000000803F67372301EAA80000040000100018000000803F000000000000803F8E0B3401EAA80000040000100018000000803F000000000000803FF4C63501EAA80000040000100018000000803F000000000000803F14133601EAA80000040000100018000000803F000000000000803FEFAE3801EAA80000040000100018000000803F000000000000803F74829300EBA80000040000100018000000803F0000803F0000803F3D529500EBA80000040000100018000000803F000000000000803F0B417E00EDA80000040000100018000000803F000000000000803F29A58101EDA80000040000100018000000803F000000000000803FB5E28101EDA80000040000100018000000803F000000000000803F00000000EEA800000400002000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000005_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000005_1CF15040] ON [dbo].[Renta]([fechaDevolucionR]) WITH STATS_STREAM = 0x010000000100000000000000000000009DFE8572000000008B040000000000004B040000000000003D0200003D0000000800170300000000000000000100000007000000F11B8B00EEA80000200000000000000020000000000000000000803F8988083D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001500000015000000010000001800000000000041000000420000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000000000000000000000000000DF02000000000000E702000000000000A800000000000000C300000000000000DE00000000000000F90000000000000014010000000000002F010000000000004A01000000000000650100000000000080010000000000009B01000000000000B601000000000000D101000000000000EC01000000000000070200000000000022020000000000003D02000000000000580200000000000073020000000000008E02000000000000A902000000000000C402000000000000100018000000803F000000000000803F0000000019F8FFFF0400001000180000004040000000000000803F000000001BF8FFFF040000100018000000803F000000000000803F000000001DF8FFFF040000100018000000803F000000000000803F000000001EF8FFFF040000100018000000803F000000000000803F0000000022F8FFFF040000100018000000803F0000803F0000803F000000002FF8FFFF040000100018000000803F000000000000803F0000000031F8FFFF040000100018000000803F000000000000803F4C190301E9A80000040000100018000000803F000000000000803F1CCB0801ECA80000040000100018000000803F000000000000803F8CE18101EEA80000040000100018000000803F000000000000803F50407E00EFA80000040000100018000000803F000000000000803FC8579400EFA80000040000100018000000803F000000000000803F88F67F01EFA80000040000100018000000803F0000A0400000803F2C372301F0A80000040000100018000000803F000000000000803FFC0A3401F0A80000040000100018000000803F000000000000803F20123601F0A80000040000100018000000803F000000000000803F9CA48101F0A80000040000100018000000803F000000000000803F904D0400F1A80000040000100018000000803F000040400000803FB4372201F1A80000040000100018000000803F000000000000803FF4C53501F1A80000040000100018000000803F000000000000803F18AE3801F1A800000400002000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000006_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000006_1CF15040] ON [dbo].[Renta]([monto]) WITH STATS_STREAM = 0x01000000010000000000000000000000160D539200000000680400000000000028040000000000003E02E8683E0000000800350000000000000000000000000007000000EE1B8B00EEA80000200000000000000020000000000000000000803F310C433D00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001400000014000000010000001800000000000041000000420000000000000041000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000011000000000000000000000000000000BC02000000000000C402000000000000A000000000000000BB00000000000000D600000000000000F1000000000000000C01000000000000270100000000000042010000000000005D0100000000000078010000000000009301000000000000AE01000000000000C901000000000000E401000000000000FF010000000000001A02000000000000350200000000000050020000000000006B020000000000008602000000000000A102000000000000100018000000803F000000000000803F0000000000000000040000100018000000803F000000000000803F0000000000003440040000100018000000803F000000000000803F9A999999995938400400001000180000000040000000000000803F0000000000803940040000100018000000803F000000000000803F1F85EB51B81E3C40040000100018000000803F000000000000803F0000000000003E40040000100018000000803F000000000000803F0000000000C03E400400001000180000000040000000000000803F3D0AD7A370BD4140040000100018000000803F000000000000803FC3F5285C8FE24240040000100018000000803F000000000000803F7B14AE47E19A4340040000100018000000803F000000000000803F8FC2F5285C0F4440040000100018000000803F0000803F0000803FCDCCCCCCCC8C4640040000100018000000803F000000000000803F5C8FC2F5289C4A400400001000180000000040000000000000803F6666666666166040040000100018000000803F000000000000803F7B14AE47E19A6340040000100018000000E040000000000000803F9A99999999816840040000100018000000803F000000000000803FAE47E17A148E6B400400001000180000004040000000000000803FB81E85EB51686D40040000100018000000803F000000000000803FEC51B81E852B7040040000100018000000803F000000000000803F7B14AE47E19A73400400002000000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000007_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000007_1CF15040] ON [dbo].[Renta]([estadoRenta]) WITH STATS_STREAM = 0x0100000001000000000000000000000066130BFA0000000042020000000000000202000000000000380247E13800000004000A0000000000000000000000000007000000CE6A7E00EDA800001D000000000000001D00000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000014000000000080400000E84100000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000190000000000000000000000000000003E000000000000008E000000000000009600000000000000100000000000000027000000000000001000140000009041000000000000803F010000000400001000140000003041000000000000803F02000000040000010000009A503E01EAA800000000000000003940190000000000000002000000000000000000E03F000000000000000000000000000000000000000000000CC00000000000001EC0433A6F31A4F3D63F1D00000000000000
GO
/****** Object:  Statistic [_WA_Sys_00000008_1CF15040]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000008_1CF15040] ON [dbo].[Renta]([idEmpleado]) WITH STATS_STREAM = 0x01000000010000000000000000000000EAB9178700000000A40100000000000064010000000000003802FFFF3800000004000A000000000000000000000000000700000039AA7601E6A8000002000000000000000200000000000000000000000000803F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000140000000000000000000040000000400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000001000000000000000000000000000000008000000000000000200000000000000
GO
/****** Object:  Statistic [PK__Renta__8643C7EF41E4AAB4]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Renta]([PK__Renta__8643C7EF41E4AAB4]) WITH STATS_STREAM = 0x01000000010000000000000000000000B429E55F00000000EA01000000000000AA01000000000000380300003800000004000A00000000000000000000000000070000001AAA7601E6A8000002000000000000000200000000000000000000000000003F000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000020000000100000014000000000080400000004000000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000003E00000000000000460000000000000010000000000000002700000000000000100014000000803F000000000000803FEC030000040000100014000000803F000000000000803FED0300000400000200000000000000, ROWCOUNT = 34, PAGECOUNT = 1
GO
/****** Object:  Statistic [_WA_Sys_00000003_1ED998B2]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000003_1ED998B2] ON [dbo].[Reparacion]([matriculaAutoRep]) WITH STATS_STREAM = 0x01000000010000000000000000000000087B11210000000040000000000000000000000000000000E7020000E7000000100000000000000028D0000000000000
GO
/****** Object:  Statistic [PK__Reparaci__4E5D15A652F13DE0]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Reparacion]([PK__Reparaci__4E5D15A652F13DE0]) WITH STATS_STREAM = 0x0100000001000000000000000000000079B4FC1C00000000400000000000000000000000000000003803E8683800000004000A00000000000000000000000000, ROWCOUNT = 0, PAGECOUNT = 0
GO
/****** Object:  Statistic [_WA_Sys_00000002_20C1E124]    Script Date: 02/06/2018 11:22:40 a. m. ******/
CREATE STATISTICS [_WA_Sys_00000002_20C1E124] ON [dbo].[Taller]([nomTaller]) WITH STATS_STREAM = 0x0100000001000000000000000000000038657579000000007B020000000000003B02000000000000E7020000E7000000640000000000000028D000000000000007000000B0DE6501EDA8000002000000000000000200000000000000000000000000003F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000020000000200000001000000100000000000A04100000040000000000000A0410000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000130000000000000000000000000000006600000000000000C700000000000000CF0000000000000010000000000000003300000000000000300010000000803F000000000000803F04000001002300430061007200460069007800300010000000803F000000000000803F04000001003300540061006C006C00650072002000520061006D006900720065007A00FF010000000000000002000000020000002800000028000000000000000000000014000000430061007200460069007800540061006C006C00650072002000520061006D006900720065007A000300000040000000008106000000010E060000000200000000000000
GO
/****** Object:  Statistic [PK__Taller__449E029F681D76F6]    Script Date: 02/06/2018 11:22:40 a. m. ******/
UPDATE STATISTICS [dbo].[Taller]([PK__Taller__449E029F681D76F6]) WITH STATS_STREAM = 0x010000000100000000000000000000006DDBC812000000002802000000000000E801000000000000380300003800000004000A0000000000000000000200000007000000F28F7301EDA8000004000000000000000400000000000000000000000000803E000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000004000000040000000100000014000000000080400000804000000000000080400000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000110000000000000000000000000000007C000000000000008400000000000000200000000000000037000000000000004E000000000000006500000000000000100014000000803F000000000000803F01000000040000100014000000803F000000000000803F02000000040000100014000000803F000000000000803F06000000040000100014000000803F000000000000803F080000000400000400000000000000, ROWCOUNT = 4, PAGECOUNT = 1
GO
USE [master]
GO
ALTER DATABASE [RentACar] SET  READ_WRITE 
GO
