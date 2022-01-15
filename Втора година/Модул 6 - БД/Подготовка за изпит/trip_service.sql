CREATE DATABASE trip_service;
USE trip_service;

CREATE TABLE cities (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(20) NOT NULL,
    country_code CHAR(2) NOT NULL
);

CREATE TABLE hotels (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL,
    city_id INT NOT NULL,
    employee_count INT NOT NULL,
    base_rate DOUBLE(15 , 2 ),
    FOREIGN KEY (city_id)
        REFERENCES cities (id)
);

CREATE TABLE rooms (
    id INT PRIMARY KEY,
    price DOUBLE(15 , 2 ) NOT NULL,
    type VARCHAR(20) NOT NULL,
    beds INT NOT NULL,
    hotel_id INT NOT NULL,
    FOREIGN KEY (hotel_id)
        REFERENCES hotels (id)
);

CREATE TABLE trips (
    id INT PRIMARY KEY AUTO_INCREMENT,
    room_id INT NOT NULL,
    book_date DATE NOT NULL,
    arrival_date DATE NOT NULL,
    return_date DATE NOT NULL,
    cancel_date DATE,
    FOREIGN KEY (room_id)
        REFERENCES rooms (id)
);

CREATE TABLE accounts (
    id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    middle_name VARCHAR(20),
    last_name VARCHAR(50) NOT NULL,
    city_id INT NOT NULL,
    birth_date DATE NOT NULL,
    email VARCHAR(100) NOT NULL UNIQUE,
    FOREIGN KEY (city_id)
        REFERENCES cities (id)
);

CREATE TABLE accounts_trips (
    account_id INT NOT NULL,
    trip_id INT NOT NULL,
    luggage INT NOT NULL,
    FOREIGN KEY (account_id)
        REFERENCES accounts (id),
    FOREIGN KEY (trip_id)
        REFERENCES trips (id)
);

-- import dataset.sql

SELECT 
    id, name
FROM
    cities
WHERE
    country_code = 'BG'
ORDER BY name;

SELECT 
    CONCAT_WS(' ', first_name, middle_name, last_name) 'Full Name',
    YEAR(birth_date) BirthYear
FROM
    accounts
WHERE
    YEAR(birth_date) > 1990
ORDER BY BirthYear DESC , first_name;

SELECT 
    c.name City, COUNT(h.id) Hotels
FROM
    hotels h
        JOIN
    cities c ON h.city_id = c.id
GROUP BY city_id
ORDER BY Hotels DESC , c.name;

SELECT 
    r.id Id, r.price Price, h.name Hotel, c.name City
FROM
    rooms r
        JOIN
    hotels h ON r.hotel_id = h.id
        JOIN
    cities c ON c.id = h.city_id
WHERE
    r.type = 'First Class'
ORDER BY r.price DESC , r.id;

SELECT 
    a.id,
    CONCAT_WS(' ', a.first_name, a.last_name) FullName,
    MAX(DATEDIFF(return_date, arrival_date)) LongestTrip,
    MIN(DATEDIFF(return_date, arrival_date)) ShortestTrip
FROM
    accounts a
        JOIN
    accounts_trips at ON a.id = at.account_id
        JOIN
    trips t ON t.id = at.trip_id
WHERE
    a.middle_name IS NULL
        AND t.cancel_date IS NULL
GROUP BY a.id
ORDER BY LongestTrip DESC , a.id;

SELECT 
    c.id Id,
    c.name City,
    c.country_code Country,
    COUNT(a.id) Accounts
FROM
    cities c
        JOIN
    accounts a ON a.city_id = c.id
GROUP BY c.id
ORDER BY Accounts DESC , c.id
LIMIT 5;

SELECT 
    a.id Id, a.email Email, c.name City, COUNT(t.id) Trips
FROM
    accounts a
        JOIN
    cities c ON c.id = a.city_id
        JOIN
    accounts_trips at ON a.id = at.account_id
        JOIN
    trips t ON t.id = at.trip_id
        JOIN
    rooms r ON r.id = t.room_id
        JOIN
    hotels h ON h.id = r.hotel_id
WHERE
    c.id = h.city_id
GROUP BY a.id
ORDER BY Trips DESC , a.id;