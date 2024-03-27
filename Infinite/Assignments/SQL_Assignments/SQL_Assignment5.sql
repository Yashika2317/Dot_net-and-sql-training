create table employee(employee_id int, employee_name varchar(20), employee_sal float)

insert into employee values
(1, 'SMITH', 30000.00),
(2, 'ALLEN', 20000.00),
(3, 'WARD', 25000.00),
(4, 'JONES', 18000.00),
(4, 'MARTIN', 19000.00)

create procedure Employeepayslip 
@employeeid numeric(4)
as
begin
    declare @salary decimal(10, 2)
    declare @HRA decimal(10, 2)
    declare @DA decimal(10, 2)
    declare @PF decimal(10, 2)
    declare @IT decimal(10, 2)
    declare @deductions decimal(10, 2)
    declare @grosssalary decimal(10, 2)
    declare @netsalary decimal(10, 2)
    declare @employeename varchar(30)

    select @salary = employee_sal, 
	@employeename = employee_name
    from employee 
    where employee_id = @employeeid

    if @salary is not null
    begin

--1. Calculate HRA as 10% of Salary

        set @HRA = @salary * 0.10

--2. Calculate DA as 20% of Salary

        set @DA = @salary * 0.20

--3. Calculate PF as 8% of Salary

        set @PF = @salary * 0.08

--4. Calculate IT as 5% of Salary

        set @IT = @salary * 0.05

--5. Calculate total deductions as sum of PF and IT

        set @deductions = @PF + @IT

--6. Calculate gross salary as sum of (Salary, HRA and DA)

        set @grosssalary = @salary + @HRA + @DA

--7. Calculate net salary as (GrossSalary - Deductions)

        set @netsalary = @grosssalary - @deductions

--8. Displaying the Employees payslip

        select 
            @employeeid as employeeid,
            @employeename as employeename,
            @salary as basicsalary,
            @HRA as HRA,
            @DA as DA,
            @PF as PF,
            @IT as IT,
            @deductions as Deductions,
            @grosssalary as GrossSalary,
            @netsalary as NetSalary
    end
    else
    begin
        print 'Employee id not found.'
    end

end

exec Employeepayslip @employeeid = 3; 

