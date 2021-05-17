USE [Products]
GO

/****** Object:  Table [dbo].[News]    Script Date: 12/30/2020 1:11:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[News](
	[NewsId] [int] IDENTITY(1,1) NOT NULL,
	[NewsTitle] [varchar](50) NOT NULL,
	[NewsSubtitle] [varchar](50) NOT NULL,
	[NewsDescription] [varchar](100) NOT NULL,
	[Creation_Date] [varchar](50) NOT NULL,
	[Published_Date] [varchar](50) NOT NULL,
	[Author_Id] [int] NOT NULL,
	[Source] [int] NOT NULL,
	[Break_News] [bit] NOT NULL,
	[Youtube_Url] [varchar](100) NULL,
	[First_AD] [varchar](100) NULL,
	[Second_AD] [varchar](100) NULL,
	[Third_AD] [varchar](100) NULL,
	[Fourth_AD] [varchar](100) NULL,
	[Fifth_AD] [varchar](100) NULL,
	[LanguageID] [int] NOT NULL,
	[Sixth_AD] [varchar](100) NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[NewsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

