/*
    Relacionadas al almacenista
    Ingreso de lotes y notificaciones de vencimiento
    - frmAlmacenistaIngresarLote
    - frmAlmacenistaMantenimientoLote
*/ 

CREATE PROCEDURE IF EXISTS LISTAR_COMPONENTES_TODOS()
BEGIN
SELECT * FROM COMPONENTE;
END;

CREATE PROCEDURE IF EXISTS LISTAR_CATEGORIAS_TODOS()
BEGIN
SELECT * FROM CATEGORIA;
END;



