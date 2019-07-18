CREATE TABLE Productos (
    IDProductos int IDENTITY(1,1) PRIMARY KEY,
    Titulo varchar(255) NOT NULL,
    Descripcion varchar(255),
    PrecioUnitario Decimal(7,2)  NOT NULL,
    Existencias int  NOT NULL
);

CREATE TABLE Ventas (
    IDVentas int IDENTITY(1,1) PRIMARY KEY,
    IDProductos int FOREIGN KEY REFERENCES Productos(IDProductos),
    CantidadVendida int,
    Fecha datetime2  NOT NULL
);


INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Maestro Limpio 1L'
           ,'Limpiador multiusos.'
           ,18
           ,1000)
GO

INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Cloralex 1L.'
           , 'Cloro para limpieza general.'
           ,14.50
           ,500)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Cloralex Pastillas 10 Unidades'
           ,'Cloro en pastillas para desinfección de inodoro.'
           ,120.80
           ,90)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Pinol 1L.'
           ,'Limpiador Multiusos.'
           ,21.50
           ,425)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Siempre Limpio 300 Bolsas.'
           ,'Bolsas para basura biodegradables.'
           ,150.80
           ,125)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('El Reluciente. 2 Kilos.'
           ,'Jabon para lavado de trastes.'
           ,16.70
           ,225)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('El suavecito. Paquete 4 rollos.'
           ,'Papel Higienico.'
           ,60
           ,673)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Cesto Papelero. Capacidad de 1L cubico'
           ,'Cesto papelero.'
           ,70
           ,23)
GO
INSERT INTO [dbo].[Productos]
           ([Titulo]
           ,[Descripcion]
           ,[PrecioUnitario]
           ,[Existencias])
     VALUES
           ('Toallitas Resplandor. Paquete 70 toallitas.'
           ,'Toallitas desinfectantes.'
           ,113
           ,825)
GO


INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           2
           ,5
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           3
           ,500
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           4
           ,78
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           2
           ,250
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           8
           ,700
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           5
           ,96
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           1
           ,500
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           9
           ,550
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           4
           ,763
           ,'01-08-2017 11:25:57')
GO
INSERT INTO [dbo].[Ventas]
           ([IDProductos]
           ,[CantidadVendida]
           ,[Fecha])
     VALUES(
           4
           ,298
           ,'01-08-2017 11:25:57')
GO
