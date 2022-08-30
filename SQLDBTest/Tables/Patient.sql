CREATE TABLE [dbo].[Patient]
(
	[Pat_ID] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Pat_Name] NVARCHAR(50) NOT NULL, 
    [Pat_Vorname] NVARCHAR(50) NOT NULL, 
    [Pat_GebDatum] DATE NOT NULL
)
