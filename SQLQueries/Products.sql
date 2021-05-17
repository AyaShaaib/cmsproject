USE [Products]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 12/30/2020 1:12:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[ProductCategoryId] [int] NOT NULL,
	[SmallDescription] [varchar](50) NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Width] [float] NULL,
	[Height] [float] NULL,
	[Depth] [float] NULL,
	[AlbumId] [int] NULL,
	[SupplierId] [int] NULL,
	[BrandId] [int] NULL,
	[OldPrice] [float] NOT NULL,
	[NewPrice] [float] NOT NULL,
	[Percentage] [float] NOT NULL,
	[ProductTypeId] [int] NOT NULL,
	[ProductAvailabilityId] [int] NOT NULL,
	[LanguageID] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

