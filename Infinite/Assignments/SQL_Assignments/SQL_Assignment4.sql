use AssignmentDB

------------Assignment 4---------------

--------------------------------Query 1

begin
    declare @number int = 6;
    declare @factorial int = 1;
    declare @count int = 1;

    while @count <= @number
    begin
        set @factorial = @factorial * @count;
        set @count = @count + 1;
    end

    print 'The factorial of ' + cast(@number as varchar(30)) + ' is ' + cast(@factorial as varchar(30));
end

---------------------------------------Query 2

create procedure Tables
@EndNumber int
as
begin
    declare @multiplier int = 1;

    while @multiplier <= @EndNumber
    begin
        declare @multiplicand int = 1;

        while @multiplicand <= @EndNumber
        begin
            declare @result int = @multiplier * @multiplicand;
            print convert(varchar(10), @multiplier) + ' * ' + convert(varchar(10), @multiplicand) + ' = ' + convert(varchar(10), @result);
            set @multiplicand = @multiplicand + 1;
        end;

        set @multiplier = @multiplier + 1;
        print 'NEXT TABLE or END';
    end;
end;

----------------------------------Query 3

create table holiday (
    holiday_date Date primary key,
    holiday_name varchar(40)
);

insert into holiday values ('2024-01-01', 'New Year Day'),
						   ('2024-07-04', 'Independence Day'),
						   ('2024-12-25', 'Christmas Day'),
						   ('2024-03-25', 'Holi ');


create trigger Restricted on emp
after insert, delete, update
as
begin
    declare @CurrentDate date;
    declare @HolidayName varchar(40);

    set @CurrentDate = getdate();
    select @HolidayName = holiday_name
    from holiday
    where holiday_date = @CurrentDate;

    if @HolidayName is not null
    begin
	 raiserror('Due to %s, you cannot manipulate data.', 16, 1, @HolidayName);
	 rollback transaction;
    end
end;


