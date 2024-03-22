create database AssessmentDB
use AssessmentDB

--Table 1

create table BOOKS( id int primary key, Title varchar(40), Author varchar(30), isbn numeric(20)unique, Published_Date Datetime)

insert into BOOKS values (1, 'My First SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:17'),
						 (2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:45 '),
						 (3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44 ');


--Query 1 Write a query to fetch the details of the books written by author whose name ends with er.

select * from BOOKS
where Author like '%er'

--Table 2

create table Reviews (reviews_id int primary key, Book_id int foreign key references BOOKS(id),Reviewer varchar(30),
Content varchar(50), rating int, Date_of_Publishing datetime)

insert into Reviews values (1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
						   (2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
						   (3, 2, 'Alice Walker','Another review', 1, '2017-10-22 23:47:10');


-- Query 2 Display the Title ,Author and ReviewerName for all the books from the above table

select Title, Author, Reviewer
from BOOKS 
join Reviews on ID = Book_id 

-- Query 3 Display the reviewer name who reviewed more than one book.

select Reviewer from Reviews
group by Reviewer
having count (distinct book_id) > 1


--Table 3 (customers and orders)

create table CUSTOMERS (cust_id int primary key, name varchar(30), Age int, address varchar(30), Salary decimal(10, 2))

insert into customers values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00)

--Table 4

create table ORDERS (OID int primary key, OD_Date Datetime, Customer_ID INT foreign key references CUSTOMERS(cust_id), Amount DECIMAL(10, 2))

insert into orders values
(102, '2009-10-08 00:00:00', 3, 3000),
(100, '2009-10-08 00:00:00', 3, 1500),
(101, '2009-11-20 00:00:00', 2, 1560),
(103, '2008-05-20 00:00:00', 4, 2060)


--Query 4 Display the Name for the customer from above customer table who live in same address which has character o anywhere in address

select name, address from CUSTOMERS
where address like '%o%'


--Query 5 Write a query to display the Date,Total no of customer placed order on same Date

select OD_date as Orderdate, count(distinct Customer_ID) AS No_customers
from orders
GROUP BY OD_date;

--Table 5

create table Employee (Emp_id int primary key, Ename varchar(30), EAge int, address varchar(30), Emp_Salary decimal(10, 2))

insert into Employee values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', null),
(7, 'Muffy', 24, 'Indore', null)

--Query 6  --Display the Names of the Employee in lower case, whose salary is nul

select lower(Ename) AS Employee_Name from Employee
where Emp_Salary is null

--Table 6

create table STUDENT_DETAILS ( Nos int, Register_No int primary key, Stu_Name varchar(30), Stu_Age int, Qualification varchar(30), 
 Mobile_No varchar(15), Mail_id varchar(40), Stu_Location varchar(30), Gender char(1))

 insert into STUDENT_DETAILS values 
(1, 2, 'sai', 22, 'B.E', '9952836777', 'sai@gmail.com', 'Chennai', 'M'),
(2, 3, 'kumar', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai', 'M'),
(3, 4, 'selvi', 22, 'B.Tech', '8904567342', 'selvi@gmail.com', 'Selam', 'F'),
(4, 5, 'nisha', 25, 'M.E', '7834672310', 'nisha@gmail.com', 'Theni', 'F'),
(5, 6, 'saisaran', 21, 'BA', '7890345678', 'saran@gmail.com', 'Madurai', 'F'),
(6, 7, 'tom', 23, 'BCA', '8901234675', 'tom@gmail.com', 'Pune', 'M');

--Query 7 Write a sql server query to display the Gender,Total no of male and female from the above relation .

select Gender,
       count(case when Gender = 'M' then 1 end) as Total_Male,
       count(CASE when Gender = 'F' then 1 end) as Total_Female
from STUDENT_DETAILS
group by Gender;





