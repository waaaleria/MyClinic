-- SP
DROP PROCEDURE IF EXISTS INSERTAR_CITA;
DROP PROCEDURE IF EXISTS LISTAR_HORARIO_PACIENTE_FECHA_INI_FINAL;
DROP PROCEDURE IF EXISTS LISTAR_CITAS_POR_PACIENTE_CON_FECHAS;
DROP PROCEDURE IF EXISTS LISTAR_CITAS_X_PACIENTE;
DROP PROCEDURE IF EXISTS LISTAR_DIAGNOSTICO_X_CITA;
DROP PROCEDURE IF EXISTS LISTAR_RECETA_MEDICA_X_CITA;
DROP PROCEDURE IF EXISTS LISTAR_RECETAXCITA;
DROP PROCEDURE IF EXISTS LISTAR_PACIENTES_TODOS;
DROP PROCEDURE IF EXISTS LISTAR_PACIENTES_X_DNI_NOMBRE;
DROP PROCEDURE IF EXISTS LISTAR_HORARIOS_X_FECHA_MEDICO;
DROP PROCEDURE IF EXISTS OBTENER_DATOS_MEDICO_INDIVIDUAL;
DROP PROCEDURE IF EXISTS ELIMINAR_CITAMEDICA;

DELIMITER $
CREATE PROCEDURE INSERTAR_CITA(
    OUT _idCitaMedica INT,
    IN _idUsuario INT,
    IN _idMedico INT,
    IN _idprograma INT
)
BEGIN
	set @var_id_paciente =0;
	select p.id_paciente into @var_id_paciente from Usuario u , Paciente p 
    where u.id_usuario=p.id_usuario and u.id_usuario=_idUsuario;
    INSERT INTO CitaMedica(id_medico,id_paciente,id_programa) VALUES(_idMedico,@var_id_paciente,_idprograma);
    SET _idCitaMedica = @@last_insert_id;
    UPDATE ProgramaAtencion
	SET activo = 0 -- cambiar el horario a no disponible
	WHERE id_programa=_idprograma;
END$


DELIMITER $
CREATE PROCEDURE LISTAR_CITAS_X_PACIENTE(
IN _id_paciente INT)
BEGIN
SELECT c.id_cita, pA.fecha, pA.hora_inicio, pA.hora_fin, m.id_medico, 
    e.nombre_especialidad, c.motivo_cita
    FROM ProgramaAtencion pA INNER JOIN CitaMedica c ON pA.id_programa = c.id_programa
    INNER JOIN Paciente p ON c.id_paciente = p.id_paciente
    INNER JOIN Usuario u ON p.id_usuario = u.id_usuario
    INNER JOIN Medico m ON c.id_medico = m.id_medico
    INNER JOIN Especialidad e ON m.id_especialidad = e.id_especialidad
    WHERE c.id_paciente = _id_paciente;
END$





DELIMITER $
CREATE PROCEDURE LISTAR_DIAGNOSTICO_X_CITA(
    IN _id_cita INT
)
BEGIN
    SELECT d.id_diagnostico,d.descripcion, d.recomendaciones
    FROM Diagnostico d INNER JOIN CitaMedica c ON d.id_cita = c.id_cita
    WHERE d.activo = 1 AND d.id_cita = _id_cita;
END$



DELIMITER $
CREATE PROCEDURE LISTAR_RECETA_MEDICA_X_CITA(
    IN _id_cita INT
)
BEGIN
    SELECT r.id_receta_medica,r.vigencia_fin
    FROM RecetaMedica r INNER JOIN CitaMedica c ON r.id_cita = c.id_cita
    WHERE r.activo = 1 AND r.id_cita = _id_cita;
END$




DELIMITER $
CREATE PROCEDURE LISTAR_RECETAXCITA(
IN _id_cita INT)
BEGIN
SELECT lr.id_medicamento, lr.dosis, lr.frecuencia
FROM  RecetaMedica rm, LineaReceta lr where rm.id_cita=_id_cita and rm.id_receta_medica=lr.id_receta_medica;
END$



DELIMITER $
CREATE PROCEDURE LISTAR_PACIENTES_TODOS()
BEGIN 
    SELECT p.id_paciente, p.primera_visita, p.ultima_visita,
    u.id_usuario, u.nombre, u.apellido, u.dni,u.edad, u.telefono, u.genero, u.correo, u.contraseña
    FROM Paciente p 
    INNER JOIN Usuario u ON p.id_usuario = u.id_usuario;
END$



DELIMITER $
CREATE PROCEDURE LISTAR_PACIENTES_X_DNI_NOMBRE(
    IN _dni_nombre VARCHAR(50)
)
BEGIN
    SELECT p.id_paciente, u.dni, u.nombre, u.apellido
    FROM Paciente p
    INNER JOIN Usuario u ON p.id_usuario = u.id_usuario
    WHERE u.activo = 1
	AND (u.nombre LIKE CONCAT('%', _dni_nombre, '%') OR u.dni LIKE CONCAT('%', _dni_nombre, '%'));
END$


DELIMITER $
CREATE PROCEDURE LISTAR_HORARIOS_X_FECHA_MEDICO(
    IN _id_medico INT,
    IN _fecha DATE
)
BEGIN
    select pa.id_programa,pa.id_medico,pa.fecha , pa.hora_inicio, pa.hora_fin ,pa.id_dia_semana
from Medico m inner join ProgramaAtencion pa
on m.id_medico = pa.id_medico
inner join DiaSemana Ds on pa.id_dia_semana= Ds.id_dia_semana
and  pa.fecha = _fecha 
and m.id_medico=_id_medico
and pa.activo=1; -- solo listar los horarios disponibles 
END$


DELIMITER $
CREATE PROCEDURE `LISTAR_CITAS_POR_PACIENTE_CON_FECHAS`(
    IN _id_paciente INT,
    IN _fecha_inicio DATE,
    IN _fecha_fin DATE
)
BEGIN
	SELECT cm.id_cita,cm.id_medico,cm.motivo_cita,pr.fecha 
	FROM CitaMedica cm, ProgramaAtencion pr 
	where cm.id_programa=pr.id_programa 
	and id_paciente = _id_pacienteCitaMedicaInventario
	and pr.fecha BETWEEN _fecha_inicio AND _fecha_fin;
END$

DELIMITER $
CREATE PROCEDURE ELIMINAR_CITAMEDICA(
  IN _id_citaMedica INT
)
BEGIN
    UPDATE CitaMedica set activo=0 where id_cita=_id_citaMedica;
END$

DELIMITER $
CREATE PROCEDURE LISTAR_HORARIO_PACIENTE_FECHA_INI_FINAL(
    IN _idusuario INT,
    IN _fechaini DATE,
    IN _fechafin DATE
)
BEGIN
    select c.id_cita, pa.fecha, pa.hora_fin, pa.hora_inicio, concat(u2.nombre,' ', u2.apellido) as nombremedico, e.nombre_especialidad 
from CitaMedica c, Paciente p, Usuario u,ProgramaAtencion pa , Medico m ,Usuario u2,Especialidad e
 where c.id_paciente=p.id_paciente and
 u.id_usuario=p.id_usuario and 
 c.id_programa= pa.id_programa and
 c.id_medico=m.id_medico and
 u2.id_usuario= m.id_usuario and
 c.activo=1 and
 m.id_especialidad=e.id_especialidad and
 fecha between _fechaini and _fechafin
	and u.id_usuario= _idusuario;
END$


DELIMITER $
CREATE PROCEDURE OBTENER_DATOS_MEDICO_INDIVIDUAL(
    IN _idmedico INT
)
BEGIN
select m.cmp, m.estudios, u.nombre, u.apellido, m.experiencia from Medico m, Usuario u where m.id_usuario=u.id_usuario and m.id_medico=_idmedico;
END$
