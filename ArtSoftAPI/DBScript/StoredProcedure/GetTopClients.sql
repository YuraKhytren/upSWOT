USE [opSWOTDB]
GO
/****** Object:  StoredProcedure [dbo].[GetTickets]    Script Date: 01.02.2023 14:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[GetTopClients]

AS
BEGIN

	SET NOCOUNT ON;

	select top(3)count(t.Id) TicketCount, (c.LastName +' '+ c.FirstName +' '+ c.MiddleName) ClientFullName from Tickets t
	join Clients c on c.Id = t.ClientId
	group by (c.LastName +' '+ c.FirstName +' '+ c.MiddleName)
	order by count(t.Id) desc

END

