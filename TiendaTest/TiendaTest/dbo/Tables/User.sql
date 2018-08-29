CREATE TABLE [dbo].[User] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [Nombre]   NVARCHAR (50) NOT NULL,
    [Apellido] NVARCHAR (50) NOT NULL,
    [Cedula]   INT           NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([id] ASC)
);

