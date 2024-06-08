use master
go
drop database if exists Webshop
go
create database Webshop
go
use Webshop;

create table Proizvoi(
    sifra int not null primary key identity(1,1),
    naziv varchar(50) not null,
    datumNabave DATETIME,
    cijena double (18,2),
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