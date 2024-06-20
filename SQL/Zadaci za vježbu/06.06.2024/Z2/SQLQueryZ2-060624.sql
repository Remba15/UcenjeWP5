use master
go
drop database if exists Webshop
go
create database Webshop
go
use Webshop;

create table Proizvodi(
    sifra int not null primary key identity(1,1),
    naziv varchar(50) not null,
    datumNabave DATETIME,
    cijena decimal (18,2),
    aktivan bit not null
);

create table Kupci(
    sifra int not null primary key identity(1,1),
    ime varchar(50) not null,
    prezime varchar(50) not null,
    ulica varchar(50),
    mjesto varchar(50)
);

create table Racuni(
    sifra int not null primary key identity(1,1),
    datum DATETIME,
    kupac int not null foreign key references Kupci(sifra),
    statusRacuna varchar(50)
);

create table Stavke(
    racun int not null foreign key references Racuni(sifra),
    proizvod int not null foreign key references Proizvodi(sifra),
    kolicina int,
    cijena decimal(18,2)
);

select * from Proizvodi;

insert into Proizvodi (naziv, datumNabave, cijena, aktivan) values
	('Mlijeko', '10-06-2024 10:56', 1.25, 1), ('Kruh', '09-06-2024 9:52', 0.55, 1), ('Brašno', '02-06-2024 15:30', 1, 0);

update Proizvodi set naziv='Čokoladno mlijeko', cijena=1.75 where naziv='Mlijeko';

delete from Proizvodi where naziv='Brašno';

select * from Kupci;

insert into Kupci (ime, prezime, ulica, mjesto) values
	('Renato', 'Kuna', 'Mije Kišpatića 57', 'Osijek'), ('Marko', 'Markić', 'Ljudevita Gaja 2', 'Osijek'), ('Ivana', 'Ivić', 'Vukovarska 205', 'Zagreb');

update Kupci set mjesto='Split' where prezime='Markić' AND ime='Marko';

delete from Kupci where ime='Ivana' AND prezime='Ivić';

select * from Racuni;

insert into Racuni (datum, kupac, statusRacuna) values
	('10-06-2024 11:41', 1, 'Izdan'), ('02-06-2024 10:33', 2, 'Izdan'), ('10-06-2024 11:36', 1, 'Poništen');

update Racuni set datum='10-06-2024 11:44' where datum='10-06-2024 11:41';

delete from Racuni where statusRacuna='Poništen';

select * from Stavke;

insert into Stavke (racun, proizvod, kolicina, cijena) values
	(1, 1, 4, 7), (1, 2, 1, 0.55), (2, 1, 3, 5.25);