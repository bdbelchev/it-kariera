SELECT 
    COUNT(r.rent_id) total_rents, username
FROM
    users u
        JOIN
    rents r ON r.user_id = u.user_id
GROUP BY username
ORDER BY total_rents DESC , username
LIMIT 5;