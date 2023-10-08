CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        /* Write your T-SQL query statement below. */
        SELECT top 1 salary FROM(
            SELECT *, DENSE_RANK() OVER(ORDER BY salary DESC) AS REC
            FROM Employee
        ) AS RECORDS WHERE REC = @N
    );
END