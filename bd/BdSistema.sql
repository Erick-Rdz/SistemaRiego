CREATE DATABASE BdSistema;

GO 
USE BdSistema;

CREATE TABLE [Trabajadores](
[id][int] IDENTITY(1,1) not null,
[Nombre][nvarchar](100) not null,
[Apellido][nvarchar] (100) not null,
[Telefono][nvarchar] (50) not null,
[Direccion][nvarchar](50) not null,
);

INSERT INTO Trabajadores VALUES
('Martin','Rangel','8341172266','calle Independencia'),
('Alejandro','Lara','8341237878','calle Rosales'),
('Monica','Garza','8347891232',' calle Rios'),
('Maleny','Gonzalez','8341479898',' calle Agua Fria'),
('Ricardo','Montes','8341596431',' calle Juarez');

CREATE TABLE [Hectareas](
[Num_Hect][int] not null,
[Tipo_cultivo][nvarchar](100) not null,
[Cant_Arboles][nvarchar](50) not null,
[cant_Cosecha][nvarchar](50) not null,
);

/* no se gurdan los datos*/
INSERT INTO Hectareas VALUES
('01','Manzano','100','100'),
('02','Naranjo','150','500'),
('03','Limon','100','600'),
('04','Mango','100','200'),
('05','Mandarina','200','500');

CREATE TABLE [Inventario](
[Fertiliante][nvarchar](100) not null,
[Pesticida][nvarchar](100) not null,
[Material][nvarchar](100) not null);

/* no se guardan los datos*/
INSERT INTO Inventario VALUES
('Boxes','Fungicida','Liquido'),
('Boxes','Fungicida','Gas'),
('Boxes','Fungicida','Avono');

CREATE TABLE [Riegos](
[id][int]IDENTITY (1,1) NOT NULL,
[Fecha][date] not null,
[Hora][date] not null,
[Empl_cargo][nvarchar](50) not null,
[Fertilizante][nvarchar](50) not null,
[Num_Hect][int] not null);

/* no se guardan los datos*/
INSERT INTO Riegos VALUES
('2020-01-05','12:00','Martin','Boxes','04'),
('2020-02-15','10:20','Alejandro','Boxes','01'),
('2020-02-20','08:50','Monica','Boxes','02'),
('2020-03-25','10:50','Maleny','Boxes','03');

select * from Trabajadores;
select * from Hectareas;
select * from Inventario;
select * from Riegos;

CREATE TABLE [Administrador](
[id][int] IDENTITY(1,1) not null,
[NombreUsuario][nvarchar](100) not null,
[Password][nvarchar] (100) not null,
);


INSERT INTO Administrador VALUES
('Admin','Admin');


CREATE PROCEDURE SP_MostrarTrabajadores
as 
SELECT * FROM Trabajadores
go;

Exec SP_MostrarTrabajadores;
