SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServerFarm]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ServerFarm](
	[ServerFarmName] [varchar](50) NOT NULL,
	[ServerFarmAddress] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ServiceFarm] PRIMARY KEY CLUSTERED 
(
	[ServerFarmName] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientEndpoint]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClientEndpoint](
	[ServiceContractType] [varchar](50) NOT NULL,
	[ClientMachineIP] [varchar](50) NOT NULL CONSTRAINT [DF_ClientEndpoint_ClientMachineIP]  DEFAULT ('*'),
	[ClientEndpointBehaviorXml] [xml] NULL,
	[ServiceConfig] [xml] NULL,
 CONSTRAINT [PK_ClientEndpoint] PRIMARY KEY CLUSTERED 
(
	[ServiceContractType] ASC,
	[ClientMachineIP] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Binding]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Binding](
	[BindingName] [varchar](50) NOT NULL,
	[BindingType] [varchar](50) NOT NULL,
	[BindingPriority] [int] NOT NULL,
	[BindingXml] [xml] NULL,
	[BindingProtocol] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Binding] PRIMARY KEY CLUSTERED 
(
	[BindingName] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Service]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Service](
	[ServiceType] [varchar](100) NOT NULL,
	[ServiceBehaviorXml] [xml] NULL,
	[ServerFarmName] [varchar](50) NOT NULL,
	[ServiceConfig] [xml] NULL,
	[ServerMachineIP] [varchar](50) NOT NULL CONSTRAINT [DF_Service_ServerMachineIP]  DEFAULT ('*'),
 CONSTRAINT [PK_Service_1] PRIMARY KEY CLUSTERED 
(
	[ServiceType] ASC,
	[ServerMachineIP] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Service]') AND name = N'IX_ServerFarmName')
CREATE NONCLUSTERED INDEX [IX_ServerFarmName] ON [dbo].[Service] 
(
	[ServerFarmName] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[Service]') AND name = N'IX_ServerMachineName')
CREATE NONCLUSTERED INDEX [IX_ServerMachineName] ON [dbo].[Service] 
(
	[ServerMachineIP] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ClientAccess]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ClientAccess](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ClientMachineIP] [varchar](50) NOT NULL CONSTRAINT [DF_ClientAccess_ClientMachineIP]  DEFAULT ('*'),
	[AccessServerFarmName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ClientAccess] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ClientAccess]') AND name = N'IX_AccessServerFarmName')
CREATE NONCLUSTERED INDEX [IX_AccessServerFarmName] ON [dbo].[ClientAccess] 
(
	[AccessServerFarmName] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ClientAccess]') AND name = N'IX_ClientMachineName')
CREATE NONCLUSTERED INDEX [IX_ClientMachineName] ON [dbo].[ClientAccess] 
(
	[ClientMachineIP] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ServiceEndpoint]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ServiceEndpoint](
	[ServiceContractType] [varchar](50) NOT NULL,
	[ServiceContractVersion] [varchar](10) NOT NULL CONSTRAINT [DF_ServiceEndpoint_ServiceContractVersion]  DEFAULT ((1.0)),
	[ServerMachineIP] [varchar](50) NOT NULL CONSTRAINT [DF_ServiceEndpoint_ServerMachineIP]  DEFAULT ('*'),
	[ServiceType] [varchar](100) NOT NULL,
	[ServiceEndpointBehaviorXml] [xml] NULL,
	[ServiceEndpointBindingName] [varchar](50) NOT NULL,
	[ServiceEndpointPort] [int] NOT NULL,
	[ServiceEndpointName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ServiceEndpoint_1] PRIMARY KEY CLUSTERED 
(
	[ServiceContractType] ASC,
	[ServiceContractVersion] ASC,
	[ServerMachineIP] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ServiceEndpoint]') AND name = N'IX_ServiceContractType')
CREATE NONCLUSTERED INDEX [IX_ServiceContractType] ON [dbo].[ServiceEndpoint] 
(
	[ServiceContractType] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE object_id = OBJECT_ID(N'[dbo].[ServiceEndpoint]') AND name = N'IX_ServiceType')
CREATE NONCLUSTERED INDEX [IX_ServiceType] ON [dbo].[ServiceEndpoint] 
(
	[ServiceType] ASC
)WITH (IGNORE_DUP_KEY = OFF) ON [PRIMARY]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Service_ServerFarm]') AND parent_object_id = OBJECT_ID(N'[dbo].[Service]'))
ALTER TABLE [dbo].[Service]  WITH NOCHECK ADD  CONSTRAINT [FK_Service_ServerFarm] FOREIGN KEY([ServerFarmName])
REFERENCES [dbo].[ServerFarm] ([ServerFarmName])
NOT FOR REPLICATION 
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ClientAccess_ClientAccess]') AND parent_object_id = OBJECT_ID(N'[dbo].[ClientAccess]'))
ALTER TABLE [dbo].[ClientAccess]  WITH NOCHECK ADD  CONSTRAINT [FK_ClientAccess_ClientAccess] FOREIGN KEY([AccessServerFarmName])
REFERENCES [dbo].[ServerFarm] ([ServerFarmName])
NOT FOR REPLICATION 
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ServiceEndpoint_Binding]') AND parent_object_id = OBJECT_ID(N'[dbo].[ServiceEndpoint]'))
ALTER TABLE [dbo].[ServiceEndpoint]  WITH NOCHECK ADD  CONSTRAINT [FK_ServiceEndpoint_Binding] FOREIGN KEY([ServiceEndpointBindingName])
REFERENCES [dbo].[Binding] ([BindingName])
NOT FOR REPLICATION 
