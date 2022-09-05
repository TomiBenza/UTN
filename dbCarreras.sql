USE [Carreras]
GO
/****** Object:  Table [dbo].[Asignaturas]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaturas](
	[id_asignatura] [int] IDENTITY(1,1) NOT NULL,
	[asignatura] [varchar](60) NULL,
 CONSTRAINT [pk_asignatura] PRIMARY KEY CLUSTERED 
(
	[id_asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carreras]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carreras](
	[id_carrera] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](60) NULL,
	[titulo] [varchar](60) NULL,
	[estado] [int] NOT NULL,
 CONSTRAINT [pk_carrera] PRIMARY KEY CLUSTERED 
(
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleCarreras]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCarreras](
	[id_carrera] [int] NOT NULL,
	[anioCursado] [int] NULL,
	[cuatrimestre] [int] NULL,
	[id_asignatura] [int] NULL,
	[id_detalle] [int] NOT NULL,
 CONSTRAINT [pk_detalle] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC,
	[id_carrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DetalleCarreras]  WITH CHECK ADD  CONSTRAINT [fk_asignatura] FOREIGN KEY([id_asignatura])
REFERENCES [dbo].[Asignaturas] ([id_asignatura])
GO
ALTER TABLE [dbo].[DetalleCarreras] CHECK CONSTRAINT [fk_asignatura]
GO
/****** Object:  StoredProcedure [dbo].[pa_ver_asignaturas]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[pa_ver_asignaturas]
as
select * from Asignaturas ORDER BY asignatura
GO
/****** Object:  StoredProcedure [dbo].[SP_BAJA_CARRERA]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_BAJA_CARRERA]
@id_carrera int,
@estado int
as
delete from DetalleCarreras where id_carrera=@id_carrera

update Carreras set estado=@estado where id_carrera=@id_carrera
GO
/****** Object:  StoredProcedure [dbo].[SP_BORRAR_CARRERA]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_BORRAR_CARRERA]
@id_carrera int
as
delete from DetalleCarreras where id_carrera=@id_carrera

delete from Carreras where id_carrera=@id_carrera
GO
/****** Object:  StoredProcedure [dbo].[SP_CANTIDAD_CARRERAS]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CANTIDAD_CARRERAS]
@cant int output as

set @cant = (select count(id_carrera) from Carreras where estado=1)
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_DETALLE]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_DETALLE] 
	@id_carrera int,
	@anioCursado int, 
	@cuatrimestre int, 
	@id_asignatura int,
	@id_detalle int
AS
BEGIN
	INSERT INTO DetalleCarreras(id_detalle,id_Carrera,anioCursado, cuatrimestre, id_asignatura)
    VALUES (@id_Detalle,@id_carrera, @anioCursado, @cuatrimestre, @id_asignatura);
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_MAESTRO]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_MAESTRO] 
	@nombre varchar(60),
	@titulo varchar(60),
	@id_carrera int OUTPUT
AS
BEGIN
	INSERT INTO Carreras(nombre,titulo,estado)
    VALUES (@nombre,@titulo,1);
    --Asignamos el valor del último ID autogenerado (obtenido --  
    --mediante la función SCOPE_IDENTITY() de SQLServer)	
    SET @id_carrera = SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_MODIFICAR_CARRERAS]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_MODIFICAR_CARRERAS]
@id_carrera int,
@nombre varchar(60),
@titulo varchar(60)
as
UPDATE Carreras SET nombre=@nombre,titulo=@titulo where id_carrera=@id_carrera

delete from DetalleCarreras where id_carrera=@id_carrera
GO
/****** Object:  StoredProcedure [dbo].[SP_VER_CARRERAS]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VER_CARRERAS]
as
Select * from carreras c 
GO
/****** Object:  StoredProcedure [dbo].[SP_VER_DETALLES]    Script Date: 5/9/2022 18:46:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_VER_DETALLES]
@idCarrera int 
as
select d.id_carrera,id_detalle,anioCursado,cuatrimestre,d.id_asignatura,a.asignatura from DetalleCarreras d join Asignaturas a on
d.id_asignatura=a.id_asignatura

where id_carrera=@idCarrera
GO

INSERT INTO Asignaturas VALUES ('Ingles I')
INSERT INTO Asignaturas VALUES ('Ingles II')
INSERT INTO Asignaturas VALUES ('PROG. I')
INSERT INTO Asignaturas VALUES ('PROG. II')
INSERT INTO Asignaturas VALUES ('LAB. I')
INSERT INTO Asignaturas VALUES ('LAB II')
INSERT INTO Asignaturas VALUES ('ALGEBRA I')
INSERT INTO Asignaturas VALUES ('ALGEBRA II')
INSERT INTO Asignaturas VALUES ('FISICA I')
INSERT INTO Asignaturas VALUES ('FISICA II')
INSERT INTO Asignaturas VALUES ('MATEMATICA')