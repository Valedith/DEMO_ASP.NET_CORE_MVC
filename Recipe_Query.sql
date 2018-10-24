USE master
GO

CREATE DATABASE TEST_DB
USE Test_DB
GO

CREATE TABLE Recipe (

    ID int NOT NULL IDENTITY(1,1),
    Quantity int not null,
    RecipeName nvarchar(25) not null,
    RegisterDate datetime not null,
    isAvailable bit not null,    
    PRIMARY KEY (ID)
    );


INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (41,'French fries','2018-9-28',1); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (31,'Spaghetti','2016-12-12',1); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (0,'Pizza','2017-6-20',0); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (50,'Curry','2012-8-16',1); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (60,'Baguette','2013-7-7',1); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (57,'Mashed potato','2015-6-13',1); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (0,'Lasagna','2011-5-5',0); 
INSERT INTO Recipe (Quantity,RecipeName , RegisterDate, isAvailable) VALUES (88,'Ravioli','2018-1-22',1); 