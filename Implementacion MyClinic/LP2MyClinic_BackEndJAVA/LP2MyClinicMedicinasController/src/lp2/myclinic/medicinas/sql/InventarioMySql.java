/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package lp2.myclinic.medicinas.sql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.medicinas.dao.InventarioDAO;
import lp2.myclinic.medicinas.model.Componente;
import lp2.myclinic.medicinas.model.Inventario;
import lp2.myclinic.medicinas.model.Medicamento;

/**
 *
 * @author waaal
 */
public class InventarioMySql implements InventarioDAO {

    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Inventario inventario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_INVENTARIO(?,?,?,?,?,?)}");
            cs.registerOutParameter("_id_inventario", java.sql.Types.INTEGER);
            cs.setInt("_id_medicamento", inventario.getMedicamento().getIdMedicamento());
            cs.registerOutParameter("_lote", java.sql.Types.VARCHAR);
            cs.setDate("_fecha_caducidad", new java.sql.Date(inventario.getFechaCaducidad().getTime()));
            cs.setDate("_fecha_ingreso", new java.sql.Date(inventario.getFechaIngreso().getTime()));
            cs.setInt("_cantidad", inventario.getStock());
            cs.executeUpdate();
            inventario.setIdInventario(cs.getInt("_id_inventario"));
            inventario.setCodigoLote(cs.getString("_lote"));
            resultado = inventario.getIdInventario();
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

   public ArrayList<Inventario> listarInventarios() {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_INVENTARIO_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Inventario inventario = new Inventario();
                inventario.setIdInventario(rs.getInt("id_inventario"));
                inventario.setStock(rs.getInt("cantidad"));
                inventario.setCodigoLote(rs.getString("lote"));
                inventario.setFechaCaducidad(rs.getDate("fecha_caducidad"));
                inventario.setFechaIngreso(rs.getDate("fecha_ingreso"));        
                Medicamento medicamento = new Medicamento();
                medicamento.setIdMedicamento(rs.getInt("id_medicamento"));
                medicamento.setNombreComercial(rs.getString("nombre_comercial"));
                medicamento.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                medicamento.setDescripcion(rs.getString("descripcion_medicamento"));
                medicamento.setPrecio(rs.getFloat("precio"));                   
                inventario.setMedicamento(medicamento);
                inventarios.add(inventario);
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
        return inventarios;

    }

    @Override
    public int eliminar(Inventario inventario) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_INVENTARIO(?)}");
            cs.setInt("_id_inventario", inventario.getIdInventario());
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
    public ArrayList<Inventario> listarInventariosMantenimiento() {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_INVENTARIO_MANTENIMIENTO()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Inventario inventario = new Inventario();
                inventario.setIdInventario(rs.getInt("id_inventario"));
                inventario.setStock(rs.getInt("cantidad"));
                inventario.setCodigoLote(rs.getString("lote"));
                inventario.setFechaCaducidad(rs.getDate("fecha_caducidad"));
                inventario.setFechaIngreso(rs.getDate("fecha_ingreso"));
                Medicamento medicamento = new Medicamento();
                medicamento.setIdMedicamento(rs.getInt("id_medicamento"));
                medicamento.setNombreComercial(rs.getString("nombre_comercial"));
                medicamento.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                medicamento.setDescripcion(rs.getString("descripcion_medicamento"));
                medicamento.setPrecio(rs.getFloat("precio"));
                inventario.setMedicamento(medicamento);
                inventarios.add(inventario);
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
        return inventarios;

    }

    @Override
    public ArrayList<Inventario> listar_inventario_x_fechas(Inventario inventarioIngresar) {
        ArrayList<Inventario> inventarios = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_INVENTARIO_X_FECHAS(?,?)}");
            cs.setDate("fechaInicio", new java.sql.Date(inventarioIngresar.getFechaIngreso().getTime()));
            cs.setDate("fechaFin", new java.sql.Date(inventarioIngresar.getFechaCaducidad().getTime()));
            rs = cs.executeQuery();
            while (rs.next()) {
                Inventario inventario = new Inventario();
                inventario.setIdInventario(rs.getInt("id_inventario"));
                inventario.setStock(rs.getInt("cantidad"));
                inventario.setCodigoLote(rs.getString("lote"));
                inventario.setFechaCaducidad(rs.getDate("fecha_caducidad"));
                inventario.setFechaIngreso(rs.getDate("fecha_ingreso"));
                Medicamento medicamento = new Medicamento();
                medicamento.setIdMedicamento(rs.getInt("id_medicamento"));
                medicamento.setNombreComercial(rs.getString("nombre_comercial"));
                medicamento.setNombreLaboratorio(rs.getString("nombre_laboratorio"));
                medicamento.setDescripcion(rs.getString("descripcion_medicamento"));
                medicamento.setPrecio(rs.getFloat("precio"));
                inventario.setMedicamento(medicamento);
                inventarios.add(inventario);
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
        return inventarios;
    }
}
