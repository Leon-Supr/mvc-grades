DROP DATABASE IF EXISTS dbgrades;
CREATE DATABASE IF NOT EXISTS dbgrades;
USE dbgrades;
CREATE TABLE Subjects (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL
);

GRANT SELECT ON dbgrades.Subjects TO 'lectura'@'localhost';
FLUSH PRIVILEGES;

INSERT INTO Subjects (name) VALUES
('Matemáticas'),
('Física'),
('Química'),
('Historia'),
('Programación');