package lp2.myclinic.usuarios.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.usuarios.dao.MedicoDAO;
import lp2.myclinic.usuarios.dto.MedicoDTO;
import lp2.myclinic.usuarios.model.Especialidad;
import lp2.myclinic.usuarios.model.Medico;

public class MedicoMySql implements MedicoDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;

    //Para las pantallas de pacientes
    public ArrayList<Medico> listarTodas() {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MEDICOS_TODOS()}");
            rs = cs.executeQuery();
            while (rs.next()) {
                Medico med = new Medico();
                med.setIdUsuario(rs.getInt("id_medico"));
                med.setDni(rs.getString("dni"));
                med.setNombre(rs.getString("nombre"));
                med.setApellido(rs.getString("apellido"));
                med.setCorreo(rs.getString("correo"));
                med.setGenero(rs.getString("genero"));
                med.setTelefono(rs.getString("telefono"));
                med.setContraseña(rs.getString("contraseña"));
                med.setEstudios(rs.getString("estudios"));
                med.setExperiencia(rs.getInt("experiencia"));
                med.setCmp(rs.getString("cmp"));
                med.getEspecialidad().setNombre(rs.getString("nombre_especialidad"));
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

    public ArrayList<Medico> listarPorNombreEspecialidad(String nombreEspecialidad) {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_MEDICO_NOMBRE_X_ESPECIALIDAD(?)}");
            cs.setString("_NOMBRE_ESPECIALIDAD", nombreEspecialidad);
            rs = cs.executeQuery();
            while (rs.next()) {
                Medico med = new Medico();
                Especialidad esp = new Especialidad();
                med.setIdMedico(rs.getInt("id_medico"));
                med.setNombre(rs.getString("nombre"));
                med.setApellido(rs.getString("apellido"));
                
                esp.setNombre(rs.getString("nombre_especialidad"));
                med.setEspecialidad(esp);
                med.setExperiencia(rs.getInt("experiencia"));
                med.setEstudios(rs.getString("estudios"));
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

    // Para la pantalla de modificar perfil
    @Override
    public MedicoDTO buscarMedico(int idUsuario) {
        MedicoDTO med = new MedicoDTO();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_MEDICO(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            rs.next();
            med.setIdMedico(rs.getInt("id_medico"));
            med.setDni(rs.getString("dni"));
            med.setNombreCompleto(rs.getString("nombre_completo"));
            med.setCmp(rs.getInt("cmp"));
            med.setCorreo(rs.getString("correo"));
            med.setTelefono(rs.getString("telefono"));

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
        return med;
    }

    @Override
    public int modificarMedico(int idUsuario, String correoNuevo, String telefonoNuevo) {
        int resultado = 0;

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_MEDICO(?,?,?)}");
            cs.setInt("_id_usuario", idUsuario);
            cs.setString("_correo", correoNuevo);
            cs.setString("_telefono", telefonoNuevo);
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
    public Medico tomarDatosMedico(int idMedico) {
        Medico med = new Medico();
        Especialidad especi = new Especialidad();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call OBTENER_DATOS_MEDICO(?)}");
            cs.setInt("_id_medico", idMedico);
            rs = cs.executeQuery();
            rs.next();
            med.setDni(rs.getString("dni"));
            med.setNombre(rs.getString("nombre_completo"));
            especi.setNombre(rs.getString("nombre_especialidad"));
            med.setEspecialidad(especi);
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
        return med;
    }


    // Para la pantalla de historico citas
    @Override
    public MedicoDTO buscarMedicoConEspecialidad(int idUsuario) {
        MedicoDTO med = new MedicoDTO();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_MEDICO_CON_ESPECIALIDAD(?)}");
            cs.setInt("_id_usuario", idUsuario);
            rs = cs.executeQuery();
            rs.next();

            med.setIdMedico(rs.getInt("id_medico"));
            med.setNombreCompleto(rs.getString("nombre_completo"));
            med.setNombreEspecialidad(rs.getString("nombre_especialidad"));

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
        return med;
    }

}
