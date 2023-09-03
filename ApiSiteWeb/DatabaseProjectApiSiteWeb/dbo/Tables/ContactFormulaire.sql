CREATE TABLE [dbo].[ContactFormulaire] (
    [ID]           INT            IDENTITY (1, 1) NOT NULL,
    [Nom]          VARCHAR (255)  NULL,
    [AdresseEmail] VARCHAR (255)  NULL,
    [Objet]        VARCHAR (255)  NULL,
    [Message]      NVARCHAR (MAX) NULL,
    [DateEnvoi]    DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO

