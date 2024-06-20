create database trophytracker;

use trophytracker;

create table Player(
	Player_ID int not null primary key auto_increment,
	Username varchar(50) not null,
	RegistrationDate date not null,
	Region varchar(50) not null
	
);

create table Game(
	Game_ID int not null primary key auto_increment,
	Title varchar(50) not null,
	Developer varchar(50),
	GamePlatform varchar(50),
	GameDescription text,
	CoverImage varbinary(100)
);

create table Trophy(
	Trophy_ID int not null primary key auto_increment,
	Title varchar(50) not null,
	TrophyDescription text,
	Game_ID int not null,
	foreign key (Game_ID) references Game(Game_ID),
	TrophyType varchar(10),
	TrophyIcon varbinary(100)
);


create table Achieve(
	Player_ID int not null,
	Trophy_ID int not null,
	foreign key (Player_ID) references Player(Player_ID),
	foreign key (Trophy_ID) references Trophy(Trophy_ID),
	DateAchieved datetime
);

insert into Player(Username, RegistrationDate, Region) values
	('Remba15', '2023-05-13', 'Croatia'), ('User2', '2024-06-06', 'France'), ('User3', '2020-05-12', 'Japan');

select * from Player;

insert into Game(Title, Developer, GamePlatform) values
	('Dead Space 2', 'Visceral Games', 'Playstation 3'), ('Resident evil', 'Capcom', 'Playstation'), ('Lethal Company', 'Zeekersrblx', 'Steam')

select * from Game;

insert into Trophy (Title, Game_ID, TrophyType) values
	('The Final Frontier', 1, 'Platinum'), ('Enter Survival', 2, 'Bronze'), ('Is This A Jetpack?', 3, 'Silver');

select * from Trophy;

insert into Achieve (Player_ID, Trophy_ID, DateAchieved) values
	(1, 2, '2021-04-05 18:23'), (1, 3, '2023-02-02 0:18'), (2, 1, '2015-06-13 10:25');
	
select * from Achieve;