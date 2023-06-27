package lp2myclinic.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;

import lp2.myclinic.atencionmedica.dao.CitaMedicaDAO;
import lp2.myclinic.atencionmedica.dao.DiagnosticoDAO;
import lp2.myclinic.atencionmedica.dao.LineaRecetaDAO;
import lp2.myclinic.atencionmedica.dao.RecetaMedicaDAO;
import lp2.myclinic.atencionmedica.dto.CitaMedicaDto;
import lp2.myclinic.atencionmedica.dto.LineaRecetaDto;
import lp2.myclinic.atencionmedica.dto.RecetaMedicaDto;
import lp2.myclinic.atencionmedica.model.CitaMedica;
import lp2.myclinic.atencionmedica.model.Diagnostico;
import lp2.myclinic.atencionmedica.model.LineaReceta;
import lp2.myclinic.atencionmedica.model.RecetaMedica;
import lp2.myclinic.atencionmedica.mysql.CitaMedicaMySql;
import lp2.myclinic.atencionmedica.mysql.DiagnosticoMySql;
import lp2.myclinic.atencionmedica.mysql.LineaRecetaMySql;
import lp2.myclinic.atencionmedica.mysql.RecetaMedicaMySql;

import lp2.myclinic.usuarios.dao.MedicoDAO;
import lp2.myclinic.usuarios.dao.PacienteDAO;
import lp2.myclinic.usuarios.dto.MedicoDTO;
import lp2.myclinic.usuarios.model.Paciente;
import lp2.myclinic.usuarios.mysql.MedicoMySql;
import lp2.myclinic.usuarios.mysql.PacienteMySql;

@WebService(serviceName = "AtencionMedicaWS")
public class AtencionMedicaWS {

    private MedicoDAO daoMedico;
    private PacienteDAO daoPaciente;
    private CitaMedicaDAO daoCitaMedica;
    private DiagnosticoDAO daoDiagnostico;
    private RecetaMedicaDAO daoRecetaMedica;
    private LineaRecetaDAO daoLineaReceta;

    public AtencionMedicaWS() {
        daoMedico = new MedicoMySql();
        daoPaciente = new PacienteMySql();
        daoCitaMedica = new CitaMedicaMySql();
        daoDiagnostico = new DiagnosticoMySql();
        daoRecetaMedica = new RecetaMedicaMySql();
        daoLineaReceta = new LineaRecetaMySql();
    }

    //Para las pantallas de medicos
    //LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS -> Para los filtros
    @WebMethod(operationName = "listarCitasMedicoPorPacienteFechas")
    public ArrayList<CitaMedicaDto> listarCitasMedicoPorPacienteFechas(
            @WebParam(name = "idMed") int idMed,
            @WebParam(name = "idPac") int idPac,
            @WebParam(name = "fechaIni") String fechaIni,
            @WebParam(name = "fechaFin") String fechaFin) {

        ArrayList<CitaMedicaDto> citas = new ArrayList<>();
        try {
            citas = daoCitaMedica.filtrarCitasPorPacienteFecha(idMed, idPac, fechaIni, fechaFin);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return citas;
    }

    //MODIFICAR_CITA -> Cambia el motivo de la cita.
    @WebMethod(operationName = "modificarCita")
    public int modificarCita(@WebParam(name = "citaMedica") CitaMedica citaMedica) {
        int resultado = 0;
        try {
            resultado = daoCitaMedica.modificarCita(citaMedica);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    //
    @WebMethod(operationName = "buscarCita") //BUSCAR_CITA
    public CitaMedica buscarCita(@WebParam(name = "idCita") int idCita) {
        CitaMedica cita = new CitaMedica();
        try {
            cita = daoCitaMedica.buscarCita(idCita);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return cita;
    }

    @WebMethod(operationName = "insertarDiagnostico")//INSERTAR_DIAGNOSTICO
    public int insertarDiagnostico(@WebParam(name = "diagnostico") ArrayList<Diagnostico> diagnosticos) {
        int resultado = 0;
        try {
            resultado = daoDiagnostico.asignarDiagnosticosACita(diagnosticos);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarDiagnosticosPorCita")                     //INSERTAR_DIAGNOSTICO
    public ArrayList<Diagnostico> listarDiagnosticosPorCita(@WebParam(name = "idCita") int idCita) {
        ArrayList<Diagnostico> diagnosticos = new ArrayList<>();
        try {
            diagnosticos = daoDiagnostico.listarDiagnosticosPorCita(idCita);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return diagnosticos;
    }

    @WebMethod(operationName = "insertarRecetaMedica")                          //INSERTAR_RECETA_MEDICA
    public int insertarRecetaMedica(@WebParam(name = "recetaMedica") RecetaMedicaDto recetaMedica) {
        int resultado = 0;
        try {
            resultado = daoRecetaMedica.insertarRecetaMedica(recetaMedica);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarRecetaMedicaPorCita")                     //LISTAR_RECETA_MEDICA_X_CITA
    public RecetaMedica listarRecetaMedicaPorCita(@WebParam(name = "idCita") int idCita) {
        RecetaMedica receta = new RecetaMedica();
        try {
            receta = daoRecetaMedica.buscarRecetaMedicaPorIdCita(idCita);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return receta;
    }

    @WebMethod(operationName = "listarLineaRecetaMedica")                       //LISTAR_LINEA_RECETA
    public ArrayList<LineaRecetaDto> listarLineaRecetaMedica(@WebParam(name = "idRecetaMedica") int idRecetaMedica) {
        ArrayList<LineaRecetaDto> diagnosticos = new ArrayList<>();
        try {
            diagnosticos = daoLineaReceta.listarLineaRecetaMedica(idRecetaMedica);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return diagnosticos;
    }

    //Para las pantallas de paciente
    @WebMethod(operationName = "insertarCitaMedica")
    public int insertarCitaMedica(@WebParam(name = "insertarCitaMedica") int id, int idpac, int idmed, int idpro) {
        int resultado = 0;

        try {
            resultado = daoCitaMedica.reservarCitaMedica(idpac, idmed, idpro);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    //LISTAR_CITA_MEDICA_X_PACIENTE_FECHA
    @WebMethod(operationName = "listarCitasXPaciente")
    public ArrayList<CitaMedica> listarCitasXPaciente(@WebParam(name = "idPac") int idPac) {
        ArrayList<CitaMedica> citas = new ArrayList<>();
        try {
            citas = daoCitaMedica.listarCitasXPaciente(idPac);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return citas;
    }

    @WebMethod(operationName = "listarRecetaxCita")    //LISTAR_RECETAXCITA
    public ArrayList<LineaReceta> listarRecetaxCita(@WebParam(name = "idCita") int idCita) {
        ArrayList<LineaReceta> lineas = new ArrayList<>();
        try {
            lineas = daoLineaReceta.listarRecetaxCita(idCita);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return lineas;
    }
    
    @WebMethod(operationName = "listarRecetaMedicaPorCitaDetalle")//LISTAR_RECETA_MEDICA_X_CITA
    public ArrayList<RecetaMedica> listarRecetaMedicaPorCitaDetalle(@WebParam(name = "idCita") int idCita) {

        ArrayList<RecetaMedica> dtoReceta= new ArrayList<>();
        try {
            dtoReceta = daoRecetaMedica.listarRecetaMedicaPorCitaDetalle(idCita);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return dtoReceta;
    }
    
    @WebMethod(operationName = "listarCitasxPacientexFecha")//LISTAR_CITA_MEDICA_X_PACIENTE_FECHA
    public ArrayList<CitaMedica> listarCitasxPacientexFecha(@WebParam(name = "idPaciente") int idPaciente,
            @WebParam(name = "fechaIni") Date fechaIni,
            @WebParam(name = "fechaFin") Date fechaFin){

        ArrayList<CitaMedica> citas = new ArrayList<>();
        try {
            citas = daoCitaMedica.listarCitasxPacientexFecha(idPaciente,fechaIni,fechaFin);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return citas;
    }
    
    @WebMethod(operationName = "ListarHorarioPacienteFechaIniFinal")//LISTAR_HORARIO_PACIENTE_FECHA_INI_FINAL nuevo DANNY
    public ArrayList<CitaMedica> ListarHorarioPacienteFechaIniFinal(@WebParam(name = "idusuaio") int idUsu,
                                                                    @WebParam(name = "fechaIni") Date fechaIni,
                                                                    @WebParam(name = "fechaFin") Date fechaFin) {
        ArrayList<CitaMedica> citas = new ArrayList<>();
        try {
            citas = daoCitaMedica.ListarHorarioPacienteFechaIniFinal(idUsu,fechaIni,fechaFin);;
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return citas;
    }
    
    @WebMethod(operationName = "eliminarCitaMedica")
    public int eliminarCitaMedica(@WebParam(name = "citaMedica") int idCitaMedica) {
        int resultado = 0;
        try {
            resultado = daoCitaMedica.eliminar(idCitaMedica);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
}
