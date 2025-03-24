-- Crear la base de datos Escuela
CREATE DATABASE Escuela;
GO

-- Usar la base de datos Escuela
USE Escuela;
GO

-- Crear la tabla Estudiante
CREATE TABLE Estudiante (
    ID INT PRIMARY KEY IDENTITY(1,1), -- Clave primaria autoincremental
    Nombre VARCHAR(100) NOT NULL, -- Nombre del estudiante (obligatorio)
    Apellido VARCHAR(100) NOT NULL, -- Apellido del estudiante (obligatorio)
    FechaNacimiento DATE NOT NULL, -- Fecha de nacimiento (obligatorio)
    CorreoElectronico VARCHAR(255) NULL, -- Correo electrónico (opcional)
    Telefono VARCHAR(20) NULL, -- Teléfono (opcional)
    Grado INT NOT NULL, -- Grado (obligatorio)
    Promedio DECIMAL(4, 2) NULL, -- Promedio (opcional)
    FechaInscripcion DATETIME DEFAULT GETDATE() -- Fecha y hora de inscripción (por defecto la fecha y hora actual)
);
GO