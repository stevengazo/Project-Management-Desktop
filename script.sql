IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Roles] (
    [RolId] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY ([RolId])
);
GO

CREATE TABLE [Usuarios] (
    [UsuarioId] int NOT NULL IDENTITY,
    [Nombre] nvarchar(max) NOT NULL,
    [Login] nvarchar(max) NOT NULL,
    [Activo] bit NOT NULL,
    [HashContraseña] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Usuarios] PRIMARY KEY ([UsuarioId])
);
GO

CREATE TABLE [Ofertas] (
    [OfertaId] int NOT NULL IDENTITY,
    [Fecha] datetime2 NOT NULL,
    [Codigo] int NOT NULL,
    [Monto] real NOT NULL,
    [Notas] nvarchar(max) NOT NULL,
    [Observaciones] nvarchar(max) NOT NULL,
    [EncargadoCotizador] nvarchar(max) NOT NULL,
    [AutorPrespuesto] nvarchar(max) NOT NULL,
    [Cliente] nvarchar(max) NOT NULL,
    [UltimaModificacion] datetime2 NOT NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_Ofertas] PRIMARY KEY ([OfertaId]),
    CONSTRAINT [FK_Ofertas_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([UsuarioId]) ON DELETE CASCADE
);
GO

CREATE TABLE [Proyectos] (
    [ProyectoId] int NOT NULL IDENTITY,
    [FechaOC] datetime2 NOT NULL,
    [Contacto] nvarchar(max) NOT NULL,
    [Cliente] nvarchar(max) NOT NULL,
    [OfertaId] nvarchar(max) NOT NULL,
    [Monto] real NOT NULL,
    [PorcentajeAnticipo] int NOT NULL,
    [FacturaAnticipoId] nvarchar(max) NOT NULL,
    [FacturaFinalId] nvarchar(max) NOT NULL,
    [TareaId] int NOT NULL,
    [Ubicacion] nvarchar(max) NOT NULL,
    [Notas] nvarchar(max) NOT NULL,
    [FechaInicio] datetime2 NOT NULL,
    [FechaFinal] datetime2 NOT NULL,
    [Estado] nvarchar(max) NOT NULL,
    [Autor] nvarchar(max) NOT NULL,
    [UltimaEdicion] datetime2 NOT NULL,
    [UltimoEditor] nvarchar(max) NOT NULL,
    [UsuarioId] int NOT NULL,
    [Enable] bit NOT NULL,
    CONSTRAINT [PK_Proyectos] PRIMARY KEY ([ProyectoId]),
    CONSTRAINT [FK_Proyectos_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([UsuarioId]) ON DELETE CASCADE
);
GO

CREATE TABLE [RolUsuarios] (
    [RolUsuarioId] int NOT NULL IDENTITY,
    [RolId] int NOT NULL,
    [UsuarioId] int NOT NULL,
    CONSTRAINT [PK_RolUsuarios] PRIMARY KEY ([RolUsuarioId]),
    CONSTRAINT [FK_RolUsuarios_Roles_RolId] FOREIGN KEY ([RolId]) REFERENCES [Roles] ([RolId]) ON DELETE CASCADE,
    CONSTRAINT [FK_RolUsuarios_Usuarios_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [Usuarios] ([UsuarioId]) ON DELETE CASCADE
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolId', N'Nombre') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] ON;
INSERT INTO [Roles] ([RolId], [Nombre])
VALUES (1, N'Admin'),
(2, N'Vendedor');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolId', N'Nombre') AND [object_id] = OBJECT_ID(N'[Roles]'))
    SET IDENTITY_INSERT [Roles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UsuarioId', N'Activo', N'HashContraseña', N'Login', N'Nombre') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] ON;
INSERT INTO [Usuarios] ([UsuarioId], [Activo], [HashContraseña], [Login], [Nombre])
VALUES (1, CAST(1 AS bit), N'0192023A7BBD73250516F069DF18B500', N'admin', N'Administrador');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'UsuarioId', N'Activo', N'HashContraseña', N'Login', N'Nombre') AND [object_id] = OBJECT_ID(N'[Usuarios]'))
    SET IDENTITY_INSERT [Usuarios] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OfertaId', N'AutorPrespuesto', N'Cliente', N'Codigo', N'EncargadoCotizador', N'Fecha', N'Monto', N'Notas', N'Observaciones', N'UltimaModificacion', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[Ofertas]'))
    SET IDENTITY_INSERT [Ofertas] ON;
INSERT INTO [Ofertas] ([OfertaId], [AutorPrespuesto], [Cliente], [Codigo], [EncargadoCotizador], [Fecha], [Monto], [Notas], [Observaciones], [UltimaModificacion], [UsuarioId])
VALUES (1, N'Administrador', N'Ejemplo', 1, N'Gabriel', '2024-01-10T00:00:00.0000000-06:00', CAST(100 AS real), N'', N'', '2024-01-10T01:00:00.0000000-06:00', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'OfertaId', N'AutorPrespuesto', N'Cliente', N'Codigo', N'EncargadoCotizador', N'Fecha', N'Monto', N'Notas', N'Observaciones', N'UltimaModificacion', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[Ofertas]'))
    SET IDENTITY_INSERT [Ofertas] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProyectoId', N'Autor', N'Cliente', N'Contacto', N'Enable', N'Estado', N'FacturaAnticipoId', N'FacturaFinalId', N'FechaFinal', N'FechaInicio', N'FechaOC', N'Monto', N'Notas', N'OfertaId', N'PorcentajeAnticipo', N'TareaId', N'Ubicacion', N'UltimaEdicion', N'UltimoEditor', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[Proyectos]'))
    SET IDENTITY_INSERT [Proyectos] ON;
INSERT INTO [Proyectos] ([ProyectoId], [Autor], [Cliente], [Contacto], [Enable], [Estado], [FacturaAnticipoId], [FacturaFinalId], [FechaFinal], [FechaInicio], [FechaOC], [Monto], [Notas], [OfertaId], [PorcentajeAnticipo], [TareaId], [Ubicacion], [UltimaEdicion], [UltimoEditor], [UsuarioId])
VALUES (1, N'Administrador', N'Ejemplo de Cliente', N'Ejemplo', CAST(1 AS bit), N'Finalizado', N'No existente', N'No Existente', '2024-01-12T00:00:00.0000000-06:00', '2024-01-09T00:00:00.0000000-06:00', '2024-01-10T14:40:36.8670300-06:00', CAST(100 AS real), N'', N'PS-00001', 50, 2000, N'Grupo Mecsa', '2024-01-10T00:00:00.0000000-06:00', N'Administrador', 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProyectoId', N'Autor', N'Cliente', N'Contacto', N'Enable', N'Estado', N'FacturaAnticipoId', N'FacturaFinalId', N'FechaFinal', N'FechaInicio', N'FechaOC', N'Monto', N'Notas', N'OfertaId', N'PorcentajeAnticipo', N'TareaId', N'Ubicacion', N'UltimaEdicion', N'UltimoEditor', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[Proyectos]'))
    SET IDENTITY_INSERT [Proyectos] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolUsuarioId', N'RolId', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[RolUsuarios]'))
    SET IDENTITY_INSERT [RolUsuarios] ON;
INSERT INTO [RolUsuarios] ([RolUsuarioId], [RolId], [UsuarioId])
VALUES (1, 1, 1);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'RolUsuarioId', N'RolId', N'UsuarioId') AND [object_id] = OBJECT_ID(N'[RolUsuarios]'))
    SET IDENTITY_INSERT [RolUsuarios] OFF;
GO

CREATE INDEX [IX_Ofertas_UsuarioId] ON [Ofertas] ([UsuarioId]);
GO

CREATE INDEX [IX_Proyectos_UsuarioId] ON [Proyectos] ([UsuarioId]);
GO

CREATE INDEX [IX_RolUsuarios_RolId] ON [RolUsuarios] ([RolId]);
GO

CREATE INDEX [IX_RolUsuarios_UsuarioId] ON [RolUsuarios] ([UsuarioId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240110204037_InitialCreate', N'7.0.2');
GO

COMMIT;
GO

