Create Database Books
Create Table BookDetails(BookId uniqueidentifier  primary key default newid(),
[Name] varchar(max),
AuthorName varchar(max))

Select * From BookDetails
