USE [annex]
GO

/****** Object:  Table [dbo].[Menu]    Script Date: 1/29/2021 08:52:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NOT NULL,
	[Picture] [nvarchar](max) NOT NULL,
	[LanguageID] [int] NOT NULL,
	[DirectionID] [int] NOT NULL,
	[ParentID] [int] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[MenuOrder] [int] NOT NULL,
	[MetaTitle] [nvarchar](max) NOT NULL,
	[MetaKeyword] [nvarchar](max) NOT NULL,
	[MetaDescription] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK__Menu__3214EC270BB467E2] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Direction] FOREIGN KEY([DirectionID])
REFERENCES [dbo].[Direction] ([DirectionID])
GO

ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Direction]
GO

ALTER TABLE [dbo].[Menu]  WITH CHECK ADD  CONSTRAINT [FK_Menu_Language] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Language] ([LanguageID])
GO

ALTER TABLE [dbo].[Menu] CHECK CONSTRAINT [FK_Menu_Language]
GO


