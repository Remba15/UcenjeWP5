use master
go
drop database if exists Zupanija
go
create database Zupanija
go

use Zupanija

create table Zupan(
	sifra int not null primary key identity(1,1),
	ime varchar(50) not null,
	prezime varchar(50) not null
);

create table Zupanija(
	sifra int not null primary key identity(1,1),
	naziv varchar(50) not null,
	zupan int not null foreign key references Zupan(sifra)
);

create table Opcina(
	sifra int not null primary key identity(1,1),
	zupanija int not null foreign key references Zupanija(sifra),
	naziv varchar(50) not null
);

create table Mjesto(
	sifra int not null primary key identity(1,1),
	opcina int not null foreign key references Opcina(sifra),
	naziv varchar(50) not null
);