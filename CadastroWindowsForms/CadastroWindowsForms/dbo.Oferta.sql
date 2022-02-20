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

