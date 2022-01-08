-- 1
USE soft_uni;

SELECT 
    first_name, last_name, t.name AS town, address_text
FROM
    employees e
        JOIN
    addresses a ON e.address_id = a.address_id
        JOIN
    towns t ON a.town_id = t.town_id
ORDER BY first_name;

-- 2
SELECT 
    first_name, last_name, hire_date, d.name AS dept_name
FROM
    employees e
        JOIN
    departments d ON e.department_id = d.department_id
WHERE
    hire_date > 1999 - 01 - 01
        AND d.name IN ('Sales' , 'Finance') order by hire_date;
        
-- 3
SELECT 
    e.employee_id, first_name, p.name project_name
FROM
    employees e
        JOIN
    employees_projects ep ON e.employee_id = ep.employee_id
        JOIN
    projects p ON ep.project_id = p.project_id
WHERE
    start_date > 2002 - 08 - 13
        AND end_date IS NULL
ORDER BY first_name , project_name
LIMIT 5;

-- 4
SELECT 
    e.employee_id,
    CONCAT_WS(' ', e.first_name, e.last_name) AS employee_name,
    CONCAT_WS(' ', m.first_name, m.last_name) AS manager_name,
    d.name AS department_name
FROM
    employees e
        JOIN
    employees m ON e.manager_id = m.employee_id
        JOIN
    departments d ON e.department_id = d.department_id
ORDER BY e.employee_id;

-- 5
USE geography;

SELECT 
    mc.country_code, mountain_range, peak_name, elevation
FROM
    mountains_countries mc
        JOIN
    mountains m ON mc.mountain_id = m.id
        JOIN
    peaks p ON m.id = p.mountain_id
WHERE
    mc.country_code = 'BG'
        AND elevation > 2835
ORDER BY elevation DESC;

-- 6
SELECT 
    c.country_code, country_name, mountain_range
FROM
    countries c
        JOIN
    mountains_countries mc ON c.country_code = mc.country_code
        JOIN
    mountains m ON mc.mountain_id = m.id
WHERE
    c.country_code IN ('RU' , 'BG', 'US')
ORDER BY c.country_code , mountain_range;