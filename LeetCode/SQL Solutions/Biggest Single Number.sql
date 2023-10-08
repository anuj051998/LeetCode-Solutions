/* Write your T-SQL query statement below */
DECLARE @res INT = NULL;
SELECT TOP 1 @res = NUM FROM MyNumbers GROUP BY NUM HAVING COUNT(NUM) = 1 ORDER BY num DESC;
SELECT @res num;