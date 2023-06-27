package lp2.myclinic.itinerario.dao;

import java.util.ArrayList;
import java.util.Date;
import lp2.myclinic.itinerario.model.ProgramaAtencion;

public interface ProgramaAtencionDAO {
    public int insertar(ProgramaAtencion programa);
    public int modificar(ProgramaAtencion programa);
    public ArrayList<ProgramaAtencion> listarTodas();
    public ArrayList<ProgramaAtencion> listarPorFechaMedico(int idMedico, Date fechaPrograma);
    public ProgramaAtencion buscarProgramaPorIdCita(int idCita);
    public int eliminar(int idPrograma);
    public int insertarListaProgramas(ProgramaAtencion programa);
    public ArrayList<ProgramaAtencion> listarProgramasMedicos(int idMedico);
}
