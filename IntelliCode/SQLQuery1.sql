CREATE TABLE UserTable
(
	UserID int Identity(1,1) not null unique,
	UserFirstName NChar(25) ,
	UserLastName  NCHAR(25) ,
    UserName NCHAR(25) NULL,
    UserPassword INT NULL,
    UserTitle NCHAR(4) NULL,
    UserEmai NCHAR(50) NULL, 
    AuthentificationLevel INT NULL
	primary key(UserID)
);
