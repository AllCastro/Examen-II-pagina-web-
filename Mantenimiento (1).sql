
create database Mantenimiento 
go

use Mantenimiento
go


---Tabla de Equipos
create table equipos 
( id int identity primary key,
  nombre varchar(100)not null,
  descripcion varchar(255)
);

---Tabla de Usuarios
create table usuarios
( id int identity primary key,
  nombre varchar(100) not null,
  correo varchar(100) not null unique
);

---tabla de Téctnicos
create table tecnicos
( id int identity primary key,
  nombre varchar(100) not null,
  especialidad varchar(100)
);

---Insertar datos

insert into equipos (nombre, descripcion) values
('Laptop', 'Equipo portatil'),
('Proyector', 'Dispositivo de presentaciones');

insert into usuarios (nombre, correo) values
('Ignacio Garcia', 'ignaciogarcia12@gmail.com'),
('Maria Fernanda Madrigal', 'mfernandaMadrigal@gmail.com');

insert into tecnicos (nombre, especialidad) values
('Valeria Catillo', 'Sofware y redes'),
('Caleb Rodriguez', 'Reparación de hardware');





----PROCEDIMIENTOS

---Ingresar un equipo

create procedure IngresarEquipo
   @nombre varchar(100),
   @descripcion varchar(255)
as
begin
   insert into equipos (nombre, descripcion) values (@nombre, @descripcion);
end;

---Borrar equipo 
create procedure BorrarEquipo
  @id int 
as
begin
   delete from equipos where id = @id;
end;

---Modificar equipo
create procedure ModificarEquipo 
  @id int,
  @nombre varchar(100),
  @descripcion varchar(255)
as
begin
  update equipos 
  set nombre = @nombre, descripcion = @descripcion
  where id = @id;
end;


---Consultar equipo
create procedure ConsultarEquipos
as
begin
  select * from equipos;
end;



---ALMACENADO PARA USUARIOS (procedimientos)

---Insertar Usuarios
create procedure IngresarUsuario
   @nombre varchar(100),
   @correo varchar(100)
as
begin
  insert into usuarios (nombre, correo) values (@nombre, @correo);
end;

---Borrar Usuario
create procedure BorrarUsuario
  @id int 
as
begin
  delete from usuarios where id =@id;
end;

---Modificar Usuario 
create procedure ModificarUsuario
   @id int, 
   @nombre varchar(100),
   @correo varchar(100)
as
begin
   update usuarios 
   set nombre = @nombre, correo = @correo
   where id = @id;
end;

--- Consultar Usuatios 
create  procedure ConsultarUsuarios 
as
begin
   select * from usuarios;
end;

---ALMACENADO PARA TÉCNICOS (procedimientos)

---Insertar Técnico 
create procedure IngresarTecnico
   @nombre varchar(100),
   @especialidad varchar(100)
as
begin
  insert into usuarios (nombre, correo) values (@nombre, @especialidad);
end; 


--Borrar Técnico
create procedure BorrarTecnico
  @id int 
as
begin
  delete from tecnicos where id =@id;
end;

--- Modificar Técnico
create procedure ModificarTecnico
   @id int, 
   @nombre varchar(100),
   @especialidad varchar(100)
as
begin
   update tecnicos
   set nombre = @nombre, especialidad = @especialidad
   where id = @id;
end;


---Consultar Técnicos 
create  procedure ConsultarTecnicos 
as
begin
   select * from tecnicos;
end;
