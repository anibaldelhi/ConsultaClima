USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Clima')) 
BEGIN
	CREATE DATABASE [Clima]
END

USE [Clima]
GO

/****** Object:  Table [dbo].[city]    Script Date: 16/07/2021 08:15:01 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[City](
	[id] [int] NOT NULL,
	[name] [varchar](500) NULL,
	[timezone] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


