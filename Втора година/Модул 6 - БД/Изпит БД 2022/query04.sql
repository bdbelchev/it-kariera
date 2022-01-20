SELECT 
    username, balance
FROM
    users u
        LEFT JOIN
    rents r ON r.user_id = u.user_id
WHERE
    r.rent_id IS NULL
ORDER BY balance DESC , username
LIMIT 5;