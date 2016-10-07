CREATE TABLE [dbo].[LoanStore]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [DataPName] NVARCHAR(300) NOT NULL, 
    [LoanData] NVARCHAR(MAX) NOT NULL, 
    [LoadedDate] DATETIME NOT NULL, 
    [AnalyzedDataPName] NVARCHAR(300) NULL
)
