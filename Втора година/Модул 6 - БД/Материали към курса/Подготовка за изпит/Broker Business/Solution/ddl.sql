CREATE DATABASE broker_bussines_db;

USE broker_bussines_db;

CREATE TABLE cities (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    country_name VARCHAR(60) 
);

CREATE TABLE companies (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(45) NOT NULL,
    rate INT NOT NULL,
	created_on DATE NOT NULL,
    CONSTRAINT CHK_RATE CHECK(rate >= 0 AND rate <= 10)
);

CREATE TABLE persons (
	id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(30) NOT NULL UNIQUE,
	company_id INT,
    city_id INT NOT NULL,
	FOREIGN KEY(company_id) REFERENCES companies(id),
	FOREIGN KEY(city_id) REFERENCES cities(id)
);

CREATE TABLE person_info (
	id INT PRIMARY KEY AUTO_INCREMENT,
	first_name VARCHAR(60) NOT NULL,
	last_name VARCHAR(60),
    money DECIMAL(15,2) DEFAULT 0,
    person_id INT UNIQUE,
    FOREIGN KEY(person_id) REFERENCES persons(id)
);

CREATE TABLE building_types (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(30) NOT NULL UNIQUE
);

CREATE TABLE buildings (
	id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(80) NOT NULL UNIQUE,
    rent_amount DECIMAL(17,2) NOT NULL,
	height DECIMAL(15,2) NOT NULL,
	floors INT,
	finished_year INT,
    status VARCHAR(50) NOT NULL,
    city_id INT NOT NULL,
    type_id INT NOT NULL,
    company_id INT NOT NULL,
    FOREIGN KEY(city_id) REFERENCES cities(id),
    FOREIGN KEY(type_id) REFERENCES building_types(id),
    FOREIGN KEY(company_id) REFERENCES companies(id),
    CHECK(status = 'FREE' OR status = 'RENTED' OR status = 'DEPOSITED')
);

CREATE TABLE persons_buildings(
	person_id INT NOT NULL,
    building_id INT NOT NULL,
    PRIMARY KEY(person_id, building_id),
    FOREIGN KEY(person_id) REFERENCES persons(id),
    FOREIGN KEY(building_id) REFERENCES buildings(id));