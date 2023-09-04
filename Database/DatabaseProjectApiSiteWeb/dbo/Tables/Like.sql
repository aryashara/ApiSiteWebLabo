CREATE TABLE [dbo].[Like] (
    [ID]            INT IDENTITY (1, 1) NOT NULL,
    [UtilisateurID] INT NULL,
    [ProjetID]      INT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([ProjetID]) REFERENCES [dbo].[Project] ([ID]),
    FOREIGN KEY ([UtilisateurID]) REFERENCES [dbo].[Utilisateur] ([ID])
);


GO

