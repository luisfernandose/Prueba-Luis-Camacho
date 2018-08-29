CREATE TABLE [dbo].[UserOrder] (
    [IdUser]  INT NOT NULL,
    [IdOrder] INT NOT NULL,
    CONSTRAINT [PK_UserOrder] PRIMARY KEY CLUSTERED ([IdUser] ASC, [IdOrder] ASC),
    CONSTRAINT [FK_UserOrder_Order] FOREIGN KEY ([IdOrder]) REFERENCES [dbo].[Order] ([Id]),
    CONSTRAINT [FK_UserOrder_User] FOREIGN KEY ([IdUser]) REFERENCES [dbo].[User] ([id])
);

