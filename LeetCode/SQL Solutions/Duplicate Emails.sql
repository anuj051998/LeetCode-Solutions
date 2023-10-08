/* Write your T-SQL query statement below */
select DISTINCT email from Person group by email having Count(email) > 1