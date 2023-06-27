package lp2myclinic.services;

import java.util.ArrayList;
import java.util.Date;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import lp2.myclinic.itinerario.dao.ProgramaAtencionDAO;
import lp2.myclinic.itinerario.model.ProgramaAtencion;
import lp2.myclinic.itinerario.mysql.ProgramaAtencionMySql;

@WebService(serviceName = "ItinerarioWS")
public class ItinerarioWS {

    private ProgramaAtencionDAO daoProgramaAtencion = new ProgramaAtencionMySql();
    
    //Pantalla 
    //LISTAR_HORARIOS_X_FECHA_MEDICO
    @WebMethod(operationName = "listarProgramaXFechaMedico")
    public ArrayList<ProgramaAtencion> listarProgramaXFechaMedico
        (@WebParam(name = "idMedico") int idMedico, @WebParam(name = "fecha") Date fecha) {
        ArrayList<ProgramaAtencion> programas = new ArrayList<>();
        try {
            programas = daoProgramaAtencion.listarPorFechaMedico(idMedico, fecha);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return programas;
    }
        
    @WebMethod(operationName = "insertarListaHorariosPorMedico")
    public int insertarListaHorariosPorMedico(ProgramaAtencion programa){
        int resultado = 0;
        try{
            resultado = daoProgramaAtencion.insertarListaProgramas(programa);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarProgramaXMedico")
    public ArrayList<ProgramaAtencion>listarProgramaXMedico
        (@WebParam(name = "idMedico") int idMedico){
        //        listarProgramaXMedico (int idMedico){        
        ArrayList<ProgramaAtencion> programas = new ArrayList<>();
        try {
            programas = daoProgramaAtencion.listarProgramasMedicos(idMedico);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return programas;
    }
}
