package lp2.myclinic.main;

import lp2.myclinic.atencionmedica.mysql.RecetaMedicaMySql;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dao.CitaMedicaDAO;
import lp2.myclinic.atencionmedica.dao.DiagnosticoDAO;
import lp2.myclinic.atencionmedica.dao.LineaRecetaDAO;
import lp2.myclinic.atencionmedica.dao.RecetaMedicaDAO;
import lp2.myclinic.atencionmedica.dto.CitaMedicaDto;
import lp2.myclinic.atencionmedica.model.CitaMedica;
import lp2.myclinic.atencionmedica.model.Diagnostico;
import lp2.myclinic.atencionmedica.model.LineaReceta;
import lp2.myclinic.atencionmedica.model.RecetaMedica;
import lp2.myclinic.atencionmedica.mysql.CitaMedicaMySql;
import lp2.myclinic.atencionmedica.mysql.DiagnosticoMySql;
import lp2.myclinic.atencionmedica.mysql.LineaRecetaMySql;
import lp2.myclinic.itinerario.dao.ProgramaAtencionDAO;
import lp2.myclinic.itinerario.mysql.ProgramaAtencionMySql;
import lp2.myclinic.itinerario.model.ProgramaAtencion;
import lp2.myclinic.medicinas.dao.ComponenteDAO;
import lp2.myclinic.medicinas.dao.InventarioDAO;
import lp2.myclinic.medicinas.dao.MedicamentoDAO;
import lp2.myclinic.medicinas.model.Componente;
import lp2.myclinic.medicinas.model.Inventario;
import lp2.myclinic.medicinas.model.Medicamento;
import lp2.myclinic.medicinas.sql.ComponenteMySql;
import lp2.myclinic.medicinas.sql.InventarioMySql;
import lp2.myclinic.medicinas.sql.MedicamentoMySql;
import lp2.myclinic.usuarios.dao.AdministradorDAO;
import lp2.myclinic.usuarios.dao.MedicoDAO;
import lp2.myclinic.usuarios.dao.PacienteDAO;
import lp2.myclinic.usuarios.dao.UsuarioDAO;
import lp2.myclinic.usuarios.dto.MedicoDTO;
import lp2.myclinic.usuarios.model.Administrador;
import lp2.myclinic.usuarios.model.Medico;
import lp2.myclinic.usuarios.model.Paciente;
import lp2.myclinic.usuarios.model.Rol;
import lp2.myclinic.usuarios.model.Usuario;
import lp2.myclinic.usuarios.mysql.AdministradorMySql;
import lp2.myclinic.usuarios.mysql.MedicoMySql;
import lp2.myclinic.usuarios.mysql.PacienteMySql;
import lp2.myclinic.usuarios.mysql.UsuarioMySQL;

/**
 *
 * @author waaal
 */
public class Principal {

    public static void main(String[] args) throws Exception {
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        int resultado = 0;
        CitaMedicaDAO daoCitaMedica = new CitaMedicaMySql();
        ArrayList<CitaMedica> citas = daoCitaMedica.listarCitasxPacientexFecha('1',"2023-06-23","2025-09-23");
//
//        MedicamentoDAO daoreceta = new MedicamentoMySql();
//        ArrayList<Medicamento> receta = daoreceta.listarMedicamentos();
//                  for (Medicamento rec : receta) {
//            System.out.println("Dia: " + rec.getIdMedicamento());
//
//        }  
        
//        //Modulo Itinerario
//        HorarioDAO daoHorario = new HorarioMySql();
//        ArrayList<Horario> horarios = daoHorario.listarTodas();
//
//        System.out.println("\n" + "Listando los horarios de la BD");
//        for (Horario horario : horarios) {
//            System.out.println("Dia: " + horario.getDiaSemana() + " "
//                    + "Hora inicio: " + horario.getHoraInicio() + " "
//                    + "Hora fin: " + horario.getHoraFin());
//
//        }
//
//        ProgramaAtencionDAO daoProgramaAtencion = new ProgramaAtencionMySql();
//        ArrayList<ProgramaAtencion> programas = daoProgramaAtencion.listarTodas();
//        System.out.println("\n" + "Listando los programas de atencion de la BD");
//        for (ProgramaAtencion programa : programas) {
//            System.out.println("Fecha de inicio: " + programa.getFechaInicio() + " "
//                    + "Fecha de fin: " + programa.getFechaFin());
//        }
//
        //Modulo medicinas
//        MedicamentoDAO daoMedicamento = new MedicamentoMySql();
//        ArrayList<Medicamento> medicamentos = daoMedicamento.listarMedicamentos();
//        System.out.println("\n" + "Listando los medicamentos de la BD");
//        for (Medicamento medicamento : medicamentos) {
//            System.out.println("Nombre comercial: " + medicamento.getNombreComercial() + " "
//                    + "Nombre del laboratorio: " + medicamento.getNombreLaboratorio() + " "
//                    + "Descripcion: " + medicamento.getDescripcionMedicamento());
//        }
//
//        ComponenteDAO daoComponente = new ComponenteMySql();
//        ArrayList<Componente> componentes = daoComponente.listarComponentes();
//        System.out.println("\n" + "Listando los componentes de la BD");
//        for (Componente componente : componentes) {
//            System.out.println("Nombre : " + componente.getNombreComponente() + " " + "Descripcion: " + componente.getDescripcion());
//        }
//
//        InventarioDAO daoInventario = new InventarioMySql();
//        ArrayList<Inventario> inventario = daoInventario.listarInventarios();
//        System.out.println("\n" + "Listando los inventarios de medicinas de la BD");
//        for (Inventario item : inventario) {
//            System.out.println("Codigo del lote : " + item.getCodigoLote() + " "
//                    + "Nombre del componente: " + item.getMedicamento().getComponente().getNombreComponente() + " "
//                    + "Fecha de ingreso: " + item.getFechaIngreso() + " "
//                    + "Fecha de caducidad: " + item.getFechaCaducidad() + " "
//                    + "Stock: " + item.getStock());
//        }
//        // Modulo Usuarios
//        AdministradorDAO daoAdministrador = new AdministradorMySql();
//        ArrayList<Administrador> administradores = daoAdministrador.listarAdministradores();
//        System.out.println("\n" + "Listando los administradores de la BD");
//        for (Administrador admin : administradores) {
//            System.out.println("Datos Usuario: \n"
//                    + "Nombre completo : " + admin.getNombre() + " " + admin.getApellido() + " "
//                    + "DNI: " + admin.getDni() + " " + "Edad: " + admin.getEdad() + " "
//                    + "Correo: " + admin.getCorreo() + " " + "Contraseña: " + admin.getContraseña() + " "
//                    + "Genero: " + admin.getGenero() + " " + "Telefono: " + admin.getTelefono() + " "
//                    + "\nDatos Administrador:\n"
//                    + "Tipo: " + admin.getTipo() + " " + "Codigo trabajo: " + admin.getCodigoTrabajo() + " "
//                    + "Experiencia: " + admin.getExperiencia() + "\n\n ");
//        }
//
//        MedicoDAO daoMedico = new MedicoMySql();
//        ArrayList<Medico> medicos = daoMedico.listarTodas();
//        System.out.println("\n" + "Listando los medicos de la BD");
//        for (Medico medico : medicos) {
//            System.out.println("Datos Usuario: \n"
//                    + "Nombre completo : " + medico.getNombre() + " " + medico.getApellido() + " "
//                    + "DNI: " + medico.getDni() + " "
//                    + "Edad: " + medico.getEdad() + " "
//                    + "Correo: " + medico.getCorreo() + " "
//                    + "Contraseña: " + medico.getContraseña() + " "
//                    + "Genero: " + medico.getGenero() + " "
//                    + "Telefono: " + medico.getTelefono() + " "
//                    + "\nDatos medico:\n"
//                    + "Estudios: " + medico.getEstudios() + " " + "CMP: " + medico.getCmp() + " "
//                    + "Especialidad: " + medico.getEspecialidad() + " " + "Experiencia: " + medico.getExperiencia() + "\n");
//        }
//        
//        MedicoDTO dtoMed = daoMedico.buscarMedico(2);
//        System.out.println("\n" + "Medico encontrado: " + dtoMed.getNombreCompleto() + " " + dtoMed.getNombreEspecialidad());
       
//
//        PacienteDAO daoPaciente = new PacienteMySql();
//        ArrayList<Paciente> pacientes = daoPaciente.listarPacientesPorDniNombre("");
//        System.out.println("\n" + "Listando los pacientes de la BD");
//        for (Paciente paciente : pacientes) {
//            System.out.println("Datos Usuario: \n"
//                    + "Nombre completo : " + paciente.getNombre() + " " + paciente.getApellido() + " "
//                    + "DNI: " + paciente.getDni() + " "
//                    + "Edad: " + paciente.getEdad() + " "
//                    + "Correo: " + paciente.getCorreo() + " "
//                    + "Contraseña: " + paciente.getContraseña() + " "
//                    + "Genero: " + paciente.getGenero() + " "
//                    + "Telefono: " + paciente.getTelefono() + " "
//                    + "\nDatos paciente:\n"
//                    + "Primera atencion: " + paciente.getPrimeraVisita() + " " + "Ultima atencion: " + paciente.getUltimaVisita() + " ");
        }
//
//        ArrayList<Paciente> pacientesDNI = daoPaciente.listarPacientesPorDniNombre("20056789");
//        System.out.println("\n" + "Listando los pacientes que correspondan al dni 2005 de la BD");
//        for (Paciente paciente : pacientesDNI) {
//            System.out.println("Nombre completo : " + paciente.getNombre() + " " + paciente.getApellido() + " "
//                    + "DNI: " + paciente.getDni());
//
//        }
//
//        //Modulo Atencion Medica 
//        //Citas
//
//        System.out.println("\n" + "Listando los citas del paciente buscado en la BD");
//        for (CitaMedicaDTO dtoCita : citas) {
//            System.out.println("Nombre completo : " + dtoCita.getNombreCompleto() + " "
//                    + "Especialidad: " + dtoCita.getNombreEspecialidad() + " "
//                    + "Fecha: " + dtoCita.getFecha() + " "
//                    + "Horario: " + dtoCita.getHoraInicio() + " - " + dtoCita.getHoraFin());
//
//        }
//        //Diagnostico
//        DiagnosticoDAO daoDiagnostico = new DiagnosticoMySql();
//        ArrayList<Diagnostico> diagnosticos = daoDiagnostico.listarDiagnosticosPorCita(1);
//        System.out.println("\n" + "Listando los diagnosticos para el idCita= 1 de la BD");
//        for (Diagnostico diagnostico : diagnosticos) {
//            System.out.println("Descripcion: " + diagnostico.getDescripcion() + " "
//                    + "Recomendaciones: " + diagnostico.getRecomendaciones());
//
//        }
//
//          resultado=0;
//        Diagnostico diagnostico = new Diagnostico(1, "Cancer", "Rezar mucho");
//        resultado = daoDiagnostico.insertar(diagnostico);
//
//        if (resultado == 1) {
//            System.out.println("Se registro el diagnostico correctamente");
//        } else {
//            System.out.println("Ocurrio un error al registrar al diagnostico");
//        }
//        //RecetaMedica
//        RecetaMedicaDAO daoRecetaMedica = new RecetaMedicaMySql();
//        ArrayList<RecetaMedica> recetas = daoRecetaMedica.listarRecetaMedicaPorCita(1);
//        System.out.println("\n" + "Listando la receta de la idCita = 1 de la BD");
//        for (RecetaMedica receta : recetas) {
//            System.out.println("Vigencia receta: " + receta.getVigenciaFinal());
//
//        }
//
//        resultado = 0;
//        RecetaMedica receta
//                = new RecetaMedica(1,
//                        sdf.parse("2023-05-12"),
//                        sdf.parse("2023-06-12"));
//        
//        resultado = daoRecetaMedica.insertar(receta);
//        if (resultado == 1) {
//            System.out.println("Se registro la receta correctamente");
//        } else {
//            System.out.println("Ocurrio un error al registrar la receta");
//        }
//        
//        resultado = 0;
//        LineaRecetaDAO daoLineaReceta = new LineaRecetaMySql();
//        LineaReceta lr = new LineaReceta(1, 2, "20gr", "Todos los dias despues de desayunar");
//        resultado = daoLineaReceta.insertar(lr);
//        if (resultado == 1) {
//            System.out.println("Se registro la linea_receta correctamente");
//        } else {
//            System.out.println("Ocurrio un error al registrar la linea_receta");
//        }
        //LineaRecetaDAO daoLineaReceta = new LineaRecetaMySql();
//        ArrayList<LineaRecetaDTO> dtolineas = daoLineaReceta.listarLineaRecetaMedica(1);
//        System.out.println("\n" + "Listando las lr de una receta en la BD");
//        for (LineaRecetaDTO dtolinea : dtolineas) {
//            System.out.println("Nombre componente: " + dtolinea.getNombreComponente() + " "
//                    + "Dosis : " + dtolinea.getDosis() + " "
//                    + "Frecuencia: " + dtolinea.getFrecuencia());

        //}
        
        
        
//        UsuarioDAO daoUsuario = new UsuarioMySQL();
//        
//        ArrayList<Rol> roles = daoUsuario.VerificarUsuario2("888888888", "contrasena");
//        //ArrayList<Usuario> usuarios = daoUsuario.VerificarUsuario2("777777777", "contraseña");
//        System.out.println("\n" + "Listando los usuario de la BD");
//        for (Rol rol : roles) {
//            System.out.println("Id : " + rol.getIdUsuario());
//        }
//        
//        resultado = 0;
//        resultado = daoUsuario.VerificarUsuario("888888888", "contrasena");
//        if (resultado != 0) {
//            System.out.println("correcto");
//        } else {
//            System.out.println("naranjas");
//        }
 //   }

}
