CREATE TABLE [dbo].[Zimmer]
(
	[Z_ID] INT NOT NULL PRIMARY KEY, 
    [Z_BettID] INT NOT NULL, 
    [Z_StatID] INT NOT NULL, 
    [Z_ZimmerNummer] NVARCHAR(50) NOT NULL
)
