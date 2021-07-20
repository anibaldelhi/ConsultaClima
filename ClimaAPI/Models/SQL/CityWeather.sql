USE [master]
GO

IF NOT EXISTS (SELECT * FROM sysdatabases WHERE (name = 'Clima')) 
BEGIN
	CREATE DATABASE [Clima]
END

USE [Clima]
GO

/****** Object:  Table [dbo].[CityWeather]    Script Date: 19/07/2021 06:18:25 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE TABLE [dbo].[CityWeather](
	[Cityid] [int] NOT NULL,
	[Weatherid] [int] NOT NULL,
 CONSTRAINT [PK_CityWeather] PRIMARY KEY CLUSTERED 
(
	[Cityid] ASC,
	[Weatherid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[CityWeather]  WITH CHECK ADD  CONSTRAINT [FK_CityWeather_City] FOREIGN KEY([Cityid])
REFERENCES [dbo].[City] ([id])
GO

ALTER TABLE [dbo].[CityWeather] CHECK CONSTRAINT [FK_CityWeather_City]
GO

ALTER TABLE [dbo].[CityWeather]  WITH CHECK ADD  CONSTRAINT [FK_CityWeather_Weather] FOREIGN KEY([Weatherid])
REFERENCES [dbo].[Weather] ([id])
GO

ALTER TABLE [dbo].[CityWeather] CHECK CONSTRAINT [FK_CityWeather_Weather]
GO