package lp2.myclinic.medicinas.dao;

import java.util.ArrayList;
import lp2.myclinic.medicinas.model.Inventario;

public interface InventarioDAO {

    int insertar(Inventario inventario);

    ArrayList<Inventario> listarInventarios();

    ArrayList<Inventario> listarInventariosMantenimiento();

    int eliminar(Inventario inventario);

    ArrayList<Inventario> listar_inventario_x_fechas(Inventario inventario);

}
