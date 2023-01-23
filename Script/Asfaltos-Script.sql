CREATE DATABASE ProyectosAsfaltos
USE [ProyectosAsfaltos]
GO
/****** Object:  Table [dbo].[Ofertas]    Script Date: 23/1/2023 12:17:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ofertas](
	[OfertaId] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Codigo] [int] NOT NULL,
	[Sellador] [bit] NOT NULL,
	[Asfalto] [bit] NOT NULL,
	[Base] [bit] NOT NULL,
	[SubBase] [bit] NOT NULL,
	[Excavacion] [bit] NOT NULL,
	[Monto] [real] NOT NULL,
	[Notas] [nvarchar](max) NOT NULL,
	[Observaciones] [nvarchar](max) NOT NULL,
	[AutorPrespuesto] [nvarchar](max) NOT NULL,
	[Cliente] [nvarchar](max) NOT NULL,
	[UltimaModificacion] [datetime2](7) NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_Ofertas] PRIMARY KEY CLUSTERED 
(
	[OfertaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 23/1/2023 12:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos](
	[ProyectoId] [int] IDENTITY(1,1) NOT NULL,
	[FechaOC] [datetime2](7) NOT NULL,
	[Contacto] [nvarchar](max) NOT NULL,
	[Cliente] [nvarchar](max) NOT NULL,
	[OfertaId] [nvarchar](max) NOT NULL,
	[Monto] [real] NOT NULL,
	[PorcentajeAnticipo] [int] NOT NULL,
	[FacturaAnticipoId] [nvarchar](max) NOT NULL,
	[FacturaFinalId] [nvarchar](max) NOT NULL,
	[TareaId] [int] NOT NULL,
	[Ubicacion] [nvarchar](max) NOT NULL,
	[FechaInicio] [datetime2](7) NOT NULL,
	[FechaFinal] [datetime2](7) NOT NULL,
	[Estado] [nvarchar](max) NOT NULL,
	[Autor] [nvarchar](max) NOT NULL,
	[UltimaEdicion] [datetime2](7) NOT NULL,
	[UltimoEditor] [nvarchar](max) NOT NULL,
	[UsuarioId] [int] NOT NULL,
	[Enable] [bit] NOT NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[ProyectoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 23/1/2023 12:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolUsuarios]    Script Date: 23/1/2023 12:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolUsuarios](
	[RolUsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[RolId] [int] NOT NULL,
	[UsuarioId] [int] NOT NULL,
 CONSTRAINT [PK_RolUsuarios] PRIMARY KEY CLUSTERED 
(
	[RolUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 23/1/2023 12:17:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioId] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Activo] [bit] NOT NULL,
	[HashContraseña] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ofertas] ON 

INSERT [dbo].[Ofertas] ([OfertaId], [Fecha], [Codigo], [Sellador], [Asfalto], [Base], [SubBase], [Excavacion], [Monto], [Notas], [Observaciones], [AutorPrespuesto], [Cliente], [UltimaModificacion], [UsuarioId]) VALUES (1, CAST(N'2023-01-19T00:00:00.0000000' AS DateTime2), 1, 1, 1, 1, 1, 1, 100, N'', N'', N'Administrador', N'Ejemplo', CAST(N'2023-01-19T01:00:00.0000000' AS DateTime2), 1)
SET IDENTITY_INSERT [dbo].[Ofertas] OFF
GO
SET IDENTITY_INSERT [dbo].[Proyectos] ON 

INSERT [dbo].[Proyectos] ([ProyectoId], [FechaOC], [Contacto], [Cliente], [OfertaId], [Monto], [PorcentajeAnticipo], [FacturaAnticipoId], [FacturaFinalId], [TareaId], [Ubicacion], [FechaInicio], [FechaFinal], [Estado], [Autor], [UltimaEdicion], [UltimoEditor], [UsuarioId], [Enable]) VALUES (1, CAST(N'2023-01-19T15:41:03.2645187' AS DateTime2), N'Ejemplo', N'Ejemplo de Cliente', N'1', 100, 50, N'No existente', N'No Existente', 2000, N'Grupo Mecsa', CAST(N'2023-01-18T00:00:00.0000000' AS DateTime2), CAST(N'2023-01-21T00:00:00.0000000' AS DateTime2), N'Finalizado', N'Administrador', CAST(N'2023-01-19T00:00:00.0000000' AS DateTime2), N'Administrador', 1, 1)
SET IDENTITY_INSERT [dbo].[Proyectos] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RolId], [Nombre]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RolId], [Nombre]) VALUES (2, N'Vendedor')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[RolUsuarios] ON 

INSERT [dbo].[RolUsuarios] ([RolUsuarioId], [RolId], [UsuarioId]) VALUES (1, 1, 1)
INSERT [dbo].[RolUsuarios] ([RolUsuarioId], [RolId], [UsuarioId]) VALUES (2, 2, 2)
INSERT [dbo].[RolUsuarios] ([RolUsuarioId], [RolId], [UsuarioId]) VALUES (3, 2, 3)
SET IDENTITY_INSERT [dbo].[RolUsuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([UsuarioId], [Nombre], [Login], [Activo], [HashContraseña]) VALUES (1, N'Administrador', N'admin', 1, N'0192023A7BBD73250516F069DF18B500')
INSERT [dbo].[Usuarios] ([UsuarioId], [Nombre], [Login], [Activo], [HashContraseña]) VALUES (2, N'vendedor', N'Vendedor Ejemplo', 1, N'68CD4564586E6E9662E633CB1034224F')

SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Ofertas]  WITH CHECK ADD  CONSTRAINT [FK_Ofertas_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ofertas] CHECK CONSTRAINT [FK_Ofertas_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Usuarios_UsuarioId]
GO
ALTER TABLE [dbo].[RolUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_RolUsuarios_Roles_RolId] FOREIGN KEY([RolId])
REFERENCES [dbo].[Roles] ([RolId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolUsuarios] CHECK CONSTRAINT [FK_RolUsuarios_Roles_RolId]
GO
ALTER TABLE [dbo].[RolUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_RolUsuarios_Usuarios_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuarios] ([UsuarioId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RolUsuarios] CHECK CONSTRAINT [FK_RolUsuarios_Usuarios_UsuarioId]
GO
