package lp2.myclinic.atencionmedica.dao;

import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dto.LineaRecetaDto;
import lp2.myclinic.atencionmedica.model.LineaReceta;

public interface LineaRecetaDAO {

    //Para medico
    int insertarLineaRecetaMedica(LineaRecetaDto lineaReceta); //INSERTAR_LINEA_RECETA

    ArrayList<LineaRecetaDto> listarLineaRecetaMedica(int idRecetaMedica); //LISTAR_LINEA_RECETA_MEDICA

    //Para paciente
    ArrayList<LineaReceta> listarRecetaxCita(int id_cita);

}
