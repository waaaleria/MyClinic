package lp2.myclinic.medicinas.dao;

import java.util.ArrayList;
import lp2.myclinic.medicinas.model.Medicamento;

public interface MedicamentoDAO {
    
    //Para el almacenista

    int insertar(Medicamento laboratorio);

    int modificar(Medicamento laboratorio);

    int eliminar(int idmedicina);

    ArrayList<Medicamento> listarMedicamentosAlmacenista();

    public ArrayList<Medicamento> buscarMedicamentosXCategoria(String categoria);

    public String obtenerMedicamento(int id_medicamento);
    
    //Para las recetas medicas

    ArrayList<Medicamento> listarMedicamentos(); //LISTAR_MEDICAMENTOS_TODOS

    ArrayList<Medicamento> buscarMedicamentos(String cadenaBusqueda); //BUSCAR_MEDICAMENTOS

}
