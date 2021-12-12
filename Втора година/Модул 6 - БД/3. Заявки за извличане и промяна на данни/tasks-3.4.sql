-- 1
USE softuni;

INSERT INTO towns(name)
VALUES
('Sofia'), 
('Plovdiv'), 
('Varna'), 
('Burgas');

INSERT INTO departments(name)
VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance');

INSERT INTO employees(first_name, middle_name, last_name, job_title, department_id, hire_date, salary)
VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4, '2013-02-01', 3500),
('Petar', 'Petrov', 'Petrov', 'Senior Engineer', 1, '2004-03-02', 4000),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, '2016-08-28', 525.25),
('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, '2007-09-12', 3000),
('Peter', 'Pan', 'Pan', 'Intern', 3, '2016-08-28', 599.88);

-- 2
SELECT 
    *
FROM
    towns;
SELECT 
    *
FROM
    departments;
SELECT 
    *
FROM
    employees;
    
-- 3
SELECT 
    name
FROM
    towns;
SELECT 
    name
FROM
    departments;
SELECT 
    first_name, last_name, job_title, salary
FROM
    employees;
    
-- 4
UPDATE employees 
SET 
    salary = salary + salary * 0.10;
    
SELECT 
    salary
FROM
    employees;
    
-- 5
USE hotel; -- ???
UPDATE payments 
SET 
    tax_rate = tax_rate * 0.97;
    
-- 6
TRUNCATE TABLE occupancies;