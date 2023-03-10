USE [opSWOTDB]
GO
/****** Object:  StoredProcedure [dbo].[GetTickets]    Script Date: 01.02.2023 14:09:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[GetClientTickets]
@ClientId int

AS
BEGIN

	SET NOCOUNT ON;

	select t.Id TicketID,
	(c.LastName +' '+ c.FirstName +' '+ c.MiddleName) ClientFullName,
	t.Price TicketPrice,
	cf.Name FromCity,
	ct.Name ToCity,
	t.DepartureTime,
	t.ArrivalTime
	
	from Tickets t
	join Clients c on c.Id = t.ClientId
	join City cf on cf.id = t.FromCity
	join City ct on ct.id = t.ToCity
	where c.Id = @ClientId

END
