USE master; 
GO 
CREATE DATABASE IdentityDB  
ON      ( NAME = Sales_dat, FILENAME = 'F:\PlayGround\Net\MVC\Lesson011_Identity\IdentityDb\IdentityDB.mdf') 
LOG ON  ( NAME = Sales_log, FILENAME = 'F:\PlayGround\Net\MVC\Lesson011_Identity\IdentityDb\IdentityDB.ldf'); 
GO