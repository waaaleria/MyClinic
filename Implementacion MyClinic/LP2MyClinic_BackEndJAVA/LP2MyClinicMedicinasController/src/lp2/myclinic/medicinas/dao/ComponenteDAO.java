package lp2.myclinic.medicinas.dao;

import java.util.ArrayList;
import lp2.myclinic.medicinas.model.Componente;


public interface ComponenteDAO {

    int insertar(Componente componente);

    int modificar(Componente componente);

    int eliminar(int componente);

    ArrayList<Componente> listarComponentes();
}
