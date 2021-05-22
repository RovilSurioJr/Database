CREATE TABLE [dbo].[Benefactors]
(
	[benefactor_No] INT NOT NULL PRIMARY KEY, 
    [surname] NVARCHAR(50) NOT NULL, 
    [first_name] NVARCHAR(50) NOT NULL, 
    [middle_name] NVARCHAR(50) NOT NULL, 
    [email] NVARCHAR(50) NOT NULL, 
    [phone_no] INT NOT NULL, 
    [address] NVARCHAR(50) NOT NULL, 
    [isActive] BIT NOT NULL
)
