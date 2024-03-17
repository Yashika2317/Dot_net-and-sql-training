use AssignmentDB
use AssignmentDB

create table EMP(empno numeric(4) primary key, ename varchar(20), job varchar(20), mgrid numeric(4), 
hiredate Date, sal numeric(7), comm numeric(5) , deptno numeric(2) foreign key references DEPT(deptno)) ;


create table DEPT(deptno numeric(2)primary key, dname varchar(20), loc varchar(20)); 
insert into EMP values 
(7369, 'SMITH', 'CLERK', 7902, '17-DEC-80', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '20-FEB-81', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '22-FEB-81', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '02-APR-81', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '28-SEP-81', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '01-MAY-81', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '09-JUN-81', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '19-APR-87', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '17-NOV-81', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '08-SEP-81', 1500, NULL, 30),
(7876, 'ADAMS', 'CLERK', 7788, '23-MAY-87', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '03-DEC-81', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '03-DEC-81', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '23-JAN-82', 1300, NULL, 10);

insert into DEPT values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON'


select *from EMP;

select * from DEPT

--1
select*from EMP
where ENAME like 'A%'

--2
select *from EMP 
where mgrid is Null

--3
select empno, ename, sal
from EMP
where sal between 1200 and 1400

--4
select * from EMP
where deptno = 20

update EMP
set sal = sal * 1.10
where deptno = 20; 

select * from EMP
where deptno = 20

--5
select count(*) as "Number of Clerks Employed"
from emp
where job = 'CLERK';

--6
select job,
       avg(sal) as average_salary,
       count(*) as number_of_employees
from emp
group by job;

--7
select* from EMP
where sal in (select MIN(sal) from EMP)
OR sal IN (select MAX(sal) from EMP)

--8
select* from DEPT
left join EMP on DEPT.deptno = EMP.deptno
where EMP.deptno is null;

--9
select ename, sal from EMP
where job = 'ANALYST' and sal > 1200 and deptno = 20
order by ename asc;

--10
select d.dname, d.deptno, sum(e.sal) as total_salary from DEPT d
left join EMP e on d.deptno = e.deptno
group by d.dname, d.deptno;

--11
select ename, sal from EMP
where ename in ('MILLER', 'SMITH');

--12
select ename from EMP
where ename like 'a%' or ename like 'm%';

--13
select sal * 12 as YearlySalary from EMP
where ename = 'SMITH';

--14
select ename, sal from EMP
where sal not between 1500 and 2850;

--15
select mgrid, count(*) as No_Employees from EMP
group by mgrid
having count(*) > 2;












