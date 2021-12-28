-- 1
USE soft_uni;

SELECT 
    first_name,
    last_name,
    CASE
        WHEN manager_id IS NULL THEN '(no manager)'
        WHEN
            manager_id IS NOT NULL
        THEN
            (SELECT 
                    CONCAT_WS(' ', first_name, last_name)
                FROM
                    employees
                WHERE
                    e.manager_id = employee_id)
    END AS manager_name
FROM
    employees e
ORDER BY manager_name;

-- 2
(SELECT 
    first_name, last_name, 'manager' AS position, salary
FROM
    employees m
WHERE
    EXISTS( SELECT 
            *
        FROM
            employees
        WHERE
            manager_id = m.employee_id)
ORDER BY salary DESC
LIMIT 3) UNION (SELECT 
    first_name, last_name, 'employee' AS position, salary
FROM
    employees m
WHERE
    NOT EXISTS( SELECT 
            *
        FROM
            employees
        WHERE
            manager_id = m.employee_id)
ORDER BY salary DESC , first_name , last_name
LIMIT 3);

-- 3
USE geography;

(SELECT 
    mountain_range,
    (SELECT 
            peak_name
        FROM
            peaks
        WHERE
            mountain_id = m.id
        ORDER BY elevation DESC
        LIMIT 1) AS peak_name,
    (SELECT 
            elevation
        FROM
            peaks
        WHERE
            mountain_id = m.id
        ORDER BY elevation DESC
        LIMIT 1) AS elevation
FROM
    mountains m
WHERE
    id IN (SELECT 
            mountain_id
        FROM
            mountains_countries
        WHERE
            country_code = 'BG')
        AND EXISTS( SELECT 
            peak_name
        FROM
            peaks
        WHERE
            mountain_id = m.id)) UNION (SELECT 
    mountain_range, 'no' AS peak_name, 'info' AS elevation
FROM
    mountains m
WHERE
    id IN (SELECT 
            mountain_id
        FROM
            mountains_countries
        WHERE
            country_code = 'BG')
        AND NOT EXISTS( SELECT 
            peak_name
        FROM
            peaks
        WHERE
            mountain_id = m.id)) ORDER BY mountain_range;
            
-- 4
(SELECT 
    mountain_range AS name,
    'mountain' AS type,
    (SELECT 
            elevation
        FROM
            peaks
        WHERE
            mountain_id = m.id
        ORDER BY elevation DESC
        LIMIT 1) AS info
FROM
    mountains m
WHERE
    id IN (SELECT 
            mountain_id
        FROM
            mountains_countries
        WHERE
            country_code = 'BG')) UNION (SELECT 
    peak_name AS name, 'peak' AS type, elevation AS info
FROM
    peaks
WHERE
    mountain_id IN (SELECT 
            mountain_id
        FROM
            mountains_countries
        WHERE
            country_code = 'BG')) UNION (SELECT 
    river_name AS name, 'river' AS type, length AS info
FROM
    rivers
WHERE
    id IN (SELECT 
            river_id
        FROM
            countries_rivers
        WHERE
            country_code = 'BG')) ORDER BY name;