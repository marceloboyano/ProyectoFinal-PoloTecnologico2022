﻿CREATE TABLE [dbo].[HistorialBolilleros](
	[FechaHora] [datetime2](7) NOT NULL,
	[NumeroBolilla] [int] NOT NULL,
 CONSTRAINT [PK_HistorialBolilleros] PRIMARY KEY CLUSTERED 
(
	[FechaHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


