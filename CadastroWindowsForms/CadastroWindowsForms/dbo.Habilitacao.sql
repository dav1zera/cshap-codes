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

