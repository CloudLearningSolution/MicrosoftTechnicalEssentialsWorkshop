
CREATE TABLE [dbo].[Inventory] (
    [DroneId] INT           IDENTITY (1, 1) NOT NULL,
    [Make]    NVARCHAR (50) NULL,
    [Color]   NVARCHAR (50) NULL,
    [PetName] NVARCHAR (50) NULL,
    CONSTRAINT [PK_dbo.Inventory] PRIMARY KEY CLUSTERED ([DroneId] ASC)
);