-- 1
CREATE DATABASE minions;

-- 2
USE minions;

CREATE TABLE minions
(
	id INT PRIMARY KEY,
    name VARCHAR(50),
    age INT
);

CREATE TABLE towns
(
	id INT PRIMARY KEY,
    name VARCHAR(50)
);

-- 3
ALTER TABLE minions
ADD COLUMN town_id INT;

ALTER TABLE minions
ADD CONSTRAINT fk_town_id
FOREIGN KEY(town_id) REFERENCES towns(id);

-- 4
INSERT INTO towns (id, name)
VALUES (1, 'Sofia'),
		(2, 'Plovdiv'),
        (3, 'Varna');

INSERT INTO minions (id, name, age, town_id)
VALUES (1, 'Kevin', 22, 1),
		(2, 'Bob', 15, 3),
        (3, 'Steward', null, 2);

-- 5
TRUNCATE TABLE minions;

-- 6
DROP TABLE minions;
DROP TABLE towns;

-- 7
CREATE TABLE people
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(200) NOT NULL,
    picture BLOB(2),
    height DOUBLE(10, 2),
    weight DOUBLE(10, 2),
    gender CHAR(1) NOT NULL
    CONSTRAINT CHECK (gender='m' OR gender='f'),
    birthdate DATE NOT NULL,
    biography TEXT
);

INSERT INTO people (name, picture, height, weight, gender, birthdate, biography)
VALUES ('FirstUser', null, 1.70, 60, 'm', '2000-01-01', 'Very long string'),
		('SecondUser', null, 1.80, 200, 'm', '2002-02-02', 'qw94tiygop'),
        ('ThirdUser', null, 1.60, 80, 'f', '1988-03-05', 'q3589yq3'),
        ('FourthUser', null, 1.55, 97.4, 'm', '2004-09-09', 'qa456th5'),
        ('FifthUser', null, 1.74, 150, 'f', '1999-12-09', '53h89');
        
-- 8
CREATE TABLE users
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(30) UNIQUE NOT NULL,
    password VARCHAR(26) NOT NULL,
    profile_picture BLOB,
    last_login_time DATETIME,
    is_deleted VARCHAR(5)
    CONSTRAINT CHECK (is_deleted='true' OR is_deleted='false')
);

INSERT INTO users (username, password, last_login_time, is_deleted)
VALUES ('user1', '1234', '2021-11-28', 'false'),
		('formeruser', 'shitp@ssw0rd', '2008-11-11', 'true'),
        ('user2', 'qwerty', '2020-01-12', 'false'),
        ('user6', 'owowowowo', '2000-12-31', 'true'),
        ('user949', 'cwref', '2021-10-10', 'false');
        
-- 9
ALTER TABLE users
DROP PRIMARY KEY,
ADD PRIMARY KEY (id, username);

-- 10
ALTER TABLE users
MODIFY COLUMN last_login_time DATETIME NOT NULL DEFAULT NOW();

-- 11
ALTER TABLE users
DROP PRIMARY KEY,
ADD PRIMARY KEY (id),
ADD CONSTRAINT uq_username
UNIQUE(username);

-- 12
CREATE DATABASE movies;

USE movies;

CREATE TABLE directors
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    director_name VARCHAR(25) NOT NULL,
    notes TEXT
);

CREATE TABLE genres
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    genre_name VARCHAR(25) NOT NULL,
    notes TEXT
);

CREATE TABLE categories
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(25) NOT NULL,
    notes TEXT
);

CREATE TABLE movies
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(25) NOT NULL,
    director_id INT,
    FOREIGN KEY(director_id) REFERENCES directors(id),
    copyright_year INT,
    length TIME NOT NULL,
    genre_id INT,
    FOREIGN KEY(genre_id) REFERENCES genres(id),
    category_id INT,
    FOREIGN KEY(category_id) REFERENCES categories(id),
    rating DOUBLE,
    notes TEXT
);

INSERT INTO directors(director_name)
VALUES ('Director One'),
	('Director Two'),
    ('Director Three'),
    ('Director Four'),
    ('Director Five');
    
INSERT INTO genres(genre_name)
VALUES ('Comedy'),
	('Drama'),
    ('Documentary'),
    ('Soap'),
    ('Romance');
    
INSERT INTO categories(category_name)
VALUES ('Cat1'),
	('Cat2'),
    ('Cat3'),
    ('Cat4'),
    ('Cat5');

INSERT INTO movies(title, director_id, copyright_year, length, genre_id, category_id, rating)
VALUES ('Funny Movie', 2, 1988, '2:32', 1, 4, 5.63),
	('History of China', 4, 2006, '3:22', 3, 2, 6.55),
	('The Girl', 1, 1997, '1:20', 4, 1, 9.98),
	('Dramatic Movie', 3, 1963, '0:58', 2, 4, 2.33),
	('Coronavirus Documentary', 5, 2020, '1:40', 3, 4, 7.66);
    
SELECT * FROM movies;

-- 13
CREATE DATABASE soft_uni;

USE soft_uni;

CREATE TABLE towns
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL
);

CREATE TABLE addresses
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    address_text TEXT,
    town_id INT NOT NULL,
    FOREIGN KEY(town_id) REFERENCES towns(id)
);

CREATE TABLE departments
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL
);

CREATE TABLE employees
(
	id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(25) NOT NULL,
    middle_name VARCHAR(25),
    last_name VARCHAR(25) NOT NULL,
    job_title VARCHAR(25) NOT NULL,
    department_id INT,
    FOREIGN KEY(department_id) REFERENCES departments(id),
    hire_date DATE,
    salary DECIMAL NOT NULL,
    address_id INT NOT NULL,
    FOREIGN KEY(address_id) REFERENCES addresses(id)
);