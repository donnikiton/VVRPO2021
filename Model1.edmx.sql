
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/06/2022 13:07:14
-- Generated from EDMX file: C:\Users\ZloY_DeD\source\repos\DB_Kurs\DB_Kurs\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_Kurs];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_kinoseans_ass]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[seansSet] DROP CONSTRAINT [FK_kinoseans_ass];
GO
IF OBJECT_ID(N'[dbo].[FK_Bilet_polz]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BiletSet] DROP CONSTRAINT [FK_Bilet_polz];
GO
IF OBJECT_ID(N'[dbo].[FK_Biletseans]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[seansSet] DROP CONSTRAINT [FK_Biletseans];
GO
IF OBJECT_ID(N'[dbo].[FK_KinoteatrKinozal]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[KinozalSet] DROP CONSTRAINT [FK_KinoteatrKinozal];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[KinozalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KinozalSet];
GO
IF OBJECT_ID(N'[dbo].[seansSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[seansSet];
GO
IF OBJECT_ID(N'[dbo].[BiletSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BiletSet];
GO
IF OBJECT_ID(N'[dbo].[polzovatelSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[polzovatelSet];
GO
IF OBJECT_ID(N'[dbo].[KinoteatrSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[KinoteatrSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'KinozalSet'
CREATE TABLE [dbo].[KinozalSet] (
    [Id_kinozal] int IDENTITY(1,1) NOT NULL,
    [number] smallint  NOT NULL,
    [capasity] int  NOT NULL,
    [KinoteatrId_kinoteatr] int  NOT NULL
);
GO

-- Creating table 'seansSet'
CREATE TABLE [dbo].[seansSet] (
    [Id_seans] int IDENTITY(1,1) NOT NULL,
    [tame_date] datetime  NOT NULL,
    [KinozalId_kinozal] int  NOT NULL,
    [BiletId_bilet] int  NOT NULL
);
GO

-- Creating table 'BiletSet'
CREATE TABLE [dbo].[BiletSet] (
    [Id_bilet] int IDENTITY(1,1) NOT NULL,
    [polzovatelId_polzovatel] int  NOT NULL
);
GO

-- Creating table 'polzovatelSet'
CREATE TABLE [dbo].[polzovatelSet] (
    [Id_polzovatel] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [number_phone] bigint  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'KinoteatrSet'
CREATE TABLE [dbo].[KinoteatrSet] (
    [Id_kinoteatr] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id_kinozal] in table 'KinozalSet'
ALTER TABLE [dbo].[KinozalSet]
ADD CONSTRAINT [PK_KinozalSet]
    PRIMARY KEY CLUSTERED ([Id_kinozal] ASC);
GO

-- Creating primary key on [Id_seans] in table 'seansSet'
ALTER TABLE [dbo].[seansSet]
ADD CONSTRAINT [PK_seansSet]
    PRIMARY KEY CLUSTERED ([Id_seans] ASC);
GO

-- Creating primary key on [Id_bilet] in table 'BiletSet'
ALTER TABLE [dbo].[BiletSet]
ADD CONSTRAINT [PK_BiletSet]
    PRIMARY KEY CLUSTERED ([Id_bilet] ASC);
GO

-- Creating primary key on [Id_polzovatel] in table 'polzovatelSet'
ALTER TABLE [dbo].[polzovatelSet]
ADD CONSTRAINT [PK_polzovatelSet]
    PRIMARY KEY CLUSTERED ([Id_polzovatel] ASC);
GO

-- Creating primary key on [Id_kinoteatr] in table 'KinoteatrSet'
ALTER TABLE [dbo].[KinoteatrSet]
ADD CONSTRAINT [PK_KinoteatrSet]
    PRIMARY KEY CLUSTERED ([Id_kinoteatr] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [KinozalId_kinozal] in table 'seansSet'
ALTER TABLE [dbo].[seansSet]
ADD CONSTRAINT [FK_kinoseans_ass]
    FOREIGN KEY ([KinozalId_kinozal])
    REFERENCES [dbo].[KinozalSet]
        ([Id_kinozal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_kinoseans_ass'
CREATE INDEX [IX_FK_kinoseans_ass]
ON [dbo].[seansSet]
    ([KinozalId_kinozal]);
GO

-- Creating foreign key on [polzovatelId_polzovatel] in table 'BiletSet'
ALTER TABLE [dbo].[BiletSet]
ADD CONSTRAINT [FK_Bilet_polz]
    FOREIGN KEY ([polzovatelId_polzovatel])
    REFERENCES [dbo].[polzovatelSet]
        ([Id_polzovatel])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Bilet_polz'
CREATE INDEX [IX_FK_Bilet_polz]
ON [dbo].[BiletSet]
    ([polzovatelId_polzovatel]);
GO

-- Creating foreign key on [BiletId_bilet] in table 'seansSet'
ALTER TABLE [dbo].[seansSet]
ADD CONSTRAINT [FK_Biletseans]
    FOREIGN KEY ([BiletId_bilet])
    REFERENCES [dbo].[BiletSet]
        ([Id_bilet])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Biletseans'
CREATE INDEX [IX_FK_Biletseans]
ON [dbo].[seansSet]
    ([BiletId_bilet]);
GO

-- Creating foreign key on [KinoteatrId_kinoteatr] in table 'KinozalSet'
ALTER TABLE [dbo].[KinozalSet]
ADD CONSTRAINT [FK_KinoteatrKinozal]
    FOREIGN KEY ([KinoteatrId_kinoteatr])
    REFERENCES [dbo].[KinoteatrSet]
        ([Id_kinoteatr])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KinoteatrKinozal'
CREATE INDEX [IX_FK_KinoteatrKinozal]
ON [dbo].[KinozalSet]
    ([KinoteatrId_kinoteatr]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------