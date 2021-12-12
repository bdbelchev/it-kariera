-- PART 1
-- 1
USE soft_uni;

-- 2
SELECT 
    *
FROM
    departments;

-- 3
SELECT 
    name
FROM
    departments;

-- 4
SELECT 
    first_name, last_name, salary
FROM
    employees;

-- 5
SELECT 
    first_name, middle_name, last_name
FROM
    employees;
    
-- 6
SELECT 
    CONCAT(first_name,
            '.',
            last_name,
            '@softuni.bg') AS full_email_address
FROM
    employees;

-- 7
SELECT DISTINCT
    salary
FROM
    employees;
    
-- 8
SELECT 
    *
FROM
    employees
WHERE
    job_title = 'Sales Representative';
    
-- 9
SELECT 
    first_name, last_name, job_title
FROM
    employees
WHERE
    salary BETWEEN 20000 AND 30000;
    
-- 10
SELECT 
    CONCAT_WS(' ', first_name, middle_name, last_name) AS full_name
FROM
    employees
WHERE
    salary IN (25000 , 14000, 12500, 23600);
    
-- 11
SELECT 
    first_name, last_name
FROM
    employees
WHERE
    manager_id IS NULL;
    
-- 12
SELECT 
    first_name, last_name, salary
FROM
    employees
WHERE
    salary > 50000
ORDER BY salary DESC;
    
-- 13
SELECT 
    first_name, last_name
FROM
    employees
ORDER BY salary DESC
LIMIT 5;

-- 14
SELECT 
    first_name, last_name
FROM
    employees
WHERE
    department_id <> 4;
    
-- 15
SELECT DISTINCT
    job_title
FROM
    employees
ORDER BY job_title;

-- 16
SELECT 
    *
FROM
    projects
ORDER BY start_date , name
LIMIT 10;

-- 17
SELECT 
    first_name, last_name, hire_date
FROM
    employees
ORDER BY hire_date DESC
LIMIT 7;

-- 18
UPDATE employees 
SET 
    salary = salary + salary * 0.12
WHERE
    department_id IN (1 , 2, 4, 11);
    
SELECT 
    salary
FROM
    employees;
    
-- PART 2
-- 19
USE geography;

SELECT 
    peak_name
FROM
    peaks
ORDER BY peak_name;

-- 20
SELECT 
    country_name, population
FROM
    countries
WHERE
    continent_code = 'EU'
ORDER BY population DESC , country_name
LIMIT 30;

-- 21
SELECT 
    country_name,
    country_code,
    -- IF(currency_code = 'EUR',
    --    'Euro',
    --    'Not Euro') AS currency
    CASE
		WHEN currency_code = 'EUR' THEN 'Euro'
		ELSE 'Not Euro'
		END AS currency
FROM
    countries
ORDER BY country_name;

-- PART 3
-- 22
USE diablo;

SELECT 
    name
FROM
    characters
ORDER BY name;