﻿CREATE TABLE [dbo].[Category] (
    [Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Categoria] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([Id] ASC)
);

