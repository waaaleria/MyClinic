package lp2myclinic.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import lp2.myclinic.medicinas.dao.InventarioDAO;
import lp2.myclinic.medicinas.dao.MedicamentoDAO;
import lp2.myclinic.medicinas.model.Inventario;
import lp2.myclinic.medicinas.model.Medicamento;
import lp2.myclinic.medicinas.sql.InventarioMySql;
import lp2.myclinic.medicinas.sql.MedicamentoMySql;

@WebService(serviceName = "MedicinaWS")
public class MedicinaWS {

    private MedicamentoDAO daoMedicamento = new MedicamentoMySql();
    private InventarioDAO daoInventario = new InventarioMySql();
    
    //Para recetas medicas
    //Barra de busqueda de frmBusquedaMedicamento
    @WebMethod(operationName = "buscarMedicamentos")
    public ArrayList<Medicamento> buscarMedicamentos(@WebParam(name = "cadenaBusqueda") String cadenaBusqueda) {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            medicamentos = daoMedicamento.buscarMedicamentos(cadenaBusqueda);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicamentos;
    }
    //Vista por defecto de frmBusquedaMedicamento
    @WebMethod(operationName = "listarMedicamentosTodos")
    public ArrayList<Medicamento> listarMedicamentosTodos() {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            medicamentos = daoMedicamento.listarMedicamentos();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicamentos;
    }

    //Almacenista
    @WebMethod(operationName = "listarMedicinasTodasParaAlmacenista")//LISTAR_MEDICOS_TODOS
    public ArrayList<Medicamento> listarMedicinasTodasParaAlmacenista() {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            medicamentos = daoMedicamento.listarMedicamentosAlmacenista();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicamentos;
    }

    @WebMethod(operationName = "insertarMedicamento")
    public int insertarMedicamento(@WebParam(name = "medicamento") Medicamento medicamento) {
        int resultado = 0;

        try {
            resultado = daoMedicamento.insertar(medicamento);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarInventario")//LISTAR_INVENTARIO
    public ArrayList<Inventario> listarInventarios() {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            inventarios = daoInventario.listarInventarios();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return inventarios;
    }

    @WebMethod(operationName = "insertarInventario")
    public int insertarInventario(@WebParam(name = "inventario") Inventario inventario) {
        int resultado = 0;
        try {
            resultado = daoInventario.insertar(inventario);

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "eliminarInventario")
    public int eliminarInventario(@WebParam(name = "inventario") Inventario inventario) {
        int resultado = 0;
        try {
            resultado = daoInventario.eliminar(inventario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarInventarioMantenimiento")//LISTAR_INVENTARIO
    public ArrayList<Inventario> listarInventarioMantenimiento() {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            inventarios = daoInventario.listarInventariosMantenimiento();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return inventarios;
    }

    @WebMethod(operationName = "obtenerMedicamento") //BUSCAR_MEDICO
    public String obtenerMedicamento(@WebParam(name = "idMedicamento") int idMedicamento) {
        String nombre = new String();
        try {
            nombre = daoMedicamento.obtenerMedicamento(idMedicamento);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return nombre;
    }

    @WebMethod(operationName = "listar_inventario_x_fechas")//LISTAR_INVENTARIO
    public ArrayList<Inventario> listar_inventario_x_fechas(@WebParam(name = "inventario") Inventario inventario) {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            inventarios = daoInventario.listar_inventario_x_fechas(inventario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return inventarios;
    }

}
