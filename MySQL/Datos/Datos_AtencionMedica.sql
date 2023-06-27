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