CREATE TABLE [dbo].[Patient_Aufenthalt]
(
	[PatAuf_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PatAuf_PatID] NVARCHAR(50) NOT NULL, 
    [PatAuf_ZID] NVARCHAR(50) NOT NULL, 
    [PatAuf_AufnahmeDatum] NVARCHAR(50) NOT NULL, 
    [PatAuf_EntlassDatum] NVARCHAR(50) NOT NULL
)
