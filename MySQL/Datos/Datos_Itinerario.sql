-- Itinerarios

INSERT INTO DiaSemana (nombre_dia) VALUES
  ('Lunes'),
  ('Martes'),
  ('Miércoles'),
  ('Jueves'),
  ('Viernes'),
  ('Sabado');

/*
Para visualizar citas agendadas
SELECT ds.nombre_dia, pa.id_medico, pa.hora_inicio, pa.hora_fin
FROM DiaSemana ds
JOIN ProgramaAtencion pa ON pa.id_dia_semana = ds.id_dia_semana
ORDER BY pa.id_medico;
*/

