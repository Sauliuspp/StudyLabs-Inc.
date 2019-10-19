CREATE TABLE [dbo].[StuddyBuddy] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Nickname] NVARCHAR (255) NULL,
    [Facebook] NVARCHAR (255) NULL,
    [Faculty]  NVARCHAR (255) NULL,
    [Studies]  NVARCHAR (255) NULL,
	[Status]   NVARCHAR (255) NULL,
	[Points]   INT			  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

