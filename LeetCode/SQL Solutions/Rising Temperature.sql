﻿/* Write your T-SQL query statement below */
SELECT WEATHERTWO.ID FROM WEATHER WEATHERONE
LEFT JOIN WEATHER WEATHERTWO ON
DATEADD(DAY, 1, WEATHERONE.RECORDDATE) = WEATHERTWO.RECORDDATE
WHERE WEATHERTWO.TEMPERATURE > WEATHERONE.TEMPERATURE