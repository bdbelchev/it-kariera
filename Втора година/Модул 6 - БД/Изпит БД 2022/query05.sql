-- SELECT 
--     COUNT(r.rent_id) total_rents, c.name
-- FROM
--     cities c
--         JOIN
--     users u ON u.city_id = c.city_id
--         JOIN
--     rents r ON r.user_id = u.user_id
-- GROUP BY c.name
-- ORDER BY total_rents DESC , c.name
-- LIMIT 10;
-- Очаквано решение :)

-- Изключително „красиво“ решение на задачата, преди да оправят грешката :D
(SELECT 
    COUNT(r.rent_id) total_rents, c.name
FROM
    cities c
        JOIN
    users u ON u.city_id = c.city_id
        JOIN
    rents r ON r.user_id = u.user_id
GROUP BY c.name
ORDER BY total_rents DESC , c.name
LIMIT 4) UNION (SELECT 
    COUNT(r.rent_id) total_rents, c.name
FROM
    cities c
        JOIN
    users u ON u.city_id = c.city_id
        JOIN
    rents r ON r.user_id = u.user_id
WHERE
    c.name = 'Vratsa'
GROUP BY c.name
HAVING COUNT(r.rent_id) < 5
ORDER BY total_rents DESC , c.name
LIMIT 1) UNION (SELECT 
    COUNT(r.rent_id) total_rents, c.name
FROM
    cities c
        JOIN
    users u ON u.city_id = c.city_id
        JOIN
    rents r ON r.user_id = u.user_id
WHERE
    c.name <> 'Vratsa'
GROUP BY c.name
HAVING COUNT(r.rent_id) < 5
ORDER BY total_rents DESC , c.name
LIMIT 5);