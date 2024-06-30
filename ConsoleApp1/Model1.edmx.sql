
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/27/2024 19:01:34
-- Generated from EDMX file: C:\Users\Nadya\source\repos\Introduction_ADO_net\ConsoleApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Publisher];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AuthorBook]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BookSet] DROP CONSTRAINT [FK_AuthorBook];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryAuthor]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AuthorSet] DROP CONSTRAINT [FK_CountryAuthor];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryPublisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublisherSet] DROP CONSTRAINT [FK_CountryPublisher];
GO
IF OBJECT_ID(N'[dbo].[FK_BookPublisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PublisherSet] DROP CONSTRAINT [FK_BookPublisher];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryCities]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CitiesSet] DROP CONSTRAINT [FK_CountryCities];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[AuthorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorSet];
GO
IF OBJECT_ID(N'[dbo].[BookSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BookSet];
GO
IF OBJECT_ID(N'[dbo].[CountrySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CountrySet];
GO
IF OBJECT_ID(N'[dbo].[PublisherSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PublisherSet];
GO
IF OBJECT_ID(N'[dbo].[CitiesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CitiesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AuthorSet'
CREATE TABLE [dbo].[AuthorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FN] nvarchar(max)  NOT NULL,
    [LN] nvarchar(50)  NOT NULL,
    [CountryId] int  NOT NULL
);
GO

-- Creating table 'BookSet'
CREATE TABLE [dbo].[BookSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Page] int  NOT NULL,
    [Price] decimal(18,0)  NOT NULL,
    [AuthorId] int  NOT NULL
);
GO

-- Creating table 'CountrySet'
CREATE TABLE [dbo].[CountrySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameCountry] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'PublisherSet'
CREATE TABLE [dbo].[PublisherSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PublisherName] nvarchar(30)  NOT NULL,
    [CountryId] int  NOT NULL,
    [BookId] int  NOT NULL
);
GO

-- Creating table 'CitiesSet'
CREATE TABLE [dbo].[CitiesSet] (
    [Id] int  NOT NULL,
    [CityName] nvarchar(50)  NOT NULL,
    [CountryId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [PK_AuthorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [PK_BookSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CountrySet'
ALTER TABLE [dbo].[CountrySet]
ADD CONSTRAINT [PK_CountrySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PublisherSet'
ALTER TABLE [dbo].[PublisherSet]
ADD CONSTRAINT [PK_PublisherSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CitiesSet'
ALTER TABLE [dbo].[CitiesSet]
ADD CONSTRAINT [PK_CitiesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [AuthorId] in table 'BookSet'
ALTER TABLE [dbo].[BookSet]
ADD CONSTRAINT [FK_AuthorBook]
    FOREIGN KEY ([AuthorId])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorBook'
CREATE INDEX [IX_FK_AuthorBook]
ON [dbo].[BookSet]
    ([AuthorId]);
GO

-- Creating foreign key on [CountryId] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [FK_CountryAuthor]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[CountrySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryAuthor'
CREATE INDEX [IX_FK_CountryAuthor]
ON [dbo].[AuthorSet]
    ([CountryId]);
GO

-- Creating foreign key on [CountryId] in table 'PublisherSet'
ALTER TABLE [dbo].[PublisherSet]
ADD CONSTRAINT [FK_CountryPublisher]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[CountrySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryPublisher'
CREATE INDEX [IX_FK_CountryPublisher]
ON [dbo].[PublisherSet]
    ([CountryId]);
GO

-- Creating foreign key on [BookId] in table 'PublisherSet'
ALTER TABLE [dbo].[PublisherSet]
ADD CONSTRAINT [FK_BookPublisher]
    FOREIGN KEY ([BookId])
    REFERENCES [dbo].[BookSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BookPublisher'
CREATE INDEX [IX_FK_BookPublisher]
ON [dbo].[PublisherSet]
    ([BookId]);
GO

-- Creating foreign key on [CountryId] in table 'CitiesSet'
ALTER TABLE [dbo].[CitiesSet]
ADD CONSTRAINT [FK_CountryCities]
    FOREIGN KEY ([CountryId])
    REFERENCES [dbo].[CountrySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryCities'
CREATE INDEX [IX_FK_CountryCities]
ON [dbo].[CitiesSet]
    ([CountryId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------