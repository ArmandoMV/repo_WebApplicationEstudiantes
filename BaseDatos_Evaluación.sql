CREATE DATABASE Evaluacion;

USE Evaluacion;

CREATE TABLE Estudiantes (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Edad INT NOT NULL
);


INSERT INTO Estudiantes (Nombre, Edad) VALUES 
('Armando', 29),
('Jose', 22),
('Thiago', 18),
('Naty', 21),
('Cristian', 23),
('Marisol', 19),
('Diana', 24),
('Ruben', 23),
('Daniel', 20),
('Pedro', 22);

CREATE PROCEDURE spObtenerEstudiantes
AS
BEGIN
    SELECT Id, Nombre, Edad FROM Estudiantes;
END


