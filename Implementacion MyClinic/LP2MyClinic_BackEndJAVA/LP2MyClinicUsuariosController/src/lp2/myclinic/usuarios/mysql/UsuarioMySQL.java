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
import lp2.myclinic.usuarios.dao.UsuarioDAO;
import lp2.myclinic.usuarios.mysql.UsuarioMySQL;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.usuarios.model.Especialidad;
import lp2.myclinic.usuarios.model.Medico;
import lp2.myclinic.usuarios.model.Rol;
import lp2.myclinic.usuarios.model.Usuario;

/**
 *
 * @author mezav
 */
public class UsuarioMySQL implements UsuarioDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;

    @Override
    public int VerificarUsuario(String username, String password) {

        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_USUARIO(?,?)}");
            cs.setString("_dni", username);
            cs.setString("_contraseña", password);
            rs = cs.executeQuery();
            if (rs.next()) {
                resultado = rs.getInt("id_usuario");
            }
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
    public ArrayList<Rol> VerificarRolesUsuario(String username, String password) {

        ArrayList<Rol> roles = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call VERIFICAR_ROLES_X_USUARIO(?,?)}");
            cs.setString("_username", username);
            cs.setString("_password", password);
            rs = cs.executeQuery();
            while (rs.next()) {
                Rol rol = new Rol();
                rol.setIdRol(rs.getInt("id_rol"));
                rol.setCargo(rs.getString("cargo"));

                roles.add(rol);
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
        return roles;
    }

    @Override
    public Usuario obtenerPorId(int idUsuario) {
        Usuario usuario = new Usuario();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_USUARIO_X_ID(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            if (rs.next()) {
                usuario.setIdUsuario(rs.getInt("id_usuario"));
                usuario.setDni(rs.getString("DNI"));
                usuario.setNombre(rs.getString("nombre_usuario"));
                usuario.setApellido(rs.getString("apellido"));
                usuario.setCorreo(rs.getString("correo"));
                usuario.setGenero(rs.getString("genero"));
                usuario.setTelefono(rs.getString("telefono"));
                usuario.setContraseña(rs.getString("contraseña"));

                //usuario.setActivo(true);
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
        return usuario;
    }

    @Override
    public ArrayList<Especialidad> listarEspecialidadesTodas() {
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_ESPECIALIDAD_TODAS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Especialidad especialidad = new Especialidad();
                especialidad.setIdEspecialidad(rs.getInt("id_especialidad"));
                especialidad.setNombre(rs.getString("nombre_especialidad"));
                //especialidad.setActivo(true);
                especialidades.add(especialidad);
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
        return especialidades;
    }

    @Override
    public ArrayList<Medico> listarMedicoxIDEspecialidad(int idespecialidad) {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_MEDICO_x_ID_ESPECIALIDAD(?)}");
            cs.setInt("_id_especialidad", idespecialidad);
            rs = cs.executeQuery();
            while (rs.next()) {
                Medico med = new Medico();
                med.setIdMedico(rs.getInt("id_medico"));
                med.setNombre(rs.getString("nombre"));
                med.setApellido(rs.getString("apellido"));
                medicos.add(med);
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
        return medicos;
    }

    @Override
    public int modificarUsuario(int idUsuario, String correoNuevo, String telefonoNuevo, String contraseñaNueva) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_USUARIO(?,?,?,?)}");
            cs.setInt("_id_usuario", idUsuario);
            cs.setString("_correo", correoNuevo);
            cs.setString("_telefono", telefonoNuevo);
            cs.setString("_contraseña", contraseñaNueva);
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

    @Override
    public int obtenerIdPaciente(int idUsuario) {
        int id_Paciente = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_PACIENTE(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            rs.next();
            id_Paciente = rs.getInt("id_paciente");
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {
                con.close();
            } catch (Exception ex) {
                System.out.println(ex.getMessage());
            }
        }
        return id_Paciente;
    }
    
    @Override
    public int HALLAR_ID_USUARIO(String _dni) {
        int id_Usuario = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call HALLAR_ID_USUARIO(?)}");
            cs.setString("_dni", _dni);
            rs = cs.executeQuery();
            rs.next() ;
            id_Usuario=rs.getInt("id_usuario");    
            
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
        return id_Usuario;
    }
    
    public Medico obtener_datos_medico(int id_medico){
        Medico medico = new Medico();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_DATOS_MEDICO_INDIVIDUAL(?)}");
            cs.setInt("_idmedico", id_medico);
            rs = cs.executeQuery();
            if (rs.next()) {
                medico.setEstudios(rs.getString("estudios"));
                medico.setCmp(rs.getString("cmp"));
                medico.setNombre(rs.getString("nombre"));
                medico.setApellido(rs.getString("apellido"));
                medico.setExperiencia(rs.getInt("experiencia"));
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
        return medico;
    }
}
