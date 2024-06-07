use master
go
drop database if exists Opcine
go
create database Opcine
go
use Opcine;

create table Nacelnici(
	sifra int not null primary key identity(1,1),
	ime varchar(30) not null,
	prezime varchar(30) not null,
	datumRodenja date
);

insert into Nacelnici (ime, prezime, datumRodenja) values
	('Marin', 'Marić', '1985-05-12'), ('Ivan', 'Ivić', '1992-01-05'), ('Vinko', 'Vinić', '1968-06-25')

select * from Nacelnici;

update Nacelnici set ime='Tomislav' where sifra=3;