USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Clima')) 
BEGIN
	CREATE DATABASE [Clima]
END

USE [Clima]
GO

/****** Object:  Table [dbo].[weather]    Script Date: 16/07/2021 08:20:30 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[weather](
	[id] [int] NULL,
	[main] [varchar](50) NULL,
	[description] [varchar](50) NULL,
	[cityid] [int] NULL
) ON [PRIMARY]
GO



