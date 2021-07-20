USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Clima')) 
BEGIN
	CREATE DATABASE [Clima]
END

USE [Clima]
GO

/****** Object:  Table [dbo].[Weather]    Script Date: 19/07/2021 06:26:53 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Weather](
	[id] [int] NOT NULL,
	[main] [varchar](50) NULL,
	[description] [varchar](50) NULL,
 CONSTRAINT [PK_weathers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


