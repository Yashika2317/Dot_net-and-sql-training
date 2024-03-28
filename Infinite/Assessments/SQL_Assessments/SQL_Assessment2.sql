use AssessmentDB

--Question 1

create procedure Birthday
@Enterdate date
as
begin
    
	declare @Day_of_week varchar(20);

    select @Day_of_week = datename(weekday, @Enterdate);

    print 'Your birthday is on a ' + @Day_of_week
end;

exec Birthday '2001-11-17';

--Output - Your birthday is on a Saturday


--Question 2

create procedure Age
    @birth_date date
as
begin
   
    declare @current_date date = getdate();
    declare @age_in_days int;

    select @age_in_days = datediff(day, @birth_date, @current_date);

    print 'Your Age in days is: ' + cast(@age_in_days as varchar(20));
end;

exec Age '2001-11-17';

--Output - (Your Age in days is: 8167)


--Question 3

create table EMP(empno numeric(4) primary key, ename varchar(20), job varchar(20), mgrid numeric(4), 
hiredate Date, sal numeric(7), comm numeric(5) , deptno numeric(2) foreign key references DEPT(deptno)) ;

insert into EMP values 
(7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '09-MAR-2018', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '17-NOV-81', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, NULL, 30),
(7876, 'ADAMS', 'CLERK', 7788, '23-MAR-2018', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300, NULL, 10);

create table DEPT(deptno numeric(2)primary key, dname varchar(20), loc varchar(20)); 

insert into DEPT values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON')

select * from EMP
where hiredate <= Dateadd(year, -5, Getdate())
and Month(hiredate) = Month(Getdate())

--Output
--7782	CLARK	MANAGER	7839	2018-03-09	2450	NULL	10
--7876	ADAMS	CLERK	7788	2018-03-23	1100	NULL	20

--Question 5

create function CalculateBonus (@sal float, @deptno numeric(2))
returns float
as
begin
    declare @bonus float

    set @bonus = 
        case 
            when @deptno = 10 then @sal * 0.15
            when @deptno = 20 then @sal * 0.20
            else @sal * 0.05
        end;

    return @bonus;
end;

select ename, job, sal, deptno,
dbo.CalculateBonus(sal, deptno) as bonus from EMP

--Output
--Name      Job         sal     no  bonus
--SMITH		CLERK		800		20	160
--ALLEN		SALESMAN	1600	30	80
--WARD		SALESMAN	1250	30	62.5
--JONES		MANAGER		2975	20	595
--MARTIN	SALESMAN	1250	30	62.5
--BLAKE	    MANAGER	    2850	30	142.5
--CLARK	    MANAGER		2450	10	367.5
--SCOTT	    ANALYST		3000	20	600
--KING	    PRESIDENT	5000	10	750
--TURNER	SALESMAN	1500	30	75
--ADAMS   	CLERK		1100	20	220
--JAMES	    CLERK		950		30	47.5
--FORD	    ANALYST		3000	20	600
--MILLER	CLERK		1300	10	195


--Question 4

create table Employee2 (
    Employee_No int primary key,
    Employee_Name varchar(30),
    Employee_Sal decimal(10, 2),
    Date_of_Join date
);

--1. First insert 3 rows 

insert into Employee2 values 
    (1, 'Yashika', 26000.00, '2024-02-15'),
    (2, 'Riya', 24000.00, '2024-02-01'),
    (3, 'Anjali', 23000.00, '2024-01-17');


--2. Update the second row sal with 15% increment  

update Employee2
set Employee_Sal = Employee_Sal * 1.15
where Employee_No = 2;

select*from Employee2

--Output
--1	Yashika	26000.00	2024-02-15
--2	Riya	27600.00	2024-02-01
--3	Anjali	23000.00	2024-01-17


--3. Delete the first row
begin transaction;

delete from Employee2
where Employee_No = 1;

select * from Employee2;

rollback;

select * from Employee2;

--Output after deleting
--2	Riya	27600.00	2024-02-01
--3	Anjali	23000.00	2024-01-17

--Output after rollback
--1	Yashika	26000.00	2024-02-15
--2	Riya	27600.00	2024-02-01
--3	Anjali	23000.00	2024-01-17

















