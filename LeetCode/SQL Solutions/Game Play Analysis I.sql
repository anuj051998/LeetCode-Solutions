/* Write your T-SQL query statement below */

select player_id, event_date as first_login from 
(select player_id, event_date, DENSE_RANK() OVER (PARTITION BY player_id order by event_date asc) as ranking from Activity)
as Records where ranking = 1