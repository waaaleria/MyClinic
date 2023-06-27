package lp2.myclinic.atencionmedica.dao;

import java.util.ArrayList;
import java.util.Date;
import lp2.myclinic.atencionmedica.dto.CitaMedicaDto;
import lp2.myclinic.atencionmedica.model.CitaMedica;

public interface CitaMedicaDAO {

    //Para el medico
    //Filtros de busqueda
    public ArrayList<CitaMedicaDto> filtrarCitasPorPacienteFecha(int idMed, int idPac, String fechaIni, String fechaFin);

    //Buscar y modificar cita
    public int modificarCita(CitaMedica citaMedica);

    public CitaMedica buscarCita(int idCita);

    //Para el paciente  
    public ArrayList<CitaMedica> listarCitasXPaciente(int idPac);

    public int reservarCitaMedica(int idPaciente, int idMedico, int idProducto);
    
    public ArrayList<CitaMedica> listarCitasxPacientexFecha(int idPac, Date fechaIni, Date fechaFin);
    //Para los reportes
    /*
       public String obtenerReporteCitas(int idMedico);
     */
    public ArrayList<CitaMedica> ListarHorarioPacienteFechaIniFinal(int idUsu, Date fechaIni, Date fechaFin);
    
    int eliminar(int idcitaMedica);
}
