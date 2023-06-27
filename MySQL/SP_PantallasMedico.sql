/*
    Relacionadas al medico y la modificacion de detalles de la cita y creacion de receta medica y diagnosticos
    - frmMedicoHistoricoCitas   
    - frmMedicoDetalleCita
    - frmBusquedaMedicamentos
*/ 


-- Drops
DROP PROCEDURE IF EXISTS LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS;

DROP PROCEDURE IF EXISTS MODIFICAR_CITA;
DROP PROCEDURE IF EXISTS BUSCAR_CITA;

DROP PROCEDURE IF EXISTS INSERTAR_DIAGNOSTICO;
DROP PROCEDURE IF EXISTS ELIMINAR_DIAGNOSTICO;
DROP PROCEDURE IF EXISTS LISTAR_DIAGNOSTICOS;

DROP PROCEDURE IF EXISTS INSERTAR_RECETA_MEDICA;
DROP PROCEDURE IF EXISTS BUSCAR_RECETA_MEDICA;

DROP PROCEDURE IF EXISTS INSERTAR_LINEA_RECETA;
DROP PROCEDURE IF EXISTS LISTAR_LINEA_RECETA_MEDICA;

DROP PROCEDURE IF EXISTS LISTAR_MEDICAMENTOS_TODOS;
DROP PROCEDURE IF EXISTS BUSCAR_MEDICAMENTOS;

-- Stored Procedures

-- frmMedicoHistoricoCitas
-- Permite filtrar las citas por medico, paciente y fechas
DELIMITER $
CREATE PROCEDURE LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS(
    IN _id_medico INT,
    IN _id_paciente INT,
    IN _fecha_inicio DATE,
    IN _fecha_fin DATE
)
BEGIN
    SELECT cm.id_cita,pa.fecha,cm.activo,
    CONCAT(pa.hora_inicio, ' - ', pa.hora_fin) AS horario,
    CONCAT(u.nombre, ' ', u.apellido) AS paciente,
    cm.motivo_cita 
    FROM Medico m
    INNER JOIN CitaMedica cm ON cm.id_medico = m.id_medico
    INNER JOIN ProgramaAtencion pa ON pa.id_programa = cm.id_programa
    INNER JOIN Paciente p ON p.id_paciente = cm.id_paciente
    INNER JOIN Usuario u ON u.id_usuario = p.id_usuario
    WHERE cm.id_medico = _id_medico
    AND (pa.fecha BETWEEN _fecha_inicio AND _fecha_fin OR _fecha_inicio = '0001-01-01' OR _fecha_fin = '0001-01-01')
    AND (cm.id_paciente = _id_paciente OR _id_paciente = -1)
    ORDER BY pa.fecha DESC;
END$    


-- frmMedicoDetalleCita
-- Modifica la informacion del motivo de la cita
DELIMITER $
CREATE PROCEDURE MODIFICAR_CITA(
    IN _id_cita INT,
    IN _motivo_cita VARCHAR(500)
)
BEGIN
    UPDATE CitaMedica c
    SET c.motivo_cita = _motivo_cita, c.activo = 0
    WHERE c.id_cita = _id_cita;
END$

CREATE PROCEDURE BUSCAR_CITA(
    IN _id_cita INT
)
BEGIN
    SELECT c.id_cita, c.motivo_cita
    FROM CitaMedica c 
    WHERE c.id_cita = _id_cita;       

END$

-- Pestaña diagnostico
-- Inserta la informacion de un diagnostico de una fila del dgv a la cita
CREATE PROCEDURE INSERTAR_DIAGNOSTICO(
    OUT _id_diagnostico INT,
    IN _id_cita INT,
    IN _descripcion VARCHAR(500),
    IN _tratamiento VARCHAR(500)
)
BEGIN
    INSERT INTO Diagnostico(id_cita,descripcion,tratamiento,activo) 
    VALUES(_id_cita,_descripcion,_tratamiento, 1);
    SET _id_diagnostico = @@last_insert_id;
END$

-- Permite mostrar los diagnosticos en el grid
CREATE PROCEDURE LISTAR_DIAGNOSTICOS(
    IN _id_cita INT
)
BEGIN
    SELECT d.id_diagnostico,d.descripcion, d.tratamiento
    FROM Diagnostico d INNER JOIN CitaMedica c ON d.id_cita = c.id_cita
    WHERE d.activo = 1 AND d.id_cita = _id_cita;
END$

-- Pestaña Receta Medica
-- Inserta la informacion de una receta medica de una fila del dgv a la cita
CREATE PROCEDURE INSERTAR_RECETA_MEDICA(
    OUT _id_receta_medica INT,
    IN _id_cita INT,
    IN _vigencia_inicio DATE,
    IN _vigencia_fin DATE  
)
BEGIN
	INSERT INTO RecetaMedica(id_cita,vigencia_inicio,vigencia_fin,activo) VALUES(_id_cita,_vigencia_inicio,_vigencia_fin,1);
    SET _id_receta_medica = @@last_insert_id;
END$

-- Permite mostrar la receta en el grid
DELIMITER $
CREATE PROCEDURE BUSCAR_RECETA_MEDICA(
    IN _id_cita INT
)
BEGIN
    SELECT r.id_receta_medica,r.vigencia_fin
    FROM RecetaMedica r INNER JOIN CitaMedica c ON r.id_cita = c.id_cita
    WHERE r.id_cita = _id_cita;
END$

-- Necesaria para ingresar las lineas de la receta que contienen la dosis y frecuencia de los medicamentos
CREATE PROCEDURE INSERTAR_LINEA_RECETA(
    OUT _id_linea_receta INT,
    IN _id_receta_medica INT,
    IN _id_medicamento INT,
    IN _dosis VARCHAR(500),
    IN _frecuencia VARCHAR(500)
)
BEGIN
    INSERT INTO LineaReceta(id_receta_medica,id_medicamento,dosis,frecuencia,activo) VALUES(_id_receta_medica,_id_medicamento,_dosis,_frecuencia,1);
    SET _id_receta_medica = @@last_insert_id;
END$

-- Permite mostrar las lineas de la receta en el grid
CREATE PROCEDURE LISTAR_LINEA_RECETA_MEDICA(
    IN _id_receta_medica INT
)
BEGIN
    SELECT lr.id_linea_receta, m.nombre_comercial, lr.dosis, lr.frecuencia
    FROM LineaReceta lr 
    INNER JOIN Medicamento m ON lr.id_medicamento = m.id_medicamento
    WHERE lr.activo = 1 AND lr.id_receta_medica = _id_receta_medica;
END$


-- frmBusquedaMedicamento
-- Permite mostrar en el dgv el medicamento ingresado por su nombre comercial, componente o categoria
DELIMITER $
CREATE PROCEDURE BUSCAR_MEDICAMENTOS(
    IN cadena_busqueda VARCHAR(100)
) 
BEGIN
    SELECT m.id_medicamento, m.nombre_comercial,
        m.descripcion_medicamento,
        m.nombre_laboratorio
    FROM Medicamento m
        INNER JOIN MedicamentoComponente mc ON m.id_medicamento = mc.id_medicamento
        INNER JOIN Componente co ON mc.id_componente = co.id_componente
        INNER JOIN CategoriaComponente cc ON co.id_componente = cc.id_componente
        INNER JOIN Categoria c ON cc.id_categoria = c.id_categoria
    WHERE LOWER(m.nombre_comercial) LIKE CONCAT('%', LOWER(cadena_busqueda), '%')
        OR LOWER(co.nombre_componente) LIKE CONCAT('%', LOWER(cadena_busqueda), '%')
        OR LOWER(c.nombre_categoria) LIKE CONCAT('%', LOWER(cadena_busqueda), '%')
    GROUP BY m.nombre_comercial,
        m.descripcion_medicamento,
        m.nombre_laboratorio
    ORDER BY m.nombre_comercial;
END$

-- Permite mostrar por defecto en el dgv todos los medicamentos al abrir la pantalla
DELIMITER $
CREATE PROCEDURE LISTAR_MEDICAMENTOS_TODOS()
BEGIN
    SELECT m.id_medicamento,m.nombre_comercial,
        m.descripcion_medicamento,
        m.nombre_laboratorio
    FROM Medicamento m
        INNER JOIN MedicamentoComponente mc ON m.id_medicamento = mc.id_medicamento
        INNER JOIN Componente co ON mc.id_componente = co.id_componente
        INNER JOIN CategoriaComponente cc ON co.id_componente = cc.id_componente
        INNER JOIN Categoria c ON cc.id_categoria = c.id_categoria
    GROUP BY m.nombre_comercial;
END$



/*
-- Pruebas de los procedimientos almacenados
CALL LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS(1, -1, '0001-01-01', '0001-01-01');
CALL LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS(1, 1, '2023-06-01', '2023-06-07');
CALL LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS(1, -1, '2023-06-02', '2023-06-07');
CALL BUSCAR_CITA(1);

CALL INSERTAR_DIAGNOSTICO(@mocos, 1, 'Cancer' , 'Quimioterapia');
CALL ELIMINAR_DIAGNOSTICO(@mocos);
CALL LISTAR_DIAGNOSTICOS(1);
SELECT @mocos;

SELECT cm.id_cita, cm.id_paciente, cm.motivo_cita, d.descripcion, d.tratamiento
FROM CitaMedica cm
INNER JOIN Diagnostico d ON d.id_cita = cm.id_cita
WHERE cm.id_cita=1 AND d.activo = 1;



CALL INSERTAR_RECETA_MEDICA(@albina, 1, '2023-06-01', '2023-06-07');
CALL BUSCAR_RECETA_MEDICA(4);
SELECT @albina;


CALL INSERTAR_LINEA_RECETA(@lr, @albina, 1, '1 pastilla', '1 vez al dia');
CALL LISTAR_LINEA_RECETA_MEDICA(@albina);

CALL LISTAR_MEDICAMENTOS_TODOS;

CALL BUSCAR_MEDICAMENTOS('Paracetamol');
CALL BUSCAR_MEDICAMENTOS('Antiinflamatorios');

update CitaMedica 
set activo =0
where id_cita = 4 ;

*/
