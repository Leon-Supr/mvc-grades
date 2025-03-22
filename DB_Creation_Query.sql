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

-- AQUI EMPIEZAN LOS INSERT
INSERT INTO `Subjects` (`name`) VALUES ('Matemáticas');
INSERT INTO `Subjects` (`name`) VALUES ('Historia');
INSERT INTO `Subjects` (`name`) VALUES ('Ciencias');


-- Actividades para Matemáticas (id = 1)
INSERT INTO `Activities` (`subjectId`, `type`, `grade`, `date`) VALUES (1, 'Tarea', 9.5, '2025-03-20');
INSERT INTO `Activities` (`subjectId`, `type`, `grade`, `date`) VALUES (1, 'Prueba', 8.7, '2025-03-21');

-- Actividades para Historia (id = 2)
INSERT INTO `Activities` (`subjectId`, `type`, `grade`, `date`) VALUES (2, 'Actividad', 7.8, '2025-03-19');
INSERT INTO `Activities` (`subjectId`, `type`, `grade`, `date`) VALUES (2, 'Prueba', 6.9, '2025-03-22');
