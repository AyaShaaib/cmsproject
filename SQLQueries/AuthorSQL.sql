USE [annex]
GO

/****** Object:  Table [dbo].[Author]    Script Date: 12/18/2020 14:52:58 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Author](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[AuthorName] [nvarchar](max) NULL,
	[AuthorJobTitle] [nvarchar](max) NULL,
	[AuthorAddress] [nvarchar](max) NULL,
	[AuthorEmail] [nvarchar](max) NULL,
	[AuthorWebsite] [nvarchar](max) NULL,
	[AuthorPicture] [nvarchar](max) NULL,
	[AuthorLinkedIn] [nvarchar](max) NULL,
	[AuthorFacebook] [nvarchar](max) NULL,
	[AuthorTwitter] [nvarchar](max) NULL,
	[AuthorInstagram] [nvarchar](max) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

