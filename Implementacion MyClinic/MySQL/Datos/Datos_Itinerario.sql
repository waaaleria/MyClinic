-- Itinerarios

INSERT INTO DiaSemana (nombre_dia) VALUES
  ('Lunes'),
  ('Martes'),
  ('Miércoles'),
  ('Jueves'),
  ('Viernes'),
  ('Sabado');


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
Para visualizar citas agendadas
SELECT ds.nombre_dia, pa.id_medico, pa.hora_inicio, pa.hora_fin
FROM DiaSemana ds
JOIN ProgramaAtencion pa ON pa.id_dia_semana = ds.id_dia_semana
ORDER BY pa.id_medico;
*/
