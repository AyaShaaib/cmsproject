USE [Products]
GO

/****** Object:  Table [dbo].[Language]    Script Date: 12/23/2020 8:20:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Language](
	[LanguageID] [int] IDENTITY(1,1) NOT NULL,
	[LanguageTitle] [nvarchar](max) NOT NULL,
	[LanguageSuffix] [nvarchar](max) NOT NULL,
	[DefaultLanguage] [bit] NOT NULL,
 CONSTRAINT [PK__Lang__C65557212334AA05] PRIMARY KEY CLUSTERED 
(
	[LanguageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

