package lp2.myclinic.atencionmedica.dao;

import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dto.RecetaMedicaDto;
import lp2.myclinic.atencionmedica.model.RecetaMedica;

public interface RecetaMedicaDAO {

    int insertarRecetaMedica(RecetaMedicaDto recetaMedica); //INSERTAR_RECETA_MEDICA

    RecetaMedica buscarRecetaMedicaPorIdCita(int idCita); //BUSCAR_RECETA_MEDICA
    
    ArrayList<RecetaMedica> listarRecetaMedicaPorCitaDetalle(int idCita); //LISTAR_RECETAS_X_CITA
}
