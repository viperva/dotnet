if not exists (
    select name
    from sys.databases
    where name = N'PeopleDB'
)
create database [PeopleDB]
go