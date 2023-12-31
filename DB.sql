USE [Test]
GO
/****** Object:  Table [dbo].[tblCarManagement]    Script Date: 9/25/2023 10:22:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCarManagement](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](max) NULL,
	[ModelName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Feacture] [nvarchar](max) NULL,
	[Price] [nvarchar](max) NULL,
	[DOM] [nvarchar](max) NULL,
	[Active] [bit] NULL,
	[SortOrder] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
 CONSTRAINT [PK_tblCarManagement] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
