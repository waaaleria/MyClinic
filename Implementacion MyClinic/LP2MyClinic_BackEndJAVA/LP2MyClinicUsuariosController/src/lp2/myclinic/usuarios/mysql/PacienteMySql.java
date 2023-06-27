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
import lp2.myclinic.usuarios.dao.PacienteDAO;
import lp2.myclinic.usuarios.model.Paciente;

public class PacienteMySql implements PacienteDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;

    public ArrayList<Paciente> listarTodas() {
        ArrayList<Paciente> pacientes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PACIENTES_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Paciente pac = new Paciente();
                pac.setIdUsuario(rs.getInt("id_paciente"));
                pac.setDni(rs.getString("dni"));
                pac.setNombre(rs.getString("nombre"));
                pac.setApellido(rs.getString("apellido"));
                pac.setCorreo(rs.getString("correo"));
                pac.setGenero(rs.getString("genero"));
                pac.setTelefono(rs.getString("telefono"));
                pac.setContraseña(rs.getString("contraseña"));
                pac.setPrimeraVisita(rs.getDate("primera_visita"));
                pac.setUltimaVisita(rs.getDate("ultima_visita"));
                pacientes.add(pac);
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
        return pacientes;
    }

    @Override
    public ArrayList<Paciente> listarPacientesPorDniNombre(String dniNombre) {
        ArrayList<Paciente> pacientes = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PACIENTES_X_DNI_NOMBRE(?)}");
            cs.setString("_dni_nombre", dniNombre);
            rs = cs.executeQuery();
            while (rs.next()) {
                Paciente pac = new Paciente();
                pac.setIdPaciente(rs.getInt("id_paciente"));
                //pac.setIdUsuario(rs.getInt("id_usuario"));
                pac.setDni(rs.getString("dni"));
                pac.setNombre(rs.getString("nombre"));
                pac.setApellido(rs.getString("apellido"));
                pacientes.add(pac);
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
        return pacientes;

    }
    @Override
    public int modificarPaciente(String dni, String correoNuevo, String telefonoNuevo, String generonuevo) {
        int resultado = 0;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PERFIL_PACIENTE(?,?,?,?)}");
            cs.setString("_dni", dni);
            cs.setString("_correo", correoNuevo);
            cs.setString("_telefono", telefonoNuevo);
            cs.setString("_genero", generonuevo);
            cs.executeUpdate();
            resultado = 1;
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
}
