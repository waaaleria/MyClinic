/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package lp2.myclinic.usuarios.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.usuarios.dao.AdministradorDAO;
import lp2.myclinic.usuarios.model.Administrador;

/**
 *
 * @author waaal
 */
public class AdministradorMySql implements AdministradorDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;

    public ArrayList<Administrador> listarAdministradores() {
        ArrayList<Administrador> administradores = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ADMINISTRADOR_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {

                Administrador admin = new Administrador();

                admin.setIdUsuario(rs.getInt("id_usuario"));
                admin.setIdAdministrador(rs.getInt("id_administrador"));
                admin.setDni(rs.getString("dni"));
                admin.setNombre(rs.getString("nombre"));
                admin.setApellido(rs.getString("apellido"));
                admin.setCorreo(rs.getString("correo"));
                admin.setGenero(rs.getString("genero"));
                admin.setTelefono(rs.getString("telefono"));
                admin.setContraseña(rs.getString("contraseña"));
                admin.setCodigoTrabajo(rs.getString("codigo_trabajo"));
                admin.setExperiencia(rs.getInt("experiencia"));
                admin.setTipo(rs.getString("tipo"));
                administradores.add(admin);
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
        return administradores;
    }
}
