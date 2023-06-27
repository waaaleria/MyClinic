INSERT INTO CitaMedica (id_medico, id_paciente, id_programa, motivo_cita) VALUES
  (1, 1, 6,  'Derivacion de traumatologia'),
  (1, 2, 11, 'Dificultad al respirar'),
  (1, 3, 18, 'Control medico'),
  (1, 4, 24, 'Dolor de pecho'),

  (2, 5, 7,  'Dolor de cabeza'),
  (2, 6, 12,  'Dolor de estomago'),
  (2, 7, 19,  'Dolor de garganta'),
  (2, 8, 25,  'Dolor de espalda'),

  (3, 9, 8, 'Dolor de rodilla'),
  (3, 1, 13, 'Dolor de codo'),
  (3, 2, 20, 'Dolor de tobillo'),
  (3, 3, 26, 'Dolor de muñeca'),

  (4, 4, 9, 'Dolor de cadera'),
  (4, 5, 14, 'Dolor de hombro'),
  (4, 6, 21, 'Dolor de cuello'),
  (4, 7, 27, 'Dolor de dedo'),

  (5, 1, 10,  'Dolor de pierna'),
  (5, 2, 15, 'Dolor de brazo'),
  (5, 3, 22,  'Dolor de espalda'),
  (5, 8, 28, 'Dolor de mano'),

  (6, 9, 16,  'Dolor de pie'),
  (6, 3, 17, 'Dolor de cabeza'),
  (6, 4, 23, 'Dolor de estomago'),
  (6, 5, 29,  'Dolor de garganta'),

  (7, 2, 7,  'Dolor de espalda'),
  (7, 1, 8,  'Dolor de rodilla'),
  (7, 7, 9, 'Dolor de codo'),
  
  (8, 8, 11, 'Dolor de tobillo'),
  (8, 6, 12, 'Dolor de muñeca'),
  
  (9, 6, 20,  'Dolor de muñeca'),
  (9, 7, 21,  'Dolor de espalda');

  
INSERT INTO ProgramaAtencion(id_medico, id_dia_semana, hora_inicio, hora_fin, fecha) VALUES
  -- Medicos
  (1, 1, '08:00:00', '09:00:00', '2023-06-01'),
  (1, 1, '09:00:00', '10:00:00', '2023-06-01'),
  (1, 1, '10:00:00', '11:00:00', '2023-06-01'),

  (1, 3, '08:00:00', '09:00:00', '2023-06-01'),
  (1, 3, '09:00:00', '10:00:00', '2023-06-01'),
  (1, 3, '10:00:00', '11:00:00', '2023-06-01'),
  
  (2, 2, '10:00:00', '11:00:00', '2023-06-01'),
  (2, 2, '11:00:00', '12:00:00', '2023-06-01'),
  (2, 2, '12:00:00', '13:00:00', '2023-06-01'),

  (2, 4, '13:00:00', '14:00:00', '2023-06-01'),
  (2, 4, '14:00:00', '15:00:00', '2023-06-01'),
  (2, 4, '15:00:00', '16:00:00', '2023-06-01'),
  
  
  (3, 1, '16:00:00', '17:00:00', '2023-06-01'),
  (3, 1, '17:00:00', '18:00:00', '2023-06-01'),

  (3, 1, '18:00:00', '19:00:00', '2023-06-01'),
  (3, 1, '19:00:00', '20:00:00', '2023-06-01'),
  

  (4, 1, '20:00:00', '21:00:00', '2023-06-01'),
  (4, 1, '21:00:00', '22:00:00', '2023-06-01'),

  (5, 1, '16:00:00', ':00:00', '2023-06-01'),
  (5, 1, '17:00:00', '18:00:00', '2023-06-01'),

  (6, 1, '18:00:00', '19:00:00', '2023-06-01'),
  (6, 1, '19:00:00', '20:00:00', '2023-06-01'),


  -- Medico Paciente
  (7, 2, '10:00:00', '11:00:00', '2023-06-01'),
  (7, 2, '11:00:00', '12:00:00', '2023-06-01'),

  (8, 2, '12:00:00', '13:00:00', '2023-06-01'),
  (8, 2, '13:00:00', '14:00:00', '2023-06-01'),

  (9, 2, '13:00:00', '14:00:00', '2023-06-01'),
  (9, 2, '13:00:00', '14:00:00', '2023-06-01'),

  (9, 2, '13:00:00', '14:00:00', '2023-06-01'),
  (9, 2, '13:00:00', '14:00:00', '2023-06-01');



/*
-- Query que permite ver la informacion de las citas
SELECT
  cm.id_cita AS 'ID Cita',
  CONCAT(u1.nombre, ' ', u1.apellido) AS 'Médico',
  e.nombre_especialidad AS 'Especialidad',
  CONCAT(u2.nombre, ' ', u2.apellido) AS 'Paciente',
  CONCAT(pa.hora_inicio, ' - ', pa.hora_fin) AS 'Horario',
  cm.motivo_cita AS 'Motivo de la Cita',
  CONCAT('Desde ', rm.vigencia_inicio, ' hasta ', rm.vigencia_fin) AS 'Vigencia receta',
  GROUP_CONCAT(CONCAT(m.nombre_comercial, ':', lr.dosis, ' (', lr.frecuencia, ')') SEPARATOR '\n') AS 'Medicamentos',
  d.descripcion AS 'Descripción del Diagnóstico',
  d.tratamiento AS 'Tratamiento'
FROM CitaMedica cm
JOIN Medico m1 ON cm.id_medico = m1.id_medico
JOIN Usuario u1 ON m1.id_usuario = u1.id_usuario
JOIN Paciente p ON cm.id_paciente = p.id_paciente
JOIN Usuario u2 ON p.id_usuario = u2.id_usuario
JOIN RecetaMedica rm ON cm.id_cita = rm.id_cita
JOIN ProgramaAtencion pa ON pa.id_programa = cm.id_programa
JOIN Especialidad e ON e.id_especialidad = m1.id_especialidad
LEFT JOIN LineaReceta lr ON rm.id_receta_medica = lr.id_receta_medica
LEFT JOIN Medicamento m ON lr.id_medicamento = m.id_medicamento
LEFT JOIN Diagnostico d ON cm.id_cita = d.id_cita
GROUP BY cm.id_cita
ORDER BY cm.id_cita;

select * from CitaMedica;

update CitaMedica
set activo=0
where id_cita =4;

*/