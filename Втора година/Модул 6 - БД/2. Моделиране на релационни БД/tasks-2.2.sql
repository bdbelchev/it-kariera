-- 1
CREATE DATABASE relationship_exercises;
USE relationship_exercises;

CREATE TABLE passports (
    passport_id INT PRIMARY KEY AUTO_INCREMENT,
    passport_number CHAR(8) NOT NULL
)  AUTO_INCREMENT=101;

CREATE TABLE persons (
    person_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(25) NOT NULL,
    salary DECIMAL NOT NULL,
    passport_id INT UNIQUE NOT NULL,
    CONSTRAINT fk_persons_passports FOREIGN KEY (passport_id)
        REFERENCES passports (passport_id)
);

INSERT INTO passports(passport_number) VALUES
('N34FG21B'),
('K65LO4R7'),
('ZE657QP2');

INSERT INTO persons(first_name, salary, passport_id) VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Yana', 60200.00, 101);

-- 2
CREATE TABLE manufacturers (
    manufacturer_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL UNIQUE,
    established_on DATE NOT NULL
);

CREATE TABLE models (
    model_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL,
    manufacturer_id INT NOT NULL,
    CONSTRAINT fk_models_manufacturers FOREIGN KEY (manufacturer_id)
        REFERENCES manufacturers (manufacturer_id)
)  AUTO_INCREMENT=101;

INSERT INTO manufacturers(name, established_on) VALUES
('BMW', '1916/03/01'),
('Tesla', '2003/01/01'),
('Lada', '1966/05/01');

INSERT INTO models(name, manufacturer_id) VALUES
('X1', 1),
('i6', 1),
('Model 5', 2),
('Model X', 2),
('Model 3', 2),
('Nova', 3);

-- 3
CREATE TABLE students (
    student_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL
);

CREATE TABLE exams (
    exam_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL
)  AUTO_INCREMENT=101;

CREATE TABLE students_exams (
    student_id INT,
    CONSTRAINT fk_students_exams_students FOREIGN KEY (student_id)
        REFERENCES students (student_id),
    exam_id INT,
    CONSTRAINT fk_students_exams_exams FOREIGN KEY (exam_id)
        REFERENCES exams (exam_id),
    CONSTRAINT pk_student_exam_id PRIMARY KEY (student_id , exam_id)
);

INSERT INTO students(name) VALUES
('Mila'), ('Toni'), ('Ron');

INSERT INTO exams(name) VALUES
('Spring MVC'), ('Neo4j'), ('Oracle 11g');

INSERT INTO students_exams VALUES
(1, 101), (1, 102), (2, 101), (3, 103), (2, 102), (2, 103);

-- 4
CREATE TABLE teachers (
    teacher_id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(25) NOT NULL,
    manager_id INT,
    CONSTRAINT fk_teachers_managers FOREIGN KEY (manager_id)
        REFERENCES teachers (teacher_id)
);

INSERT INTO teachers VALUES
(101, 'John', null),
(106, 'Greta', 101),
(105, 'Mark', 101),
(102, 'Maya', 106),
(103, 'Silvia', 106),
(104, 'Ted', 105);