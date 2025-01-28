CREATE TABLE [dbo].[User] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [Username]  NVARCHAR (MAX) NOT NULL,
    [Password]  NVARCHAR (MAX) NOT NULL,
    [Email]     NVARCHAR (MAX) NOT NULL,
    [Birthdate] DATETIME2 (7)  NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
	[Question1] NVARCHAR (MAX) NULL,
    [Answer1]   NVARCHAR (MAX) NULL,
    [Question2] NVARCHAR (MAX) NULL,
    [Answer2]   NVARCHAR (MAX) NULL,
    [Question3] NVARCHAR (MAX) NULL,
    [Answer3]   NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([Id] ASC)
);

