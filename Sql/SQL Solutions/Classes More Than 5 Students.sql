/* Write your T-SQL query statement below */
select class from Courses GROUP BY class HAVING COUNT(class) >= 5