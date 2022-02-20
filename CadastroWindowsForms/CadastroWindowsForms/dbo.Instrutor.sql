CREATE TABLE [dbo].[Instrutor]
(
	[Id]                INT             IDENTITY (1, 1)  NOT NULL,
    [Nome]              NVARCHAR(MAX)                    NOT NULL,
    [CPF]               NVARCHAR(18)                     NOT NULL,
    [Endereco]          NVARCHAR(MAX)                        NULL,
    [Celular]           NVARCHAR(15)                         NULL,

    CONSTRAINT [PK_Instrutor] PRIMARY KEY CLUSTERED ([Id] ASC)
)
