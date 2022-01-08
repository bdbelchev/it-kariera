-- 1
USE soft_uni;

SELECT 
    e.employee_id,
    first_name,
    CASE
        WHEN start_date >= '2005-01-01' THEN NULL
        WHEN start_date < '2005-01-01' THEN p.name
    END project_name
FROM
    employees e
        JOIN
    employees_projects ep ON e.employee_id = ep.employee_id
        JOIN
    projects p ON ep.project_id = p.project_id
WHERE
    e.employee_id = 24
ORDER BY p.name;

-- 2
USE geography;

SELECT 
    c1.continent_name 'FROM', c2.continent_name 'TO'
FROM
    continents c1
        CROSS JOIN
    continents c2
ORDER BY c1.continent_name , c2.continent_name;

-- 3
SELECT 
    c1.capital 'Place',
    c1.country_name 'Player 1',
    '' AS 'Host',
    '' AS 'Guest',
    c2.country_name 'Player 2'
FROM
    countries c1
        CROSS JOIN
    countries c2
WHERE
    c1.continent_code = 'EU'
        AND c2.continent_code = 'EU'
        AND c1.country_code <> c2.country_code
ORDER BY RAND();

-- 4
SELECT 
    country_name,
    MAX(elevation) AS highest_peak_elevation,
    MAX(length) AS longest_river_length
FROM
    countries c
        LEFT JOIN
    mountains_countries mc ON c.country_code = mc.country_code
        LEFT JOIN
    peaks p ON mc.mountain_id = p.mountain_id
        LEFT JOIN
    countries_rivers cr ON c.country_code = cr.country_code
        LEFT JOIN
    rivers r ON cr.river_id = r.id
GROUP BY country_name
ORDER BY highest_peak_elevation DESC , longest_river_length DESC , country_name ASC
LIMIT 5;

-- 5

-- TODO! --

SELECT 
    usages.continent_code, usages.currency_code, usages.usages
FROM
    (SELECT 
        con.continent_code,
            cu.currency_code,
            COUNT(cu.currency_code) AS usages
    FROM
        continents AS con
    INNER JOIN countries AS c ON c.continent_code = con.continent_code
    INNER JOIN currencies AS cu ON cu.currency_code = c.currency_code
    GROUP BY con.continent_code , cu.currency_code) AS usages
        INNER JOIN
    (SELECT 
        usages.continent_code, MAX(usages.usages) AS maxUsage
    FROM
        (SELECT 
        con.continent_code,
            cu.currency_code,
            COUNT(cu.currency_code) AS usages
    FROM
        continents AS con
    INNER JOIN countries AS c ON c.continent_code = con.continent_code
    INNER JOIN currencies AS cu ON cu.currency_code = c.currency_code
    GROUP BY con.continent_code , cu.currency_code
    HAVING COUNT(cu.currency_code) > 1) AS usages
    GROUP BY usages.continent_code) AS max_usages ON max_usages.continent_code = usages.continent_code
        AND max_usages.maxUsage = usages.usages
ORDER BY usages.continent_code , usages.currency_code;