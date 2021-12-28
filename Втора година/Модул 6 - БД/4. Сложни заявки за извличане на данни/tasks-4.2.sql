-- 1
USE soft_uni;

SELECT 
    first_name, last_name, salary
FROM
    employees
WHERE
    salary = (SELECT 
            salary
        FROM
            employees
        ORDER BY salary
        LIMIT 1);
        
-- 2
SELECT 
    first_name, last_name, salary
FROM
    employees
WHERE
    salary < 1.1 * (SELECT 
            salary
        FROM
            employees
        ORDER BY salary
        LIMIT 1)
ORDER BY salary;

-- 3
SELECT 
    first_name, last_name, job_title
FROM
    employees
WHERE
    employee_id IN (SELECT DISTINCT
            manager_id
        FROM
            employees)
ORDER BY first_name;

-- 4
SELECT 
    first_name, last_name
FROM
    employees
WHERE
    address_id IN (SELECT 
            address_id
        FROM
            addresses
        WHERE
            town_id = (SELECT 
                    town_id
                FROM
                    towns
                WHERE
                    name = 'San Francisco'));