CREATE TABLE [dbo].[Product] (
    [Id]       INT             IDENTITY (1, 1) NOT NULL,
    [Producto] NVARCHAR (50)   NOT NULL,
    [Precio]   DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);

