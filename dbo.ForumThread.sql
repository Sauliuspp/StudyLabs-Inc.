CREATE TABLE [dbo].[ForumThread]
(
	[Id]		INT				IDENTITY (1, 1) NOT NULL,
    [Question]	NVARCHAR (255)	NULL,
    [Author]	NVARCHAR (255)	NULL,
    [Time]		DATETIME		NOT NULL,
	PRIMARY KEY CLUSTERED ([Id] ASC)
)
