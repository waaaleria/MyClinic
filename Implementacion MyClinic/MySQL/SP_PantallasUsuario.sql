/* 
Procedimientos almacenados relacionados a datos de pantallas
en relacion a la tabla de Usuario o Roles.
*/  



DROP PROCEDURE IF EXISTS LISTAR_ESPECIALIDAD_TODAS;
DROP PROCEDURE IF EXISTS VERIFICAR_ROLES_X_USUARIO;
DROP PROCEDURE IF EXISTS HALLAR_ID_USUARIO;
DROP PROCEDURE IF EXISTS VERIFICAR_USUARIO;
DROP PROCEDURE IF EXISTS BUSCAR_MEDICO_CON_ESPECIALIDAD;
DROP PROCEDURE IF EXISTS BUSCAR_MEDICO_x_ID_ESPECIALIDAD;
DROP PROCEDURE IF EXISTS BUSCAR_MEDICO;
DROP PROCEDURE IF EXISTS LISTAR_ADMINISTRADOR_TODOS;

DROP PROCEDURE IF EXISTS MODIFICAR_USUARIO;
DROP PROCEDURE IF EXISTS OBTENER_PACIENTE;
DROP PROCEDURE IF EXISTS LISTAR_HORARIOS_X_ID_MEDICO;
DROP PROCEDURE IF EXISTS LISTAR_MEDICO_NOMBRE_X_ESPECIALIDAD;
DROP PROCEDURE IF EXISTS MODIFICAR_MEDICO;
DROP PROCEDURE IF EXISTS OBTENER_USUARIO_X_ID;

DROP PROCEDURE IF EXISTS LISTAR_MEDICOS_TODOS;
DROP PROCEDURE IF EXISTS OBTENER_NOMBRE_MEDICAMENTO;
DROP PROCEDURE IF EXISTS OBTENER_DATOS_MEDICO;
DROP PROCEDURE IF EXISTS MODIFICAR_PERFIL_PACIENTE;


DELIMITER $
CREATE PROCEDURE VERIFICAR_ROLES_X_USUARIO(
    IN _username VARCHAR(10),
    IN _password VARCHAR(50)
)
BEGIN
    SELECT UR.id_rol, R.cargo
        FROM Usuario U
        JOIN UsuarioRol UR ON U.id_usuario = UR.id_usuario
        JOIN Rol R ON  R.id_rol = UR.id_rol
        WHERE U.dni = _username AND U.contraseña = _password ;
END$


DELIMITER $
CREATE PROCEDURE VERIFICAR_USUARIO(
    IN _dni VARCHAR(50),
    IN _contraseña VARCHAR(50)
)
BEGIN
    SELECT id_usuario, dni  FROM Usuario
     WHERE dni = _dni AND contraseña = _contraseña ;
END$



DELIMITER $
CREATE PROCEDURE HALLAR_ID_USUARIO(    
    IN _dni INT
)
BEGIN
	select u.id_usuario from Usuario u, Paciente p 
    where u.id_usuario=p.id_usuario and  u.dni=_dni;
END$


-- SP
DELIMITER $
CREATE PROCEDURE BUSCAR_MEDICO_CON_ESPECIALIDAD(
	IN _id_usuario INT
)
BEGIN 
	SELECT m.id_medico, CONCAT(u.nombre,' ',u.apellido) as nombre_completo,
		e.nombre_especialidad
    FROM Usuario u 
    INNER JOIN Medico m ON u.id_usuario = m.id_usuario
    INNER JOIN Especialidad e ON m.id_especialidad = e.id_especialidad
    WHERE u.id_usuario = _id_usuario;
END$

-- SP
DELIMITER $
CREATE PROCEDURE BUSCAR_MEDICO_x_ID_ESPECIALIDAD(
    IN _id_especialidad INT
)
BEGIN
    SELECT m.id_medico, CONCAT(u.nombre," ",u.apellido) as nombre, u.apellido
    FROM Usuario u 
    INNER JOIN Medico m ON u.id_usuario = m.id_usuario
    INNER JOIN Especialidad e ON m.id_especialidad = e.id_especialidad
    WHERE e.id_especialidad = _id_especialidad ;
END$



-- SP
DELIMITER $
CREATE PROCEDURE BUSCAR_MEDICO(
    IN _id_usuario INT
)
BEGIN
    SELECT m.id_medico,u.dni,
    CONCAT(u.nombre,' ',u.apellido) as nombre_completo,
    m.cmp, u.correo, u.telefono
    FROM Usuario u INNER JOIN Medico m ON u.id_usuario = m.id_usuario
    WHERE u.id_usuario = _id_usuario;
END$


DELIMITER $
CREATE PROCEDURE LISTAR_ADMINISTRADOR_TODOS()
BEGIN
    SELECT a.id_administrador, a.tipo, a.codigo_trabajo, a.experiencia,
    u.id_usuario, u.nombre, u.apellido, u.dni,u.edad, u.telefono, u.genero, u.correo, u.contraseña
    FROM Administrador a 
    INNER JOIN Usuario u ON a.id_usuario = u.id_usuario;
END$



DELIMITER $
CREATE PROCEDURE MODIFICAR_MEDICO(
    IN _id_usuario INT,
    IN _correo VARCHAR(100),
    IN _telefono VARCHAR(9)
)
BEGIN
    UPDATE Usuario u
    SET u.correo = _correo, u.telefono = _telefono
    WHERE u.id_usuario = _id_usuario;
END$

DELIMITER $
CREATE DEFINER=`admin`@`%` PROCEDURE MODIFICAR_PERFIL_PACIENTE(
    IN _dni VARCHAR(100),
    IN _correo VARCHAR(100),
    IN _telefono VARCHAR(9),
    IN _genero VARCHAR(100)
)
BEGIN
    UPDATE Usuario 
    SET  correo = _correo, telefono = _telefono, genero=_genero
    WHERE _dni = dni;
END$


DELIMITER $
CREATE PROCEDURE MODIFICAR_USUARIO(
    IN _id_usuario INT,
    IN _correo VARCHAR(100),
    IN _telefono VARCHAR(9),
    IN _contraseña VARCHAR(100)
)
BEGIN
    UPDATE Usuario u
    SET u.correo = _correo, u.telefono = _telefono, u.contraseña = _contraseña
    WHERE u.id_usuario = _id_usuario;
END$



DELIMITER $
CREATE PROCEDURE `OBTENER_USUARIO_X_ID`(
	IN _id_usuario INT
)
BEGIN
	SELECT u.contraseña,u.id_usuario, u.dni, u.nombre as nombre_usuario, u.apellido, u.correo, u.genero, u.telefono
    FROM Usuario u
--    INNER JOIN empleado e ON p.id_persona = e.id_empleado 
--    INNER JOIN area a ON e.fid_area = a.id_area 
--    WHERE e.activo = 1 
--    AND u.id_usuario = _id_usuario;
	WHERE u.id_usuario = _id_usuario;
END$



DELIMITER $
CREATE PROCEDURE OBTENER_DATOS_MEDICO(
IN _id_medico INT)
BEGIN
SELECT u.dni,CONCAT(u.nombre, " ", u.apellido) AS nombre_completo, e.nombre_especialidad  
    FROM  Medico m, Usuario u, Especialidad e where m.id_medico=_id_medico and u.id_usuario=m.id_usuario and e.id_especialidad=m.id_especialidad;
END$



DELIMITER $
CREATE PROCEDURE OBTENER_NOMBRE_MEDICAMENTO(
IN _id_medicamento INT)
BEGIN
select nombre_comercial from Medicamento where id_medicamento=_id_medicamento;
END$



DELIMITER $
CREATE PROCEDURE OBTENER_PACIENTE(
IN _id_usuario INT)
BEGIN
SELECT p.id_paciente
    FROM Usuario u INNER JOIN Paciente  p ON p.id_usuario = u.id_usuario where u.id_usuario=_id_usuario;
END$


-- SP
DELIMITER $
CREATE PROCEDURE `LISTAR_MEDICOS_TODOS`()
BEGIN 
    SELECT m.id_medico, m.cmp, m.id_especialidad, m.experiencia, m.estudios,
    u.id_usuario, u.nombre, u.apellido, u.dni,u.edad, u.telefono, u.genero, u.correo, u.contraseña,
    e.nombre_especialidad
    FROM Medico m
    INNER JOIN Usuario u ON m.id_usuario = u.id_usuario
    INNER JOIN Especialidad e ON m.id_especialidad = e.id_especialidad;
END$


-- SP
DELIMITER $
CREATE PROCEDURE LISTAR_MEDICO_NOMBRE_X_ESPECIALIDAD(
    IN _NOMBRE_ESPECIALIDAD VARCHAR(140)
)
BEGIN
SELECT u.nombre, u.apellido, e.nombre_especialidad, m.experiencia, m.estudios, m.id_medico
    FROM Usuario u
    INNER JOIN Medico m ON u.id_usuario = m.id_usuario
    INNER JOIN Especialidad e ON m.id_especialidad = e.id_especialidad 
    WHERE m.activo = 1 AND ((CONCAT(u.nombre ,' ',u.apellido) 
    LIKE CONCAT('%', _NOMBRE_ESPECIALIDAD,'%')) OR (e.nombre_especialidad LIKE CONCAT('%',_NOMBRE_ESPECIALIDAD,'%')));
END$


-- SP
DELIMITER $
CREATE  PROCEDURE LISTAR_HORARIOS_X_ID_MEDICO(
    IN _id_medico INT
)
BEGIN
    select pa.id_programa,pa.id_medico,pa.fecha , pa.hora_inicio, pa.hora_fin ,pa.id_dia_semana
from Medico m inner join ProgramaAtencion pa
on m.id_medico = pa.id_medico
inner join DiaSemana Ds on pa.id_dia_semana= Ds.id_dia_semana
and m.id_medico=_id_medico
and pa.activo=1; -- solo listar los horarios disponibles 
END$

DELIMITER $
CREATE PROCEDURE LISTAR_ESPECIALIDAD_TODAS()
BEGIN
    SELECT id_especialidad, nombre_especialidad 
    FROM Especialidad 
    WHERE activo = 1  ;
--    nombre LIKE CONCAT('%',_nombre,'%');
END$
