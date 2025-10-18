CREATE DATABASE DB_KJCGym;
GO

USE DB_KJCGym;
GO

--Hacer su usuario en SQL Server y darle permisos necesarios antes de correr este script
--Credenciales; Database=DB_KJCGym; User Id=estudiantepoec; Password=ITCA321;

--Table: Usuario
CREATE TABLE Usuario (
    IdUsuario INT IDENTITY(1,1) PRIMARY KEY,
    NombreCompleto NVARCHAR(100) NOT NULL,
    Correo NVARCHAR(100) NOT NULL UNIQUE,
    ContrasenaHash NVARCHAR(256) NOT NULL,
    Rol NVARCHAR(50) NOT NULL,
    FechaRegistro DATETIME DEFAULT GETDATE(),
    Estado BIT DEFAULT 1
);

-- Insertar este dato de prueba
INSERT INTO Usuario (NombreCompleto, Correo, ContrasenaHash, Rol)
VALUES ('Kevin Miranda', 'kevin@test.com', '9d4e1e23bd5b727046a9e3b4b7db57bd8d6ee684', 'Gerente');

--Poner más tablas e inserciones según sea necesario para ir actualizando la base de datos
--Falta agregar las tablas de Cliente, Empleado, Sucursal y otras relacionadas al gimnasio que se requieran
--Si se refencian tablas porfavor comentar las llaves foraneas para evitar errores al correr el script por primera vez
