CREATE DATABASE Futurama
GO

USE Futurama
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Actors(
	Id int IDENTITY(1,1) NOT NULL,
	[Name] nvarchar(50) NOT NULL,
	CONSTRAINT PK_Actors PRIMARY KEY CLUSTERED (Id)
)
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE Characters(
	Id int IDENTITY(1,1) NOT NULL,
	ActorId int NULL,
	[Name] nvarchar(50) NOT NULL,
	Species nvarchar(50) NOT NULL,
	Planet nvarchar(50) NULL,
	CONSTRAINT PK_Characters PRIMARY KEY CLUSTERED (Id)
)
GO

INSERT Actors (GivenName, Surname) VALUES (N'Billy West')
INSERT Actors (GivenName, Surname) VALUES (N'Katey Sagal')
INSERT Actors (GivenName, Surname) VALUES (N'John DiMaggio')
INSERT Actors (GivenName, Surname) VALUES (N'Lauren Tom')
INSERT Actors (GivenName, Surname) VALUES (N'Phil LaMarr')

INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (1, N'Philip J. Fry', N'Human', N'Earth')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (2, N'Leela Turanga', N'Mutant, Human', N'Earth')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (3, N'Bender Bending Rodriquez', N'Robot', N'Tijuana, Baja California')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (1, N'John A. Zoidberg', N'Decapodian', N'Decapod 10')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (4, N'Amy Wong', N'Human', N'Mars')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (5, N'Hermes Conrad', N'Human', N'Earth')
INSERT Characters (ActorId, GivenName, Surname, Species, Planet) VALUES (1, N'Hubert J. Farnsworth', N'Human', N'Earth')

ALTER TABLE Characters  WITH CHECK ADD CONSTRAINT FK_Characters_Actors FOREIGN KEY(ActorId)
REFERENCES Actors (Id)
GO
ALTER TABLE Characters CHECK CONSTRAINT FK_Characters_Actors
GO