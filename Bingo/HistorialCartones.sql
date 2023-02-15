CREATE TABLE [dbo].[HistorialCartones](
	[FechaHora] [datetime2](7) NOT NULL,
	[Carton1] [int] NULL,
	[Carton2] [int] NULL,
	[Carton3] [int] NULL,
	[Carton4] [int] NULL,
 CONSTRAINT [PK_HistorialCartones] PRIMARY KEY CLUSTERED 
(
	[FechaHora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO