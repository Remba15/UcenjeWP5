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
    cijena decimal(18, 2),
    aktivan bit
);

create table Kupci(
    sifra int not null primary key identity(1,1),
    ime varchar(50) not null,
    prezime varchar(50) not null,
    ulica varchar(70),
    mjesto varchar(50)
);

create table Racuni(
    sifra int not null primary key identity(1,1),
    datum DATETIME,
    kupac int not null foreign key references Kupci(sifra),
    status bit
);

create table Stavke(
    racun int not null foreign key references Racuni(sifra),
    proizvod int not null foreign key references Proizvodi(sifra),
    kolicina int,
    cijena decimal (18, 2)
);

select * from Kupci;

insert into Kupci(ime, prezime) values
    ('Renato', 'Kuna'), ('Marko', 'Markić'), ('Ivana', 'Ivić');

select * from Racuni;

insert into Racuni(datum, kupac) values
    ('10-06-2024 14:22', 1), ('05-04-2024 12:12', 3), ('06-01-2024 11:15', 2);

select * from Proizvodi;

insert into Proizvodi(naziv, cijena) values
    ('Majica' 9.99), ('Patike', 25), ('Hlače', 15.50);

select * from Stavke;

insert into Stavke(racun, proizvod, kolicina, cijena) values
    (1, 3, 1, 27.97), (1, 2, 1, 25), (2, 3, 1, 15.50);