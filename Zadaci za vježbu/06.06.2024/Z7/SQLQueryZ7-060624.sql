use master
go
drop database if exists Tvrtka
go
create database Tvrtka
go
use Tvrtka;

create table Zaposlenici(
    sifra int not null primary key identity(1,1),
    ime varchar(50) not null,
    prezime varchar(50) not null,
    datumRodenja DATE,
    placa decimal(18,2),
    invalid bit
);

create table Slike(
    sifra int not null primary key identity(1,1),
    zaposlenik int not null foreign key references Zaposlenici(sifra);
    redniBroj int,
    putanja varchar(100)
);

insert into Zaposlenici(ime, prezime) values
    ('Renato', 'Kuna'), ('Marko', 'Markić'), ('Ivana', 'Ivić');

insert into Slike(zaposlenik, redniBroj, putanja) values
    (1, 1, 'C:/Documents/Pictures/Renato_Kuna'), (1, 2, 'C:/Documents/Pictures/Renato_Kuna'),
    (3, 1, 'C:/Documents/Pictures/Ivana_Ivic'), (3, 2, 'C:/Documents/Pictures/Ivana_Ivic'),
    (2, 1, 'C:/Documents/Pictures/Marko_Markic'), (3, 2, 'C:/Documents/Pictures/Marko_Markic');