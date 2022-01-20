SELECT 
    user_id id, username, balance
FROM
    users u
        JOIN
    cities c ON u.city_id = c.city_id
WHERE
    c.name = 'Varna'
ORDER BY balance DESC
LIMIT 1;