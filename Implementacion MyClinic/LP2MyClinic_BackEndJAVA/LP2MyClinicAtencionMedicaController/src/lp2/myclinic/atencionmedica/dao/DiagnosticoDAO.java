package lp2.myclinic.atencionmedica.dao;

import java.util.ArrayList;
import lp2.myclinic.atencionmedica.model.Diagnostico;

public interface DiagnosticoDAO {
    int asignarDiagnosticosACita(ArrayList<Diagnostico> diagnosticos);  //INSERTAR_DIAGNOSTICO
    int eliminarDiagnostico(int idDiagnostico); //ELIMINAR_DIAGNOSTICO
    ArrayList<Diagnostico> listarDiagnosticosPorCita(int idCita); //LISTAR_DIAGNOSTICOS

}
