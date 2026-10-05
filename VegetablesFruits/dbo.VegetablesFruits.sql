CREATE TABLE [dbo].[VegetablesFruits] (
    [Id]      INT           IDENTITY (1, 1) NOT NULL,
    [Name]    NVARCHAR (50) NOT NULL,
    [Type]    NVARCHAR (50) NOT NULL,
    [Color]   NVARCHAR (50) NOT NULL,
    [Calorie] INT DEFAULT (1) NOT NULL,
);
