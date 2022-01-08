-- 1
USE soft_uni;

SELECT 
    e.employee_id, e.job_title, e.address_id, a.address_text
FROM
    employees e
        JOIN
    addresses a ON e.address_id = a.address_id;
    
-- 2
SELECT 
    e.employee_id,
    e.first_name,
    e.last_name,
    d.name AS department_name
FROM
    employees e
        JOIN
    departments d ON e.department_id = d.department_id
WHERE
    d.name = 'Sales'
ORDER BY employee_id DESC;

-- 3
SELECT 
    e.employee_id,
    e.first_name,
    e.salary,
    d.name AS department_name
FROM
    employees e
        JOIN
    departments d ON e.department_id = d.department_id
WHERE
    e.salary > 15000
ORDER BY d.department_id DESC
LIMIT 5;

-- 4
SELECT 
    e.employee_id, e.first_name
FROM
    employees e
        LEFT JOIN
    employees_projects ep ON e.employee_id = ep.employee_id
WHERE
    project_id IS NULL
ORDER BY employee_id DESC
LIMIT 3;

-- 5
SELECT 
    e.employee_id,
    e.first_name,
    e.manager_id,
    m.first_name AS manager_name
FROM
    employees e
        JOIN
    employees m ON e.manager_id = m.employee_id
WHERE
    e.manager_id = 3 OR e.manager_id = 7 order by e.first_name;
    
-- 6
SELECT 
    e.salary, d.name
FROM
    employees e
        JOIN
    departments d ON e.department_id = d.department_id
ORDER BY salary
LIMIT 1;

-- 7
USE geography;

SELECT 
    country_name
FROM
    countries c
        LEFT JOIN
    mountains_countries mc ON c.country_code = mc.country_code
WHERE
    mountain_id IS NULL;