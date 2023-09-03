CREATE TABLE [dbo].[Project] (
    [ID]           INT           IDENTITY (1, 1) NOT NULL,
    [Title]        VARCHAR (255) NULL,
    [Description]  VARCHAR (MAX) NULL,
    [CreationDate] DATETIME      NULL,
    [Medialink]    VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO

