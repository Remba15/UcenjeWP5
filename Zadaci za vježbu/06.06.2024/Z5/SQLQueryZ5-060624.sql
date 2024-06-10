use master
go
drop database if exists Zupanija
go
create database Zupanija
go
use Zupanija;

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

select * from Zupan;

insert into Zupan (ime, prezime) values
	('Renato', 'Kuna'), ('Marko', 'Markić'), ('Ivana', 'Ivić');

select * from Zupanija;

insert into Zupanija (naziv, zupan) values
	('Osjecko-Baranjska', 1), ('Vukovarsko-Srijemska', 3), ('Splitsko-Dalmatinska', 2);

select * from Opcina;

insert into Opcina (zupanija, naziv) values
	(1, 'Grad Osijek'), (1, 'Beli Manastir'), (3, 'Grad Split'), (3, 'Dugopolje'), (2, 'Grad Vukovar'), (2, 'Ilok');

select * from Mjesto;

insert into Mjesto (opcina, naziv) values
	(1, 'Antunovac'), (1, 'Josipovac'), (2, 'Bilje'), (2, 'Darda'), (3, 'Split1'), (3, 'Split2')
	(4, 'Dugopolje1'), (4, 'Dugopolje2'), (5, 'Vukovar1'), (5, 'Vukovar2'), (6, 'Ilok1'), (6, 'Ilok2');

update Mjesto set naziv='Vukovar3' where naziv='Vukovar1';
update Mjesto set naziv='Dugopolje4' where naziv='Dugopolje2';
update Mjesto set naziv='Nemetin' where naziv='Josipovac';
update Mjesto set naziv='Ilok5' where naziv='Ilok2';
update Mjesto set naziv='Split8' where naziv='Split1';

delete from Mjesto where opcina=2 AND opcina=4;
delete from Opcina where sifra=2 AND sifra=4;