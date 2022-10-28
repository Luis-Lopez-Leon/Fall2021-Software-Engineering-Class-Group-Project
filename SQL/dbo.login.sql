CREATE TABLE [dbo].[UserInfo]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [SSN] CHAR(10) NULL, 
    [Country] NVARCHAR(50) NULL, 
    [ZIP] CHAR(10) NULL, 
    [State] CHAR(10) NULL, 
    [City] CHAR(10) NULL, 
    [Phone] NCHAR(10) NULL
)
