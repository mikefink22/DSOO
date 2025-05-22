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
    DocC int,
    TDocC varchar(20),
    NombreC varchar(30),
    ApellidoC varchar(40),
    FechaNac date,
    constraint pk_cliente primary key (DocC)
);


-- Tabla Socio
CREATE TABLE socio (
    idSocio int,
    DocC INT, 
    AptoMedico varchar(20),
    constraint pk_socio primary key(idSocio),
    FOREIGN KEY (DocC) REFERENCES cliente(DocC)
);


