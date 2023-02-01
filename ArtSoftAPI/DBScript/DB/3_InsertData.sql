USE opSWOTDB

INSERT INTO Clients(FirstName,MiddleName,LastName,Gender,PassportSer,PassportNum,Age,Phone,Email,Status,Created,Changed)
VALUES ('Ivan','Stepanovich','Duchak' ,'M','II',505050, 35, 0968699088, 'Ivan@gmail.com',1, cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Stepan','Stepanovich','Ivanchenko' ,'M','KK',606060, 30, 0968678088, 'Stepan@gmail.com',2, cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Anna','Viktorivna','Bulka' ,'F','MM',353502, 40, 0968678077, 'Anna@gmail.com',3, cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Iryna','Pavlivna','Comar' ,'F','YS',431050, 20, 0968558088, 'Iryna@gmail.com',1, cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Oleh','Stepanovich','Chmyt' ,'M','TI',55060, 43, 0968673388, 'Oleh@gmail.com',3, cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO ClientsStatus(Description,Created,Changed)
VALUES ('Active client', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Locked client', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Identification is required', cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO Countries(Name,Created,Changed)
VALUES ('Spain', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Germany', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Poland', cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO City(Name,CountryId,Created,Changed)
VALUES ('Barcelona', 1,cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Madrid',1, cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Valencia',1, cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Dresden', 2,cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Munhen',2, cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Dortmund',2, cast(getdate() as datetime) , cast(getdate() as datetime)),
	   ('Warsawa', 3,cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Opole',3, cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Lodz',3, cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO TicketStatus(Description,Created,Changed)
VALUES ('Acting', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Not acting', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Overdue', cast(getdate() as datetime) , cast(getdate() as datetime))

INSERT INTO Currency(Name, ShortName,Created,Changed)
VALUES ('Gryvnya','UAH', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Dolar','USD', cast(getdate() as datetime) , cast(getdate() as datetime)),
       ('Euro', 'EUR',cast(getdate() as datetime) , cast(getdate() as datetime))



INSERT INTO Tickets(ClientId, Price,CurrencyId,DepartureTime,ArrivalTime,FromCity,ToCity,TicketStatus,Created,Changed)
VALUES(1,500,1,cast(getdate() as datetime) , cast(getdate() as datetime), 4,5,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (1,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 5,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (1,600,3,cast(getdate() as datetime) , cast(getdate() as datetime), 3,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (2,500,1,cast(getdate() as datetime) , cast(getdate() as datetime), 4,5,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (2,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 5,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (2,600,3,cast(getdate() as datetime) , cast(getdate() as datetime), 3,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (3,500,1,cast(getdate() as datetime) , cast(getdate() as datetime), 4,5,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (3,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 5,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (3,600,3,cast(getdate() as datetime) , cast(getdate() as datetime), 3,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (4,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 5,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (4,600,3,cast(getdate() as datetime) , cast(getdate() as datetime), 3,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (5,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 5,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (5,600,3,cast(getdate() as datetime) , cast(getdate() as datetime), 3,2,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (1,500,1,cast(getdate() as datetime) , cast(getdate() as datetime), 1,5,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (2,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 3,4,1,cast(getdate() as datetime) , cast(getdate() as datetime)),
	  (2,1000,2,cast(getdate() as datetime) , cast(getdate() as datetime), 2,1,1,cast(getdate() as datetime) , cast(getdate() as datetime))
	







