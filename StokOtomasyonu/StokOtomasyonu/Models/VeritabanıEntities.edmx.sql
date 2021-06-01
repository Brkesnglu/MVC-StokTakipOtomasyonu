
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/13/2020 13:52:59
-- Generated from EDMX file: D:\visual studio\StokOtomasyonu\StokOtomasyonu\StokOtomasyonu\Models\VeritabanıEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [StokOtomasyonDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[TBLURUNLERSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBLURUNLERSet];
GO
IF OBJECT_ID(N'[dbo].[TBLMUSTERILERSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBLMUSTERILERSet];
GO
IF OBJECT_ID(N'[dbo].[TBLKATEGORILERSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBLKATEGORILERSet];
GO
IF OBJECT_ID(N'[dbo].[TBLSATISLARSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TBLSATISLARSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'TBLURUNLERSet'
CREATE TABLE [dbo].[TBLURUNLERSet] (
    [URUNID] int IDENTITY(1,1) NOT NULL,
    [URUNAD] nvarchar(100)  NOT NULL,
    [URUNKATEGORI] nvarchar(50)  NOT NULL,
    [MARKA] nvarchar(50)  NOT NULL,
    [FIYAT] decimal(18,0)  NOT NULL,
    [STOK] int  NOT NULL
);
GO

-- Creating table 'TBLMUSTERILERSet'
CREATE TABLE [dbo].[TBLMUSTERILERSet] (
    [MUSTERIID] int IDENTITY(1,1) NOT NULL,
    [MUSTERIAD] nvarchar(50)  NOT NULL,
    [MUSTERISOYAD] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TBLKATEGORILERSet'
CREATE TABLE [dbo].[TBLKATEGORILERSet] (
    [KATEGORIID] int IDENTITY(1,1) NOT NULL,
    [KATEGORIAD] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'TBLSATISLARSet'
CREATE TABLE [dbo].[TBLSATISLARSet] (
    [SATISID] int IDENTITY(1,1) NOT NULL,
    [URUN] nvarchar(50)  NOT NULL,
    [MUSTERI] nvarchar(50)  NOT NULL,
    [ADET] int  NOT NULL,
    [FIYAT] decimal(18,0)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [URUNID] in table 'TBLURUNLERSet'
ALTER TABLE [dbo].[TBLURUNLERSet]
ADD CONSTRAINT [PK_TBLURUNLERSet]
    PRIMARY KEY CLUSTERED ([URUNID] ASC);
GO

-- Creating primary key on [MUSTERIID] in table 'TBLMUSTERILERSet'
ALTER TABLE [dbo].[TBLMUSTERILERSet]
ADD CONSTRAINT [PK_TBLMUSTERILERSet]
    PRIMARY KEY CLUSTERED ([MUSTERIID] ASC);
GO

-- Creating primary key on [KATEGORIID] in table 'TBLKATEGORILERSet'
ALTER TABLE [dbo].[TBLKATEGORILERSet]
ADD CONSTRAINT [PK_TBLKATEGORILERSet]
    PRIMARY KEY CLUSTERED ([KATEGORIID] ASC);
GO

-- Creating primary key on [SATISID] in table 'TBLSATISLARSet'
ALTER TABLE [dbo].[TBLSATISLARSet]
ADD CONSTRAINT [PK_TBLSATISLARSet]
    PRIMARY KEY CLUSTERED ([SATISID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------