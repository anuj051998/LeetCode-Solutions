/* 
 Please write a DELETE statement and DO NOT write a SELECT statement.
 Write your T-SQL query statement below
 */
DELETE FROM Person WHERE id in (SELECT t2.id FROM person t1 join person t2 ON t1.email = t2.email AND t1.id < t2.id)