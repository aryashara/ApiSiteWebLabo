CREATE TABLE [dbo].[MessageForum] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [Sujet]           VARCHAR (255)  NULL,
    [Message]         NVARCHAR (MAX) NULL,
    [DatePublication] DATETIME       NULL,
    [UtilisateurID]   INT            NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[Utilisateur] ([ID])
);


GO

