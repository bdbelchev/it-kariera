SELECT 
    username, register_date
FROM
    users
WHERE
    balance = 0
ORDER BY register_date DESC , username;