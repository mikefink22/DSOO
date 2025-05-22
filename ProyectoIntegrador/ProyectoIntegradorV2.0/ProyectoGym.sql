/*--------------------------------------------------------------------*/
/* ----- Base de Datos del Proyecto Integrador: Club Deportivo ----- */



drop database if exists ProyectoGym;
create database ProyectoGym;
use ProyectoGym;


-- Tabla roles --
create table roles(
RolUsu int,
NomRol varchar(30),
constraint primary key(RolUsu)
);

insert into roles values
(120,'Administrador'),
(121,'Empleado');

-- Tabla usuario --
create table usuario(
CodUsu int auto_increment,
NombreUsu varchar (20),
PassUsu varchar (15),
RolUsu int,
Activo boolean default true,
constraint pk_usuario primary key (CodUsu),
constraint fk_usuario foreign key(RolUsu) references roles(RolUsu)
);

insert into usuario(NombreUsu,PassUsu,RolUsu) values
('Mari2023','123456',120),
('LopezRamiro','empleado500',121),
('UsuarioPrueba','Usu2023',120);


-- Tabla Cliente
create table cliente(
    Doc int,
    TDoc varchar(20),
    Nombre varchar(30),
    Apellido varchar(40),
    FechaNac date,
    Direccion varchar(50),
    Telefono varchar(20),
    Email varchar(50),
    AptoMedico boolean not null,
    constraint pk_cliente primary key (Doc)
);


-- Tabla Socio
create table socio (
    idSocio int,
    Doc int, 
    Estado varchar(10) DEFAULT 'Activo', 
    CarnetEntregado boolean DEFAULT true,  
    FechaInscripcion DATE,
    constraint pk_socio primary key(idSocio),
    foreign key (Doc) references cliente(Doc)
);



-- VISUALIZAR SOCIOS CARGADOS:
/* 
select 
    s.idSocio AS `ID Socio`,
    s.Estado AS `Estado`,
    c.Nombre AS `Nombre`,
    c.Apellido AS `Apellido`,
    c.TDoc AS `Tipo doc`,
    c.Doc AS `Nro doc`,
    c.FechaNac AS `Fecha Nac`,
    s.FechaInscripcion AS `Fecha Inscripcion`,
    CASE 
        when s.CarnetEntregado = 1 then'Entregado'
        else 'No entregado'
    END AS `Carnet`
from socio s
join cliente c ON s.Doc = c.Doc;
*/
