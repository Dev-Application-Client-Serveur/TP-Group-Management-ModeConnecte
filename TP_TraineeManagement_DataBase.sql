-- Création de la base de données
USE master
IF EXISTS(select * from sys.databases where name='TP_TraineeManagement')
DROP DATABASE TP_TraineeManagement
GO
CREATE DATABASE TP_TraineeManagement
GO
USE TP_TraineeManagement

-- Création des tables
create table Groups(
 Id int primary key identity(1,1),
 Code varchar(50),
 FirstName varchar(50)
);

create table Trainees(
 Id int primary key identity(1,1),
 FirstName varchar(50),
 LastName varchar(50),
 DateNaissance datetime,
 IdGroupe int foreign key references Groups(Id)
 );

-- Jeux de text
 SET IDENTITY_INSERT Groups  OFF
SET IDENTITY_INSERT Trainees OFF

SET IDENTITY_INSERT Groups ON
insert into Groups(Id,Code,FirstName) values (1,'TDI2G1','TDI Groupe 1');
insert into Groups(Id,Code,FirstName) values (2,'TDI2G1','TDI Groupe 2');
insert into Groups(Id,Code,FirstName) values (3,'TDI2G3','TDI Groupe 3');
GO
SET IDENTITY_INSERT Groups  OFF
SET IDENTITY_INSERT Trainees ON
insert into Trainees(Id,FirstName,LastName,DateNaissance,IdGroupe) values (1,'Madani','Ali','11/12/1995',1);
insert into Trainees(Id,FirstName,LastName,DateNaissance,IdGroupe) values (2,'Chami','Moad','8/6/1994',1);

-- SET IDENTITY_INSERT Groups  OFF
--SET IDENTITY_INSERT Trainees OFF
-- SET IDENTITY_INSERT Groups  ON
--SET IDENTITY_INSERT Trainees ON

select * from Groups;
select * from Trainees;

Delete  from Groups where Code = '2'