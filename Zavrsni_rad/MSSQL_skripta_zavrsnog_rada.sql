--create database EdunovaWebProgramiranjeZavrsniRad;

--use EdunovaWebProgramiranjeZavrsniRad;

create table Player(
	ID int not null primary key identity(1,1),
	Username varchar(50) not null,
	RegistrationDate date not null,
	Region varchar(50) not null
);

create table Game(
	ID int not null primary key identity(1,1),
	Title varchar(50) not null,
	Developer varchar(50),
	GamePlatform varchar(50),
	GameDescription text,
	CoverImage image
);

create table Trophy(
	ID int not null primary key identity(1,1),
	Title varchar(50) not null,
	TrophyDescription text,
	Game_ID int not null foreign key references Game(ID),
	TrophyType varchar(10),
	TrophyIcon image,
);

create table Achieve(
	Player_ID int not null foreign key references Player(ID),
	Trophy_ID int not null foreign key references Trophy(ID),
	DateAchieved DATETIME
);


select * from Player;

insert into Player(Username, RegistrationDate, Region) values
	('Remba15', '2023-05-13', 'Croatia'), ('User2', '2024-06-06', 'France'), ('User3', '2020-05-12', 'Japan');

select * from Game;

insert into Game(Title, Developer, GamePlatform) values
	('Dead Space 2', 'Visceral Games', 'Playstation 3'), ('Resident evil', 'Capcom', 'Playstation'), ('Lethal Company', 'Zeekersrblx', 'Steam')

select * from Trophy

insert into Trophy (Title, Game_ID, TrophyType) values
	('The Final Frontier', 1, 'Platinum'), ('Enter Survival', 2, 'Bronze'), ('Is This A Jetpack?', 3, 'Silver');

select * from Achieve;

insert into Achieve (Player_ID, Trophy_ID, DateAchieved) values
	(1, 2, '2021-04-05 18:23'), (1, 3, '2023-02-02 0:18'), (2, 1, '2015-06-13 10:25');