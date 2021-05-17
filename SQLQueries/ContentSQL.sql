USE [annex]
GO

/****** Object:  Table [dbo].[Content]    Script Date: 1/29/2021 20:36:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Content](
	[ContentID] [int] IDENTITY(1,1) NOT NULL,
	[ContentTitle] [nvarchar](max) NOT NULL,
	[ContentSubTitle] [nvarchar](max) NOT NULL,
	[PublishedDate] [date] NOT NULL,
	[IsPublished] [bit] NOT NULL,
	[LanguageID] [int] NOT NULL,
	[MenuID] [int] NOT NULL,
	[AlbumID] [int] NOT NULL,
	[AuthorID] [int] NOT NULL,
	[ContentCategoryID] [int] NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NOT NULL,
	[MetaTitle] [nvarchar](max) NOT NULL,
	[MetaKeyword] [nvarchar](max) NOT NULL,
	[MetaDescription] [nvarchar](max) NOT NULL,
	[UploadContentImage] [nvarchar](max) NOT NULL,
	[UploadContentFile] [nvarchar](max) NOT NULL,
	[UploadThumbnailContentImage] [nvarchar](max) NOT NULL,
	[Summary] [nvarchar](max) NOT NULL,
	[CustomText1] [nvarchar](max) NOT NULL,
	[CustomText2] [nvarchar](max) NOT NULL,
	[CustomText3] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Content] PRIMARY KEY CLUSTERED 
(
	[ContentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Content_Album] FOREIGN KEY([AlbumID])
REFERENCES [dbo].[Album] ([AlbumID])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Content_Album]
GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Content_Author] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Content_Author]
GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Content_Categories] FOREIGN KEY([ContentCategoryID])
REFERENCES [dbo].[Categories] ([CategoryId])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Content_Categories]
GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Content_Language] FOREIGN KEY([LanguageID])
REFERENCES [dbo].[Language] ([LanguageID])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Content_Language]
GO

ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [FK_Content_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[Menu] ([MenuID])
GO

ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [FK_Content_Menu]
GO


