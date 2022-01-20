SELECT 
    COUNT(s.scooter_id) not_returned
FROM
    scooters s
        JOIN
    rents r ON s.scooter_id = r.scooter_id
        JOIN
    users u ON r.user_id = u.user_id
        JOIN
    cities c ON c.city_id = u.city_id
WHERE
    c.name = 'Plovdiv' AND end_date IS NULL;