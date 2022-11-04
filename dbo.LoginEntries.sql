CREATE TABLE [dbo].[LoginEntries]
(
	[ID] INT NOT NULL PRIMARY KEY  IDENTITY, 
    [Username] NVARCHAR(50) NOT NULL, 
    [Email] NVARCHAR(MAX) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL, 
    [Is_RelationshipManager] INT NOT NULL DEFAULT 0
)
