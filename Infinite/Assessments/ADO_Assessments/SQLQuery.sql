Create Database EmployeeManagement;

use EmployeeManagement;


create table Employee_Details (
    Empno int PRIMARY KEY,
    EmpName varchar(50) NOT NULL,
    Empsal numeric(10,2) check (Empsal >= 25000),
    Emptype char(1) check (Emptype IN ('P', 'C')));


create procedure Employee_Data
    @EmpName varchar(50),
    @Empsal numeric(10,2),
    @Emptype char(1)
as
begin
    declare @gen_Empno int;
    select @gen_Empno = isnull(max(Empno), 100) + 1 from Employee_Details;
    insert into Employee_Details (Empno, EmpName, Empsal, Emptype)
    values (@gen_Empno, @EmpName, @Empsal, @Emptype);
    
    select @gen_Empno as Emp_no; 
		   
end;

exec Employee_Data'Caroline', 30000, 'P';
select*from Employee_Details


