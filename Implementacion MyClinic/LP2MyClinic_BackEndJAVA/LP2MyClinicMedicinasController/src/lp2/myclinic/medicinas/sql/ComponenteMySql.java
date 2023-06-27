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
import lp2.myclinic.medicinas.dao.ComponenteDAO;
import lp2.myclinic.medicinas.model.Componente;

/**
 *
 * @author waaal
 */
public class ComponenteMySql implements ComponenteDAO {

    private Connection con;
    private PreparedStatement ps;
    private ResultSet rs;
    private CallableStatement cs;

    @Override
    public int insertar(Componente componente) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_COMPONENTE(?,?)}");
            cs.registerOutParameter("_id_componente", java.sql.Types.INTEGER);
            cs.setString("_nombre", componente.getNombreComponente());
            cs.setString("_descripcion", componente.getDescripcion());
            cs.executeUpdate();

            componente.setIdComponente(cs.getInt("_id_componente"));
            resultado = componente.getIdComponente();

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
    public int modificar(Componente componente) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_COMPONENTE(?,?)}");
            cs.setInt("_id_componente", componente.getIdComponente());
            cs.setString("_nombre", componente.getNombreComponente());
            cs.setString("_descripcion", componente.getDescripcion());

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
    public int eliminar(int id_componente) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_COMPONENTE(?)}");
            cs.setInt("_id_componente", id_componente);

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
    public ArrayList<Componente> listarComponentes() {
        ArrayList<Componente> componentes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_COMPONENTE_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Componente componente = new Componente();
                componente.setIdComponente(rs.getInt("id_componente"));
                componente.setNombreComponente(rs.getString("nombre"));
                componente.setDescripcion(rs.getString("descripcion"));

                componentes.add(componente);
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
        return componentes;
    }
}
