use master
go
drop database if exists Restoran
go
create database Restoran
go
use Restoran

create table Persons(
    ID int not null primary key identity(1,1),
    LastName varchar(50) not null,
    FirstName varchar(50) not null,
    Age int
);

create table Orders(
    OrderID int not null primary key identity(1,1),
    OrderNumber varchar(20),
    PersonID int foreign key references Persons(ID)
);

insert into Persons(LastName, FirstName, Age) values
    ('Kuna', 'Renato', 28), ('Marinković', 'Marin', 25), ('Ivanović', 'Ivana', 45);

select * from Persons;

insert into Orders(OrderNumber, PersonID) values
    ('56486487', 2), ('00154687', 1), ('549753164', 3)

select * from Orders;

update Persons set LastName='Kunović' where LastName='Kuna';

update Orders set OrderNumber='56486552' where PersonID=1;

delete from Orders where OrderNumber='549753164';