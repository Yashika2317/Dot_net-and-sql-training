use AssignmentDB

--Query 1

select empno,ename,job from EMP
where job = 'manager'

--Query 2

 select ename, sal from EMP 
 where sal >1000

--Query 3

 select ename, sal from EMP
 where ename <> 'JAMES'

--Query 4

 select*from EMP
 where ename like 's%'


 --Query 5

select*from EMP
where ename like '%A%' 

--Query 6

select*from EMP
where ename like '--L%' 

--Query 7

select ename, sal/30 as salary from EMP
where ename = 'JONES' 

--Query 8

select sum(sal) as TOTAL_SALARY from EMP

--Query 9

select avg(sal) as AVG_SALARY from EMP

--Query 10

select ename, job, sal, deptno from EMP
where deptno <> 30

--Query 11

select distinct e.deptno, d.dname
from EMP e
join DEPT d on e.deptno = d.deptno

--Query 12

select ename as Employee, sal as Monthly_Salary from EMP
where sal>1500 and(deptno = 10 or deptno = 30)

--Query 13

select ename, job, sal from EMP
where(job = 'MANAGER' or job = 'ANALYST') and sal NOT IN (1000,3000,5000)

--Query 14

select ename, sal, comm from EMP
where comm>sal*1.1

--Query 15

select ename , job, deptno from EMP
where (ename like '%L%L%') and (deptno = 30 or mgrid = 7782)

--Query 16

select ename,
       (select count(*) 
        from emp
        where hiredate <= dateadd(year, -30, getdate())
          and hiredate > dateadd(year, -40, getdate())
       ) as total_employees
from emp
where hiredate <= dateadd(year, -30, getdate())
  and hiredate > dateadd(year, -40, getdate());


--Query 17

SELECT d.dname, e.ename
FROM DEPT d
LEFT JOIN EMP e ON d.deptno = e.deptno
ORDER BY d.dname ASC, e.ename DESC;


--Query 18

select datediff(Year, hiredate, GETDATE()) as experience
from emp
where ename = 'MILLER';











