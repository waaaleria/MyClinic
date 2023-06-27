/*
    Relacionadas al almacenista
    Ingreso de lotes y notificaciones de vencimiento
    - frmAlmacenistaIngresarLote
    - frmAlmacenistaMantenimientoLote
*/ 

DROP PROCEDURE IF EXISTS ELIMINAR_INVENTARIO;
DROP PROCEDURE IF EXISTS LISTAR_MEDICAMENTOS_TODOS_ALM;
DROP PROCEDURE IF EXISTS LISTAR_INVENTARIO_TODOS;
DROP PROCEDURE IF EXISTS LISTAR_INVENTARIO_X_FECHAS;
DROP PROCEDURE IF EXISTS LISTAR_INVENTARIO_MANTENIMIENTO;
DROP PROCEDURE IF EXISTS INSERTAR_INVENTARIO;
DROP PROCEDURE IF EXISTS INSERTAR_MEDICAMENTO;

DELIMITER $
CREATE PROCEDURE LISTAR_MEDICAMENTOS_TODOS_ALM()
BEGIN
SELECT * FROM Medicamento;
END$



DELIMITER $
CREATE PROCEDURE LISTAR_INVENTARIO_TODOS()
BEGIN
    select * from Inventario i, Medicamento m 
	where i.id_medicamento=m.id_medicamento;
END$

DELIMITER $
CREATE DEFINER=`admin`@`%` PROCEDURE `LISTAR_INVENTARIO_X_FECHAS`(
IN fechaInicio DATE,
IN fechaFin DATE)
BEGIN
SELECT *
FROM Inventario i, Medicamento m
WHERE i.id_medicamento = m.id_medicamento
    AND i.fecha_ingreso BETWEEN fechaInicio AND fechaFin;
END$


DELIMITER $
CREATE PROCEDURE ELIMINAR_INVENTARIO(
  IN _id_inventario INT
)
BEGIN
    DELETE FROM Inventario where id_inventario=_id_inventario;
END$


DELIMITER $
CREATE PROCEDURE INSERTAR_INVENTARIO(
    OUT _id_inventario INT,
    IN _id_medicamento INT,
    OUT _lote VARCHAR(100),
    IN _fecha_caducidad DATE,
    IN _fecha_ingreso DATE,
    IN _cantidad INT
)
BEGIN
    DECLARE last_lote_number INT;
    
    SELECT MAX(RIGHT(lote, 3)) INTO last_lote_number FROM Inventario;
    SET last_lote_number = IFNULL(last_lote_number, 0);
    
    SET _lote = CONCAT('Lote', LPAD(last_lote_number + 1, 3, '0'));
    
    INSERT INTO Inventario(id_medicamento, cantidad, lote, fecha_caducidad, fecha_ingreso)
    VALUES(_id_medicamento, _cantidad, _lote, _fecha_caducidad, _fecha_ingreso);
    
    SET _id_inventario = LAST_INSERT_ID();
END$

DELIMITER $
CREATE PROCEDURE INSERTAR_MEDICAMENTO(
	OUT _id_medicamento INT,
	IN _nombre_comercial VARCHAR(100),
    IN _nombre_laboratorio VARCHAR(100),
    IN _descipcion_medicamento VARCHAR(500),
    IN _precio DECIMAL(10,2)
)
BEGIN
	INSERT INTO Medicamento(nombre_comercial,nombre_laboratorio,descripcion_medicamento,precio) 
    VALUES(_nombre_comercial,_nombre_laboratorio,_descipcion_medicamento,_precio);
    SET _id_medicamento = @@last_insert_id;
   -- INSERT INTO Medicamento(id_empleado,fid_area,cargo,sueldo,activo) VALUES(_id_empleado,_fid_area,_cargo,_sueldo,1);
END$

DELIMITER $
CREATE PROCEDURE LISTAR_INVENTARIO_MANTENIMIENTO()
BEGIN
    DECLARE fecha_limite DATE;
    SET fecha_limite = DATE_ADD(CURDATE(), INTERVAL 2 MONTH);

    SELECT i.*, m.*
    FROM Inventario i
    INNER JOIN Medicamento m ON i.id_medicamento = m.id_medicamento
    WHERE i.fecha_caducidad <= fecha_limite;
END$