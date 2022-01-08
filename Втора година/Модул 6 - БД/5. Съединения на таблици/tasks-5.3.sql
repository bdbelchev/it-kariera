-- 1
USE geography;

SELECT 
    country_name, river_name
FROM
    countries c
        LEFT JOIN
    countries_rivers cr ON c.country_code = cr.country_code
        LEFT JOIN
    rivers r ON cr.river_id = r.id
WHERE
    c.continent_code IN (SELECT 
            continent_code
        FROM
            continents
        WHERE
            continent_name = 'Africa')
ORDER BY country_name;

-- 2
SELECT 
    country_name
FROM
    countries c
        LEFT OUTER JOIN
    mountains_countries mc ON c.country_code = mc.country_code
WHERE
    mc.mountain_id IS NULL;
    
-- 3
SELECT 
    mountain_range, peak_name, elevation
FROM
    mountains m
        LEFT JOIN
    peaks p ON m.id = p.mountain_id
        JOIN
    mountains_countries mc ON m.id = mc.mountain_id
WHERE
    mc.country_code = 'BG'
        AND (p.id IS NULL
        OR p.id = (SELECT 
            id
        FROM
            peaks
        WHERE
            mountain_id = m.id
        ORDER BY elevation DESC
        LIMIT 1))
ORDER BY elevation DESC;

-- 4
USE soft_uni;

SELECT 
    e.employee_id, first_name, last_name
FROM
    employees e
        LEFT JOIN
    employees_projects ep ON e.employee_id = ep.employee_id
WHERE
    project_id IS NULL
ORDER BY first_name , last_name
LIMIT 3;