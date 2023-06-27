-- Atencion Medica
DROP TABLE IF EXISTS LineaReceta;
DROP TABLE IF EXISTS RecetaMedica;
DROP TABLE IF EXISTS Diagnostico;
DROP TABLE IF EXISTS CitaMedica;

-- Drops Modulo Itinerario
DROP TABLE IF EXISTS ProgramaAtencion;
DROP TABLE IF EXISTS DiaSemana;

-- Usuarios
DROP TABLE IF EXISTS Administrador;
DROP TABLE IF EXISTS Medico;
DROP TABLE IF EXISTS Paciente;
DROP TABLE IF EXISTS UsuarioRol;
DROP TABLE IF EXISTS Usuario;
DROP TABLE IF EXISTS Rol;
DROP TABLE IF EXISTS Especialidad;

-- Drops Modulo Medicinas
DROP TABLE IF EXISTS CategoriaComponente;
DROP TABLE IF EXISTS MedicamentoComponente;
DROP TABLE IF EXISTS Componente;
DROP TABLE IF EXISTS Categoria;
DROP TABLE IF EXISTS Inventario;
DROP TABLE IF EXISTS Medicamento;



-- Creacion de tablas del modulo Usuarios
CREATE TABLE Rol(
    id_rol INT AUTO_INCREMENT,
    cargo VARCHAR(50),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_rol)
) ENGINE = InnoDB;


CREATE TABLE Usuario(
    id_usuario INT AUTO_INCREMENT,
    dni VARCHAR(100),
    edad INT,
    nombre VARCHAR(100),
    apellido VARCHAR(100),
    correo VARCHAR(100),
    genero VARCHAR(100),
    telefono VARCHAR(9),
    contraseña VARCHAR(100),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_usuario)
) ENGINE = InnoDB;

CREATE TABLE UsuarioRol(
    id_usuario INT,
    id_rol INT,
    PRIMARY KEY(id_usuario, id_rol),
    FOREIGN KEY(id_usuario) REFERENCES Usuario(id_usuario),
    FOREIGN KEY(id_rol) REFERENCES Rol(id_rol)
) ENGINE = InnoDB;


CREATE TABLE Administrador (
    id_administrador INT AUTO_INCREMENT,
    id_usuario INT,
    tipo VARCHAR(100),-- Director, Secretario
    codigo_trabajo VARCHAR(10),
    experiencia INT,
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_administrador),
    FOREIGN KEY(id_usuario) REFERENCES Usuario(id_usuario)
) ENGINE = InnoDB;


CREATE TABLE Especialidad(
    id_especialidad INT AUTO_INCREMENT,
    nombre_especialidad VARCHAR(100),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_especialidad)
) ENGINE = InnoDB;


CREATE TABLE Medico(
    id_medico INT AUTO_INCREMENT,
    id_usuario INT,
    id_especialidad INT,
    experiencia INT,
    estudios VARCHAR(500),
    cmp INT,
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_medico),
    FOREIGN KEY(id_usuario) REFERENCES Usuario(id_usuario),
    FOREIGN KEY(id_especialidad) REFERENCES Especialidad(id_especialidad)
) ENGINE = InnoDB;


CREATE TABLE Paciente(
id_paciente INT AUTO_INCREMENT,
id_usuario INT,
primera_visita DATE,
ultima_visita DATE,
activo BIT(1) DEFAULT 1,
PRIMARY KEY(id_paciente),
FOREIGN KEY(id_usuario) REFERENCES Usuario(id_usuario)
) ENGINE = InnoDB;




-- Creacion de tablas del modulo Medicinas
CREATE TABLE Medicamento(
    id_medicamento INT AUTO_INCREMENT,
    id_inventario INT,
    nombre_comercial VARCHAR(100) NOT NULL,
    nombre_laboratorio VARCHAR(100),
    descripcion_medicamento VARCHAR(500),
    precio DECIMAL(10, 2),
    PRIMARY KEY(id_medicamento)
);


CREATE TABLE Categoria(
    id_categoria INT AUTO_INCREMENT,
    nombre_categoria VARCHAR(50) NOT NULL,
    descripcion_categoria VARCHAR(500),
    PRIMARY KEY(id_categoria)
);


CREATE TABLE Componente(
    id_componente INT AUTO_INCREMENT,
    nombre_componente VARCHAR(50) NOT NULL,
    PRIMARY KEY(id_componente)
);


CREATE TABLE CategoriaComponente(
    id_categoria_componente INT AUTO_INCREMENT,
    id_categoria INT,
    id_componente INT,
    PRIMARY KEY(id_categoria_componente),
    FOREIGN KEY(id_categoria) REFERENCES Categoria(id_categoria),
    FOREIGN KEY(id_componente) REFERENCES Componente(id_componente)
);


CREATE TABLE MedicamentoComponente(
    id_medicamento_componente INT AUTO_INCREMENT,
    id_medicamento INT,
    id_componente INT,
    PRIMARY KEY(id_medicamento_componente),
    FOREIGN KEY(id_medicamento) REFERENCES Medicamento(id_medicamento),
    FOREIGN KEY(id_componente) REFERENCES Componente(id_componente)
);

CREATE TABLE Inventario(
    id_inventario INT AUTO_INCREMENT,
    id_medicamento INT,
    lote VARCHAR(100),
    fecha_caducidad DATE,
    fecha_ingreso DATE,
    PRIMARY KEY(id_inventario),
    FOREIGN KEY(id_medicamento) REFERENCES Medicamento(id_medicamento)
);


-- Creacion de tablas del modulo Itinerarios
CREATE TABLE DiaSemana(
    id_dia_semana INT AUTO_INCREMENT,
    nombre_dia VARCHAR(100),
    PRIMARY KEY(id_dia_semana)
) ENGINE = InnoDB;

CREATE TABLE ProgramaAtencion(
    id_programa INT AUTO_INCREMENT,
    id_medico INT,
    id_dia_semana INT,      
    hora_inicio TIME,
    hora_fin TIME,
    fecha DATE,
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_programa),
    FOREIGN KEY(id_medico) REFERENCES Medico(id_medico),
    FOREIGN KEY(id_dia_semana) REFERENCES DiaSemana(id_dia_semana)
) ENGINE = InnoDB;

-- Creacion de tablas del modulo Atencion Medica
CREATE TABLE CitaMedica(
    id_cita int auto_increment,
    id_paciente int,
    id_programa int,
    id_medico int,
    motivo_cita varchar(500),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_cita),
    FOREIGN KEY(id_programa) references ProgramaAtencion(id_programa),
    FOREIGN KEY(id_paciente) references Paciente(id_paciente),
    FOREIGN KEY(id_medico) references Medico(id_medico)
) ENGINE = InnoDB;


CREATE TABLE RecetaMedica(
    id_receta_medica int auto_increment,
    id_cita int,
    vigencia_inicio DATE,
    vigencia_fin DATE,
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_receta_medica),
    FOREIGN KEY(id_cita) references CitaMedica(id_cita)
) ENGINE = InnoDB;


CREATE TABLE LineaReceta(
    id_linea_receta int auto_increment,
    id_receta_medica int,
    id_medicamento int,
    dosis varchar(500),
    frecuencia varchar(500),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_linea_receta),
    FOREIGN KEY(id_medicamento) references Medicamento(id_medicamento),
    FOREIGN KEY(id_receta_medica) references RecetaMedica(id_receta_medica)
) ENGINE = InnoDB;


CREATE TABLE Diagnostico(
    id_diagnostico int auto_increment,
    id_cita int,
    descripcion varchar(500),
    tratamiento varchar(500),
    activo BIT(1) DEFAULT 1,
    PRIMARY KEY(id_diagnostico),
    FOREIGN KEY(id_cita) references CitaMedica(id_cita)
) ENGINE = InnoDB;

  