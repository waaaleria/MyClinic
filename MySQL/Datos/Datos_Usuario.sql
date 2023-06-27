-- Roles
INSERT INTO Rol (cargo) VALUES
  ('Administrador'),
  ('Médico'),
  ('Paciente'),
  ('Almacenista');


-- Usuarios
--  Administrador
INSERT INTO Usuario (dni, edad, nombre, apellido, correo, genero, telefono, contraseña) VALUES 
    ('000000000', 30, 'Maria', 'Perez', 'maria@example.com', 'Femenino', '123456789', 'contrasena'),
    ('262626262', 27, 'Valeria', 'Mejía', 'valeria@example.com', 'Femenino', '369852147', 'contrasena');


-- Medico
INSERT INTO Usuario(dni, edad, nombre, apellido, correo, genero, telefono, contraseña) VALUES
    ('222222222', 29, 'Luis', 'Ramírez', 'luis@ejemplo.com', 'Masculino', '777777777', 'contrasena'),
    ('333333333', 25, 'Roberto', 'Carlos', 'rb@example.com', 'Masculino', '555555555', 'contrasena'),
    ('101010101', 30, 'Carolina', 'Torres', 'carolina@example.com', 'Femenino', '123456789', 'contrasena'),
    ('121212121', 28, 'Alejandro', 'Vargas', 'alejandro@example.com', 'Masculino', '987654321', 'contrasena'),
    ('131313131', 34, 'Valentina', 'Silva', 'valentina@example.com', 'Femenino', '456789123', 'contrasena'),
    ('141414141', 31, 'Fernando', 'Mendoza', 'fernando@example.com', 'Masculino', '741852963', 'contrasena');

-- Pacientes
INSERT INTO Usuario(dni, edad, nombre, apellido, correo, genero, telefono, contraseña) VALUES
    ('444444444', 25, 'Victoria', 'Pedretti', 'vittorap@example.com', 'Femenino', '123456789', 'contrasena'),
    ('555555555', 25, 'Carlos', 'García', 'carlitos@example.com', 'Masculino', '444444444', 'contrasena'),
    ('323232323', 30, 'Gabriela', 'Ramírez', 'gabriela@example.com', 'Femenino', '123456789', 'contrasena'),
    ('333333333', 28, 'Ricardo', 'Silva', 'ricardo@example.com', 'Masculino', '987654321', 'contrasena'),
    ('343434343', 33, 'María José', 'Castaño', 'mariajose@example.com', 'Femenino', '456789123', 'contrasena'),
    ('353535353', 31, 'Fernando', 'Mendoza', 'fermendoza@example.com', 'Masculino', '741852963', 'contrasena');


-- Almacenistas
INSERT INTO Usuario (dni, edad, nombre, apellido, correo, genero, telefono, contraseña) VALUES 
	('666666666', 25, 'Carla', 'García', 'carlita@example.com', 'Femenino', '789456123', 'contrasena'),
	('777777777', 25, 'Adolfo', 'Velasquez', 'adolfv@example.com', 'Masculino', '123456789', 'contrasena'),
	('535353535', 28, 'Valeria', 'Ramírez', 'valeria2@example.com', 'Femenino', '987654321', 'contrasena');

-- Usuario Medico y paciente
INSERT INTO Usuario (dni, edad, nombre, apellido, correo, genero, telefono, contraseña) VALUES 
    ('888888888', 25, 'Luis', 'Sera', 'luisera@exm.com', 'Masculino', '123456789', 'contrasena'),
    ('999999999', 30, 'Juan', 'Perez', 'juan@example.com', 'Masculino', '123456789', 'contrasena'),
    ('505050505', 26, 'Pedro', 'Hernández', 'pedro2@example.com', 'Masculino', '852963741', 'contrasena');
    

-- Roles por usuario

-- Administrador
INSERT INTO UsuarioRol (id_usuario, id_rol) VALUES
    (1, 1),
    (2, 1);

-- Medico
INSERT INTO UsuarioRol(id_usuario, id_rol) VALUES
	(3, 2),
    (4, 2),
    (5, 2),
    (6, 2),
    (7, 2),
    (8, 2);

-- Paciente
INSERT INTO UsuarioRol(id_usuario, id_rol) VALUES
    (9, 3),
    (10, 3),
    (11, 3),
    (12, 3),
    (13, 3),
    (14, 3);

-- Almacenista
INSERT INTO UsuarioRol (id_usuario, id_rol) VALUES 
	(15, 4),
    (16, 4),
    (17, 4);
    
-- Medico y paciente
INSERT INTO UsuarioRol(id_usuario, id_rol) VALUES
	(18, 2),
    (18, 3),
    (19, 2),
    (19, 3),
    (20, 2),
    (20, 3);


-------------------------------------------------------------------------------
-- Tablas de especialidad, medico, paciente, administrador, almacenista 
-------------------------------------------------------------------------------
INSERT INTO Administrador (id_usuario, tipo, codigo_trabajo, experiencia) VALUES
	(1, 'Director', 'DT001', 5),
	(2, 'Secretario', 'ST001', 3),
    (15, 'Almacenista', 'AT001', 2),
    (16, 'Almacenista', 'AT002', 1),
    (17, 'Almacenista', 'AT003', 3);

INSERT INTO Especialidad (nombre_especialidad) VALUES
	('Cardiología'),
	('Dermatología'),
    ('Neurología'),
	('Oftalmología'),
    ('Traumatología');
    
INSERT INTO Medico (id_usuario, id_especialidad, experiencia, estudios, cmp) VALUES
	(3, 1, 1, 'Especialista en cardiologia', 23456),
	(4, 2, 2, 'Especialista en dermatologia', 12345),
	(5, 3, 3, 'Especialista en neurologia', 23456),
	(6, 4, 4, 'Especialista en oftalmologia', 12345),
    (7, 5, 5, 'Especialista en traumatologia', 23456),
    (8, 1, 6, 'Especialista en cardiologia', 12345),
    (18, 2, 5, 'Especialista en dermatologia', 32158),
    (19, 3, 6, 'Especialista en neurologia', 84651),
    (20, 4, 7, 'Especialista en oftalmologia', 96542);

INSERT INTO Paciente (id_usuario, primera_visita, ultima_visita) VALUES
    (9, '2021-01-01', '2021-02-28'),
    (10, '2021-03-01', '2021-04-30'),
    (11, '2021-05-01', '2021-06-30'),
    (12, '2021-07-01', '2021-08-31'),
    (13, '2021-09-01', '2021-10-31'),
    (14, '2021-11-01', '2021-12-31'),
    (18, '2022-01-01', '2022-02-28'),
    (19, '2022-03-01', '2022-04-30'),
    (20, '2022-05-01', '2022-06-30');

/*
-- Ver informacion de los usuarios y su rol
SELECT u.id_usuario, u.dni, u.edad, u.nombre, u.apellido, 
u.correo, u.genero, u.telefono, GROUP_CONCAT(r.cargo SEPARATOR ', ') AS roles
FROM Usuario u
LEFT JOIN UsuarioRol ur ON u.id_usuario = ur.id_usuario
LEFT JOIN Rol r ON ur.id_rol = r.id_rol
GROUP BY u.id_usuario;

-- SELECT * FROM Usuario;
select * from Medico;
*/    
