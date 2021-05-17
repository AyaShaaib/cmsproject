USE [Test website]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 1/5/2021 3:40:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users](
	[salt] [nvarchar](255) NOT NULL,
	[Fname] [nvarchar](255) NOT NULL,
	[Lname] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[RoleID] [int] NULL,
	[AttemptsCount] [int] NULL,
	[IsLocked] [bit] NULL,
	[Code] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_AttemptsCount]  DEFAULT ((0)) FOR [AttemptsCount]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_IsLocked]  DEFAULT ((0)) FOR [IsLocked]
GO

ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [roleidfk] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [roleidfk]
GO

