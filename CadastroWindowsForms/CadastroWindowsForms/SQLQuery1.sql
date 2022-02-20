CREATE TABLE [dbo].[Habilitacao] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Habilitacao]    NVARCHAR (MAX) NOT NULL,
    [CargaHoraria]   INT            NOT NULL,
    [DataVencimento] DATETIME       NOT NULL,
    [Instituicao]    NVARCHAR (MAX) NOT NULL,
    [Id_Instrutor]   INT            NOT NULL,
    CONSTRAINT [PK_Habilitacao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Habilitacao_Instrutor] FOREIGN KEY ([Id_Instrutor]) REFERENCES [dbo].[Instrutor] ([Id])
);

CREATE TABLE [dbo].[Instrutor]
(
	[Id]                INT             IDENTITY (1, 1)  NOT NULL,
    [Nome]              NVARCHAR(MAX)                    NOT NULL,
    [CPF]               NVARCHAR(18)                     NOT NULL,
    [Endereco]          NVARCHAR(MAX)                        NULL,
    [Celular]           NVARCHAR(15)                         NULL,

    CONSTRAINT [PK_Instrutor] PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Oferta] (
    [Id]             INT          IDENTITY (1, 1) NOT NULL,
    [DataInicial]    DATETIME     NOT NULL,
    [DataFinal]      DATETIME     NOT NULL,
    [SituacaoOferta] INT          NOT NULL,
    [Curso]          VARCHAR (50) NOT NULL,
    [Id_Instrutor]   INT          NOT NULL,
    CONSTRAINT [PK_Oferta] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Oferta_Instrutor] FOREIGN KEY ([Id_Instrutor]) REFERENCES [dbo].[Instrutor] ([Id])
);





