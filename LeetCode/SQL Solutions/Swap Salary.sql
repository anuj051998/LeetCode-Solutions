﻿/* Write your T-SQL query statement below */
update Salary 
SET sex = 
CASE sex
    WHEN 'm' 
    THEN 'f' 
    ELSE 'm'
END
