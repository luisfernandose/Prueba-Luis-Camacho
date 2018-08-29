CREATE TABLE [dbo].[ProductCategory] (
    [IdProduct]  INT NOT NULL,
    [IdCategory] INT NOT NULL,
    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([IdProduct] ASC, [IdCategory] ASC),
    CONSTRAINT [FK_ProductCategory_Category] FOREIGN KEY ([IdCategory]) REFERENCES [dbo].[Category] ([Id]),
    CONSTRAINT [FK_ProductCategory_Product] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Product] ([Id])
);

