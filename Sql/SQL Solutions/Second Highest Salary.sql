BEGIN
Declare @SecondHighestSalary as Int = (Select top 1 salary from Employee where salary < (SELECT MAX(salary) from Employee) order by salary desc)
SELECT ISNULL(@SecondHighestSalary, null) as SecondHighestSalary
END