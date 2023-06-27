-- Inserts

-- Medicamento
INSERT INTO Medicamento (nombre_comercial, nombre_laboratorio, descripcion_medicamento, precio) VALUES 
    ('Panadol', 'GlaxoSmithKline', 'Antigripal, alivio y manejo del dolor y la fiebre', 4.00),
    ('Tylenol', 'Johnson & Johnson', 'Alivia el dolor y el dolor de cabeza', 5.00),
    ('Paracetamol', 'Generico', 'Calma fiebre y dolor de cabeza', 2.00),
    ('Ibuprofeno', 'Generico', 'Alivia el dolor de cabeza y el dolor de muelas', 3.00),
    ('Dolomax Plus', 'Medifarma', 'Trata el dolor agudo y crónico', 6.00),
    ('Acton', 'Bayer', 'Para tratar enfermedades reumaticas, traumatologias e inflamaciones', 6.00);
    

-- Categoria
INSERT INTO Categoria(nombre_categoria, descripcion_categoria) VALUES
    ('Analgesicos', 'Medicamentos que neutralizan el ácido del estómago'),
    ('Antipireticos', 'Medicamentos que combaten la fiebre'),
    ('Antiinflamatorios', 'Medicamentos que combaten la inflamacion');


-- Componente
INSERT INTO Componente(nombre_componente, id_componente) VALUES 
    ('Paracetamol', 1),
    ('Ibuprofeno', 2);

 
-- CategoriaComponente
INSERT INTO CategoriaComponente(id_categoria, id_componente) VALUES 
    (1, 1),
    (2, 1),
    (1, 2),
    (3, 2);


-- MedicamentoComponente
INSERT INTO MedicamentoComponente(id_medicamento, id_componente) VALUES 
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2),
    (5, 2),
    (6, 2);


-- Para probar las vistas
SELECT m.nombre_comercial, m.descripcion_medicamento, 
	GROUP_CONCAT(DISTINCT c.nombre_categoria SEPARATOR ',') AS categoria, 
    m.precio, m.nombre_laboratorio, 
    GROUP_CONCAT(DISTINCT co.nombre_componente SEPARATOR ', ') AS componentes_principales
FROM Medicamento m
INNER JOIN MedicamentoComponente mc ON m.id_medicamento = mc.id_medicamento
INNER JOIN Componente co ON mc.id_componente = co.id_componente
INNER JOIN CategoriaComponente cc ON co.id_componente = cc.id_componente
INNER JOIN Categoria c ON cc.id_categoria = c.id_categoria
GROUP BY m.id_medicamento;
