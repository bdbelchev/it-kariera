CREATE DATABASE broker_business_db;
USE broker_business_db;

CREATE TABLE cities (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL,
    country_name VARCHAR(80) NOT NULL
);

CREATE TABLE companies (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    rate INT NOT NULL,
    created_on DATE NOT NULL
);

CREATE TABLE building_types (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE persons (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(30) NOT NULL UNIQUE,
    company_id INT,
    city_id INT NOT NULL,
    FOREIGN KEY (company_id)
        REFERENCES companies (id),
    FOREIGN KEY (city_id)
        REFERENCES cities (id)
);

CREATE TABLE person_info (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(30) NOT NULL,
    last_name VARCHAR(30),
    money DECIMAL(15 , 2 ) DEFAULT 0,
    person_id INT NOT NULL,
    FOREIGN KEY (person_id)
        REFERENCES persons (id)
);

CREATE TABLE buildings (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(80) NOT NULL UNIQUE,
    rent_amount DECIMAL(17 , 2 ) NOT NULL,
    height DECIMAL(15 , 2 ) NOT NULL,
    floors INT,
    finished_year YEAR,
    status VARCHAR(50) NOT NULL,
    city_id INT NOT NULL,
    type_id INT NOT NULL,
    company_id INT NOT NULL,
    FOREIGN KEY (city_id)
        REFERENCES cities (id),
    FOREIGN KEY (type_id)
        REFERENCES building_types (id),
    FOREIGN KEY (company_id)
        REFERENCES companies (id)
);

CREATE TABLE persons_buildings (
    person_id INT NOT NULL,
    building_id INT NOT NULL,
    FOREIGN KEY (person_id)
        REFERENCES persons (id),
    FOREIGN KEY (building_id)
        REFERENCES buildings (id),
    PRIMARY KEY (person_id , building_id)
);

-- import dataset.sql

SELECT 
    id, username, company_id
FROM
    persons
WHERE
    city_id = 10 AND company_id IS NOT NULL
ORDER BY username , id;

SELECT 
    id, name building_name, rent_amount, height, status
FROM
    buildings
WHERE
    rent_amount > 5000 AND height > 500
ORDER BY rent_amount DESC , name ASC;

SELECT 
    p.id, username, first_name, last_name, c.name company_name
FROM
    persons p
        JOIN
    companies c ON p.company_id = c.id
        JOIN
    person_info pi ON p.id = pi.person_id
WHERE
    c.name = 'West'
ORDER BY first_name , last_name;

SELECT 
    username,
    c.name company_name,
    ct.name city_name,
    country_name
FROM
    persons p
        LEFT JOIN
    companies c ON c.id = p.company_id
        JOIN
    cities ct ON ct.id = p.city_id
WHERE
    p.id < 15
ORDER BY company_id , username;

SELECT 
    bt.name building_type,
    COUNT(b.id) buildings_count,
    MAX(b.rent_amount) max_rent_amount,
    MIN(b.rent_amount) min_rent_amount
FROM
    building_types bt
        JOIN
    buildings b ON b.type_id = bt.id
GROUP BY building_type
ORDER BY buildings_count DESC;

SELECT 
    b.name building_name,
    bt.name building_type,
    b.status,
    c.name city_name,
    COUNT(p.id) persons_count
FROM
    buildings b
        JOIN
    building_types bt ON b.type_id = bt.id
        JOIN
    cities c ON c.id = b.city_id
        JOIN
    persons_buildings pb ON pb.building_id = b.id
        JOIN
    persons p ON pb.person_id = p.id
GROUP BY building_name
ORDER BY persons_count DESC;

(SELECT 
    c.name company_name,
    b.status,
    SUM(b.rent_amount) sum,
    COUNT(b.id) buildings_count
FROM
    buildings b
        JOIN
    companies c ON c.id = b.company_id
WHERE
    status = 'FREE'
GROUP BY company_name) UNION (SELECT 
    c.name company_name,
    b.status,
    SUM(b.rent_amount) sum,
    COUNT(b.id) buildings_count
FROM
    buildings b
        JOIN
    companies c ON c.id = b.company_id
WHERE
    status = 'RENTED'
GROUP BY company_name) ORDER BY sum DESC , buildings_count DESC;