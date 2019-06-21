Database Setup:

Download and install MSSQL server:
https://www.microsoft.com/en-us/sql-server/sql-server-downloads

Download and install SQL Server Management Studio (SSMS):
https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017

1.	Open SQL Server Management Studio (SSMS)
2.	Create DB:
	CREATE DATABASE TestDB;
3.	Create table:
	Create Table MyUsers
	(
 		ID int primary key IDENTITY(1,1),
		Username nvarchar(250) unique NOT NULL,
		MyPassword  nvarchar(250) NOT NULL,
 		FirstName nvarchar(50),
 		LastName nvarchar(50)
	)
4.	Insert data:
	Insert into MyUsers values('mark_hast@gmail.com', 'markhast!3', 'Mark', 'Hastings')
	Insert into MyUsers values('p.nichol@gmail.com', 'pam23@12', 'Pam', 'Nicholas')
	Insert into MyUsers values('j.stenson@gmail.com', 'stenson123#', 'John', 'Stenson')
	Insert into MyUsers values('ramge@gmail.com', 'ramge123', 'Ram', 'Gerald')
	Insert into MyUsers values('ron.simpsongmail.com', 'simpsons_', 'Ron', 'Simpson')
	Insert into MyUsers values('able.wicht@gmail.com', 'beablenow', 'Able', 'Wicht')
	Insert into MyUsers values('steve123@gmail.com', 'steve123', 'Steve', 'Thompson')
	Insert into MyUsers values('jamesb@gmail.com', 'bynes12!', 'James', 'Bynes')
	Insert into MyUsers values('marymary@gmail.com', 'mary234', 'Mary', 'Ward')
	Insert into MyUsers values('nniron@gmail.com', 'nniron_24', 'Nick', 'Niron')



