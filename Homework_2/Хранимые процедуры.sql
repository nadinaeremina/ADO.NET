--1
create procedure change_premium
as 
update Teachers
set Premium=Premium+1000
where Salary >= 90000

--2
create procedure change_status 
@id int
as 
update Teachers
set IsProfessor=1
where id=@id