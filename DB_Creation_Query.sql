DROP DATABASE IF EXISTS dbgrades;
CREATE DATABASE IF NOT EXISTS dbgrades;
USE dbgrades;


-- AQUI EMPIEZAN LOS INSERT
INSERT INTO Subjects ('name') 
VALUES 
('Matemáticas'),
('Historia'),
('Ciencias');

-- Insertar múltiples Activities en una sola sentencia
INSERT INTO Activities ('subjectId', 'type', 'grade', 'date') 
VALUES 
(1, 'Tarea', 9.5, '2025-03-20'),
(1, 'Prueba', 8.7, '2025-03-21'),
(2, 'Actividad', 7.8, '2025-03-19'),
(2, 'Prueba', 6.9, '2025-03-22');

