USE [agenda_seminario_2013]
GO
/****** Object:  Table [dbo].[contactos]    Script Date: 09/05/2013 15:18:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[contactos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[apellido] [varchar](60) NOT NULL,
	[nombre] [varchar](60) NOT NULL,
	[dni] [int] NOT NULL,
 CONSTRAINT [PK_contactos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[contactos] ON
INSERT [dbo].[contactos] ([id], [apellido], [nombre], [dni]) VALUES (2, N'BOUTAS', N'MARTINIO', 232323)
INSERT [dbo].[contactos] ([id], [apellido], [nombre], [dni]) VALUES (3, N'BERTONA', N'JENIFER', 13131313)
INSERT [dbo].[contactos] ([id], [apellido], [nombre], [dni]) VALUES (4, N'BERTONA', N'JENIFER', 13131313)
INSERT [dbo].[contactos] ([id], [apellido], [nombre], [dni]) VALUES (5, N'FERRERO', N'EMILIANO', 14414144)
INSERT [dbo].[contactos] ([id], [apellido], [nombre], [dni]) VALUES (6, N'CASCO', N'DIEGO', 29230836)
SET IDENTITY_INSERT [dbo].[contactos] OFF
/****** Object:  StoredProcedure [dbo].[modificar_contacto]    Script Date: 09/05/2013 15:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[modificar_contacto]
	@id_mod INT,
	@ape VARCHAR(60),
	@nom VARCHAR(60),
	@dni INT 
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE contactos
	SET apellido=@ape,
	nombre=@nom,
	dni=@dni
	WHERE id=@id_mod
END
GO
/****** Object:  StoredProcedure [dbo].[insertar_contacto]    Script Date: 09/05/2013 15:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertar_contacto]
	@ape VARCHAR(60),
	@nom VARCHAR(60),
	@dni INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO contactos
	(apellido,nombre,dni)
	VALUES
	(@ape,@nom,@dni)	
END
GO
/****** Object:  StoredProcedure [dbo].[eliminar_contacto]    Script Date: 09/05/2013 15:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[eliminar_contacto]
	@id_eli INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	DELETE FROM contactos
	WHERE id=@id_eli
END
GO
