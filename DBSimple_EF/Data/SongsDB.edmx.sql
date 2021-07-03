
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/01/2021 23:36:06
-- Generated from EDMX file: C:\Users\tony_skos\source\repos\DataBase\DBSimple_EF\Data\SongsDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SongsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TrackSet'
CREATE TABLE [dbo].[TrackSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Duration] nvarchar(max)  NOT NULL,
    [Artist_Id] int  NOT NULL
);
GO

-- Creating table 'ArtistSet'
CREATE TABLE [dbo].[ArtistSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'TrackSet'
ALTER TABLE [dbo].[TrackSet]
ADD CONSTRAINT [PK_TrackSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ArtistSet'
ALTER TABLE [dbo].[ArtistSet]
ADD CONSTRAINT [PK_ArtistSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Artist_Id] in table 'TrackSet'
ALTER TABLE [dbo].[TrackSet]
ADD CONSTRAINT [FK_ArtistTrack]
    FOREIGN KEY ([Artist_Id])
    REFERENCES [dbo].[ArtistSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ArtistTrack'
CREATE INDEX [IX_FK_ArtistTrack]
ON [dbo].[TrackSet]
    ([Artist_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------