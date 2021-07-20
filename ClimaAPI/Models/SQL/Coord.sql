USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Clima')) 
BEGIN
	CREATE DATABASE [Clima]
END

USE [Clima]
GO

/****** Object:  Table [dbo].[Coord]    Script Date: 19/07/2021 06:23:36 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Coord](
	[idCiudad] [int] NOT NULL,
	[lat] [float] NULL,
	[lon] [float] NULL,
 CONSTRAINT [PK_coord] PRIMARY KEY CLUSTERED 
(
	[idCiudad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Coord]  WITH CHECK ADD  CONSTRAINT [FK_coord_city] FOREIGN KEY([idCiudad])
REFERENCES [dbo].[City] ([id])
GO

ALTER TABLE [dbo].[Coord] CHECK CONSTRAINT [FK_coord_city]
GO

