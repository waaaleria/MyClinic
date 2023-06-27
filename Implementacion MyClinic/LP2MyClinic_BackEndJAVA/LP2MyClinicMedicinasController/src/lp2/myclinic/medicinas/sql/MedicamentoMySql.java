package lp2.myclinic.medicinas.sql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.medicinas.dao.MedicamentoDAO;
import lp2.myclinic.medicinas.model.Medicamento;

public class MedicamentoMySql implements MedicamentoDAO {

    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;

    //Para el almacenistas
    @Override
    public int insertar(Medicamento medicamento) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_MEDICAMENTO(?,?,?,?,?)}");
            cs.registerOutParameter("_id_medicamento", java.sql.Types.INTEGER);
            cs.setString("_nombre_comercial", medicamento.getNombreComercial());
            cs.setString("_nombre_laboratorio", medicamento.getNombreLaboratorio());
            cs.setString("_descipcion_medicamento",medicamento.getDescripcion());
            cs.setFloat("_precio", medicamento.getPrecio());
            cs.executeUpdate();
            medicamento.setIdMedicamento(cs.getInt("_id_medicamento"));
            resultado = medicamento.getIdMedicamento();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int modificar(Medicamento medicamento) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MEDICAMENTO(?,?,?,?)}");
            cs.setInt("_id_medicamento", medicamento.getIdMedicamento());
            cs.setString("_nombre_comercial", medicamento.getNombreComercial());
            cs.setString("_nombre_laboratorio", medicamento.getNombreLaboratorio());
            cs.setFloat("_precio", medicamento.getPrecio());
            resultado = cs.executeUpdate();

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public int eliminar(int idmedicamento) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_MEDICAMENTO(?)}");
            cs.setInt("_id_medicamento", idmedicamento);
            resultado = cs.executeUpdate();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return resultado;
    }

    @Override
    public ArrayList<Medicamento> listarMedicamentosAlmacenista() {
        ArrayList<Medicamento> laboratorios = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MEDICAMENTOS_TODOS_ALM()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Medicamento laboratorio = new Medicamento();
                laboratorio.setIdMedicamento(rs.getInt("id_medicamento"));
                laboratorio.setNombreComercial(rs.getString("nombre_comercial"));
                laboratorio.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                laboratorio.setPrecio(rs.getFloat("precio"));
                laboratorios.add(laboratorio);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return laboratorios;
    }

    @Override
    public String obtenerMedicamento(int idMedicamento) {
        String nombreMedicmaento = null;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_NOMBRE_MEDICAMENTO(?)}");
            cs.setInt("_id_medicamento", idMedicamento);
            rs = cs.executeQuery();
            rs.next();
            nombreMedicmaento = rs.getString("nombre_comercial");
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return nombreMedicmaento;
    }

    @Override
    public ArrayList<Medicamento> buscarMedicamentosXCategoria(String categoria) {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BuscarMedicamentosPorCategoria(?)}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Medicamento medicamento = new Medicamento();
                //medicamento.setNombreComercial(rs.getInt("nombre_comercial"));
                //medicamento.set(rs.getString("descripcion_medicamento"));
                //medicamento.getComponente().setNombreComponente(rs.getString("categoria"));
                //medicamento.setNombreLaboratorio(rs.getString("nombre_laboratorio"));

                medicamentos.add(medicamento);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return medicamentos;
    }

    // Para los recetas medicas
    @Override
    public ArrayList<Medicamento> listarMedicamentos() {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MEDICAMENTOS_TODOS()}");
            rs = cs.executeQuery();

            while (rs.next()) {
                Medicamento med = new Medicamento();
                med.setIdMedicamento(rs.getInt("id_medicamento"));
                med.setNombreComercial(rs.getString("nombre_comercial"));
                med.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                med.setDescripcion(rs.getString("descripcion_medicamento"));
                medicamentos.add(med);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return medicamentos;
    }

    @Override
    public ArrayList<Medicamento> buscarMedicamentos(String cadenaBusqueda) {
        ArrayList<Medicamento> medicamentos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_MEDICAMENTOS(?)}");
            cs.setString("cadena_busqueda", cadenaBusqueda);
            rs = cs.executeQuery();

            while (rs.next()) {
                Medicamento medicamento = new Medicamento();
                medicamento.setIdMedicamento(rs.getInt("id_medicamento"));
                medicamento.setNombreComercial(rs.getString("nombre_comercial"));
                medicamento.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                medicamento.setDescripcion(rs.getString("descripcion_medicamento"));

                medicamentos.add(medicamento);
            }
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                rs.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return medicamentos;

    }

}
