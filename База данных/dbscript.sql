/****** Object:  Table [dbo].[status]    Script Date: 22.12.2020 20:46:57 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[status](
	[statusid] [int] IDENTITY(1,1) NOT NULL,
	[title] [nchar](20) NOT NULL,
 CONSTRAINT [PK_status] PRIMARY KEY CLUSTERED 
(
	[statusid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[managers]    Script Date: 22.12.2020 20:46:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[managers](
	[managerid] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[surname] [nchar](50) NOT NULL,
	[dateofbirth] [date] NOT NULL,
	[phonenumber] [nchar](20) NOT NULL,
	[salary] [smallmoney] NOT NULL,
	[brunchid] [int] NOT NULL,
 CONSTRAINT [PK_managers] PRIMARY KEY CLUSTERED 
(
	[managerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[managers]  WITH CHECK ADD  CONSTRAINT [FK_managers_brunches] FOREIGN KEY([brunchid])
REFERENCES [dbo].[brunches] ([brunchid])
GO

ALTER TABLE [dbo].[managers] CHECK CONSTRAINT [FK_managers_brunches]
GO


/****** Object:  Table [dbo].[contracts]    Script Date: 22.12.2020 20:46:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[contracts](
	[contractid] [int] IDENTITY(1,1) NOT NULL,
	[customerid] [int] NOT NULL,
	[managerid] [int] NOT NULL,
	[carid] [int] NOT NULL,
	[conclusiondate] [date] NOT NULL,
	[closingdate] [date] NOT NULL,
	[amount] [smallmoney] NOT NULL,
 CONSTRAINT [PK_contracts] PRIMARY KEY CLUSTERED 
(
	[contractid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[contracts]  WITH CHECK ADD  CONSTRAINT [FK_contracts_cars] FOREIGN KEY([carid])
REFERENCES [dbo].[cars] ([carid])
GO

ALTER TABLE [dbo].[contracts] CHECK CONSTRAINT [FK_contracts_cars]
GO

ALTER TABLE [dbo].[contracts]  WITH CHECK ADD  CONSTRAINT [FK_contracts_customers] FOREIGN KEY([customerid])
REFERENCES [dbo].[customers] ([customerid])
GO

ALTER TABLE [dbo].[contracts] CHECK CONSTRAINT [FK_contracts_customers]
GO

ALTER TABLE [dbo].[contracts]  WITH CHECK ADD  CONSTRAINT [FK_contracts_managers] FOREIGN KEY([managerid])
REFERENCES [dbo].[managers] ([managerid])
GO

ALTER TABLE [dbo].[contracts] CHECK CONSTRAINT [FK_contracts_managers]
GO


/****** Object:  Table [dbo].[customers]    Script Date: 22.12.2020 20:46:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customers](
	[customerid] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[surname] [nchar](50) NOT NULL,
	[dateofbirth] [date] NOT NULL,
	[phonenumber] [nchar](20) NOT NULL,
	[address] [nchar](150) NULL,
	[passport] [nchar](20) NOT NULL,
 CONSTRAINT [PK_customers] PRIMARY KEY CLUSTERED 
(
	[customerid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[cars]    Script Date: 22.12.2020 20:46:15 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cars](
	[carid] [int] IDENTITY(1,1) NOT NULL,
	[brand] [nchar](20) NOT NULL,
	[model] [nchar](20) NOT NULL,
	[yearofissue] [nchar](5) NOT NULL,
	[priceperday] [smallmoney] NOT NULL,
	[brunchid] [int] NOT NULL,
	[statusid] [int] NOT NULL,
 CONSTRAINT [PK_cars] PRIMARY KEY CLUSTERED 
(
	[carid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[cars]  WITH CHECK ADD  CONSTRAINT [FK_cars_brunches] FOREIGN KEY([brunchid])
REFERENCES [dbo].[brunches] ([brunchid])
GO

ALTER TABLE [dbo].[cars] CHECK CONSTRAINT [FK_cars_brunches]
GO

ALTER TABLE [dbo].[cars]  WITH CHECK ADD  CONSTRAINT [FK_cars_status] FOREIGN KEY([statusid])
REFERENCES [dbo].[status] ([statusid])
GO

ALTER TABLE [dbo].[cars] CHECK CONSTRAINT [FK_cars_status]
GO


/****** Object:  Table [dbo].[brunches]    Script Date: 22.12.2020 20:45:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[brunches](
	[brunchid] [int] IDENTITY(1,1) NOT NULL,
	[address] [nchar](150) NOT NULL,
	[contactphone] [nchar](20) NULL,
 CONSTRAINT [PK_brunches] PRIMARY KEY CLUSTERED 
(
	[brunchid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table [dbo].[access]    Script Date: 22.12.2020 20:45:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[access](
	[id] [int] IDENTITY (1,1) NOT NULL,
	[managerid] [int] NOT NULL,
	[login] [nchar](20) NOT NULL,
	[password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_access] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[access]  WITH CHECK ADD  CONSTRAINT [FK_access_managers] FOREIGN KEY([managerid])
REFERENCES [dbo].[managers] ([managerid])
GO

ALTER TABLE [dbo].[access] CHECK CONSTRAINT [FK_access_managers]
GO






