DELETE t FROM person t inner join person t1 WHERE t.id > t1.id AND t.email = t1.email;