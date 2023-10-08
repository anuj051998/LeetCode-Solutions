/* Write your T-SQL query statement below */

select top 1 customer_number from(
select customer_number, Count(*) as count from orders
GROUP by customer_number) as records
order by records.count desc