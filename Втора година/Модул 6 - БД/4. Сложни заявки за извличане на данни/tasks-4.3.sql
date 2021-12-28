-- 1
USE soft_uni;

SELECT DISTINCT
    job_title, salary
FROM
    employees e
WHERE
    salary = (SELECT 
            salary
        FROM
            employees s
        WHERE
            s.job_title = e.job_title
        ORDER BY salary DESC
        LIMIT 1)
ORDER BY salary DESC , job_title;

-- 2
SELECT 
    first_name,
    last_name,
    salary,
    (SELECT 
            name
        FROM
            departments
        WHERE
            department_id = e.department_id) AS department
FROM
    employees e
WHERE
    salary = (SELECT 
            salary
        FROM
            employees
        WHERE
            department_id = e.department_id
        ORDER BY salary
        LIMIT 1)
ORDER BY salary , first_name , last_name;

-- 3
SELECT 
    first_name, last_name
FROM
    employees m
WHERE
    m.middle_name = (SELECT 
            middle_name
        FROM
            employees e
        WHERE
            e.manager_id = m.employee_id
                AND e.middle_name = m.middle_name)
ORDER BY first_name;

-- 4
SELECT 
    first_name, last_name
FROM
    employees m
WHERE
    EXISTS( SELECT 
            *
        FROM
            employees e
        WHERE
            e.manager_id = m.employee_id
                AND e.salary > m.salary)
ORDER BY first_name;

-- 5
SELECT 
    first_name, last_name
FROM
    employees m
WHERE
    (SELECT 
            COUNT(employee_id)
        FROM
            employees e
        WHERE
            e.manager_id = m.employee_id) = 5
ORDER BY first_name;

-- 6
USE geography;

SELECT 
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
ORDER BY elevation DESC;

-- 7
SELECT 
    mountain_range
FROM
    mountains m
WHERE
    NOT EXISTS( SELECT 
            *
        FROM
            peaks
        WHERE
            mountain_id = m.id)
        AND id IN (SELECT 
            mountain_id
        FROM
            mountains_countries
        WHERE
            country_code = 'BG');