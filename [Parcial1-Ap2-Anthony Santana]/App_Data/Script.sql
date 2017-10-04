CREATE TABLE [dbo].[Presupuestos] (
    [PresupuestoId] INT          IDENTITY (1, 1) NOT NULL,
    [Fecha]         DATETIME     NULL,
    [Monto]         DECIMAL (18) NULL,
    [Descripcion]   VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([PresupuestoId] ASC)
);


CREATE TABLE [dbo].[Categorias] (
    [CategoriaId]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreCategoria] VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([CategoriaId] ASC)
);