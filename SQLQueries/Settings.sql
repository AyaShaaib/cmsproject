USE [Test website]
GO

/****** Object:  Table [dbo].[Settings]    Script Date: 1/5/2021 3:39:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Settings](
	[SenderEmail] [nvarchar](255) NOT NULL,
	[RecieverEmail] [nvarchar](255) NOT NULL,
	[FacebookLink] [nvarchar](255) NOT NULL,
	[TwitterLink] [nvarchar](255) NOT NULL,
	[InstagramLink] [nvarchar](255) NOT NULL,
	[YoutubeLink] [nvarchar](255) NOT NULL,
	[Smtp] [nvarchar](50) NOT NULL,
	[SenderPassword] [nvarchar](255) NOT NULL,
	[SettingsId] [int] IDENTITY(1,1) NOT NULL,
	[salt] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Settings] PRIMARY KEY CLUSTERED 
(
	[SettingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

