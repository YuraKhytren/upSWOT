USE opSWOTDB

CREATE TABLE Clients(
Id int IDENTITY(1,1) primary key not null,
FirstName varchar(50),
MiddleName varchar(50),
LastName varchar(50),
Gender varchar(1),
PassportSer varchar(10),
PassportNum int,
Age int,
Phone int,
Email varchar(100) NOT NULL UNIQUE,
Status int,
Created datetime,
Changed datetime
)

CREATE TABLE ClientsStatus(
Id int IDENTITY(1,1) primary key not null,
Description varchar(250),
Created datetime,
Changed datetime
)

CREATE TABLE Tickets(
Id int IDENTITY(1,1) primary key not null,
Price int,
CurrencyId int,
ClientId int,
DepartureTime datetime,
ArrivalTime datetime,
FromCity int,
ToCity int,
TicketStatus int,
Created datetime,
Changed datetime
)

CREATE TABLE TicketStatus(
Id int IDENTITY(1,1) primary key not null,
Description varchar(250),
Created datetime,
Changed datetime
)

CREATE TABLE Currency(
Id int IDENTITY(1,1) primary key not null,
Name varchar(50),
ShortName varchar(3),
Created datetime,
Changed datetime
)

CREATE TABLE Countries(
Id int IDENTITY(1,1) primary key not null,
Name varchar(250),
Created datetime,
Changed datetime
)

CREATE TABLE Ñity(
Id int IDENTITY(1,1) primary key not null,
CountryId int,
Name varchar(250),
Created datetime,
Changed datetime
)