USE [annex]
GO

/****** Object:  Table [dbo].[Album]    Script Date: 12/18/2020 14:52:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Album](
	[AlbumID] [int] IDENTITY(1,1) NOT NULL,
	[EnglishAlbumName] [nvarchar](max) NULL,
	[ArabicAlbumName] [nvarchar](max) NULL,
	[OtherAlbumName] [nvarchar](max) NULL,
	[AlbumOrder] [int] NULL,
	[IsPublished] [bit] NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

