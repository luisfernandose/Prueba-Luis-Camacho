CREATE TABLE [dbo].[OrderProduct] (
    [IdOrder]   INT NOT NULL,
    [IdProduct] INT NOT NULL,
    [Cant]      INT NOT NULL,
    CONSTRAINT [PK_OrderProduct] PRIMARY KEY CLUSTERED ([IdOrder] ASC, [IdProduct] ASC),
    CONSTRAINT [FK_OrderProduct_Order] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_OrderProduct_Product] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Product] ([Id])
);

