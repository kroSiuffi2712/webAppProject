USE [Restaurant]
GO

ALTER TABLE [dbo].[Content] DROP CONSTRAINT [FK_Section_Type]
GO

/****** Object:  Table [dbo].[Content]     ******/
DROP TABLE [dbo].[Content]
GO

/****** Object:  Table [dbo].[Content]     ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Content](
	[Id] [int] NOT NULL,
	[IdSection] [int] NULL,
	[Title] [nvarchar](50) NULL,
	[Image] [nvarchar](500) NULL,
	[Description] [nvarchar](2500) NULL,
	[Order] [int] NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Section_Type] FOREIGN KEY([IdSection])
REFERENCES [dbo].[Section] ([Id])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Section_Type]
GO


/****** Object:  Table [dbo].[Section]     ******/
DROP TABLE [dbo].[Section]
GO

/****** Object:  Table [dbo].[Section]     ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Section](
	[Id] [int] NOT NULL,
	[Title] [nvarchar](10) NOT NULL,
	[Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
