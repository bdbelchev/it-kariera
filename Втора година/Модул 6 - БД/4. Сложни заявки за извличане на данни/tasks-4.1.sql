-- 1
USE soft_uni;

SELECT 
    first_name, last_name, salary
FROM
    employees
WHERE
    salary > 50000
ORDER BY salary DESC;

-- 2
SELECT 
    first_name, last_name
FROM
    employees
ORDER BY salary DESC
LIMIT 5;

-- 3
SELECT 
    *
FROM
    employees
ORDER BY salary DESC , first_name , last_name DESC , middle_name;

-- 4
SELECT 
    *
FROM
    projects
ORDER BY start_date, name
LIMIT 10;

-- 5
SELECT 
    first_name, last_name, hire_date
FROM
    employees
ORDER BY hire_date DESC
LIMIT 7;

-- 6
USE geography;

SELECT 
    peak_name
FROM
    peaks
ORDER BY peak_name;

-- 7
SELECT 
    country_name, population
FROM
    countries
WHERE
    continent_code = 'EU'
ORDER BY population DESC , country_name;

-- 8
SELECT 
    country_name,
    country_code,
    CASE
        WHEN currency_code = 'EUR' THEN 'Euro'
        WHEN currency_code <> 'EUR' THEN 'Not Euro'
    END AS currency
FROM
    countries
ORDER BY country_name;