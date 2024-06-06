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