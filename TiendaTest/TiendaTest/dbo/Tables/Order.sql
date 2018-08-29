CREATE TABLE [dbo].[Order] (
    [Id]       INT IDENTITY (1, 1) NOT NULL,
    [NumOrder] INT NOT NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC)
);

