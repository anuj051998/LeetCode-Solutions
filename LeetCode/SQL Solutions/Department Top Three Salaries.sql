/* Write your T-SQL query statement below */

select Department, Employee, Salary from 
(SELECT dept.name as Department, emp.name as Employee, emp.salary, 
 DENSE_RANK() OVER(PARTITION BY emp.departmentid order by emp.salary desc) as RANKING 
from employee emp join
department dept on emp.departmentid = dept.id )
as records
where records.RANKING <= 3
