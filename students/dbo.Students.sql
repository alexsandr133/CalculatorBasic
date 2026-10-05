CREATE TABLE [dbo].[Students] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Name]       NVARCHAR (50) NOT NULL,
    [GroupName]  NVARCHAR (50) NOT NULL,
    [Grade]      FLOAT (53)    NULL,
    [MinSubject] NVARCHAR (50) NULL,
    [MaxSubject] NVARCHAR (50) NULL
);