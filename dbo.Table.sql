CREATE TABLE [dbo].[Table] (
    [Id]         INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]     VARCHAR (50) NOT NULL,
    [Contraseña] VARCHAR (50) NOT NULL,
    [Sexo]       NCHAR (10)   NOT NULL,
    [Correo]     VARCHAR (50) NOT NULL,
    [Teléfono]   VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC
	INSERT INTO "Table"("Nombre","Contraseña","Correo","Teléfono")
	VALUES("gerente","123","gerente2@gmail.com","72533630")
);

