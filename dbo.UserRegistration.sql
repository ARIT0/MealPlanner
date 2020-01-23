CREATE TABLE [dbo].[UserRegistration] (
    [UserId]    INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NULL,
    [LastName]  VARCHAR (50) NULL,
    [Username]  VARCHAR (50) NULL,
    [Password]  VARCHAR (50) NULL,
    [Confirmpwd] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

