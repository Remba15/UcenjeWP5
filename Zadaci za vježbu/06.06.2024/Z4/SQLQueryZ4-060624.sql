use master
go
drop database if exists Samostan
go
create database Samostan
go
use Samostan;

create table Svecenici(
	sifra int not null primary key identity(1,1),
	ime varchar(50),
	prezime varchar(50),
	nadredeni int foreign key references Svecenici(sifra)
);

insert into Svecenici (ime, prezime, nadredeni) values
	('Renato', 'Kuna', null), ('Ivan', 'Ivanović', 1), ('Marko', 'Markić', 1);

select * from Svecenici;

update Svecenici set nadredeni=2 where ime='Marko' AND prezime='Markić';