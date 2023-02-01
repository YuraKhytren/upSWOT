USE [opSWOTDB]
GO
/****** Object:  StoredProcedure [dbo].[GetTickets]    Script Date: 01.02.2023 14:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[LastFiveSoldTickets]

AS
BEGIN

	SET NOCOUNT ON;

	select top(5)* from Tickets t
	order by t.Id desc

END
