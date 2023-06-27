package lp2.myclinic.atencionmedica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Optional;
import lp2.myclinic.atencionmedica.dao.CitaMedicaDAO;
import lp2.myclinic.atencionmedica.dao.DiagnosticoDAO;
import lp2.myclinic.atencionmedica.dao.RecetaMedicaDAO;
import lp2.myclinic.atencionmedica.dto.CitaMedicaDto;
import lp2.myclinic.atencionmedica.model.CitaMedica;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.itinerario.dao.ProgramaAtencionDAO;
import lp2.myclinic.itinerario.model.ProgramaAtencion;
import lp2.myclinic.itinerario.mysql.ProgramaAtencionMySql;

public class CitaMedicaMySql implements CitaMedicaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;

    private ProgramaAtencionDAO daoProgramaAtencion = new ProgramaAtencionMySql();
    private RecetaMedicaDAO daoRecetaMedica = new RecetaMedicaMySql();
    private DiagnosticoDAO daoDiagnostico = new DiagnosticoMySql();

    //Para el medico
    public ArrayList<CitaMedicaDto> filtrarCitasPorPacienteFecha(int idMed, int idPac, String fechaIni, String fechaFin) {
        ArrayList<CitaMedicaDto> citas = new ArrayList<>();
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CITAS_MEDICO_POR_PACIENTE_FECHAS(?, ?, ?, ?)}");
            cs.setInt("_id_medico", idMed);
            cs.setInt("_id_paciente", idPac);
            cs.setDate("_fecha_inicio", new java.sql.Date(sdf.parse(fechaIni).getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(sdf.parse(fechaFin).getTime()));

            rs = cs.executeQuery();

            while (rs.next()) {
                CitaMedicaDto cita = new CitaMedicaDto();
                cita.setIdCita(rs.getInt("id_cita"));
                cita.setFecha(rs.getDate("fecha"));
                cita.setHorario(rs.getString("horario"));
                cita.setPaciente(rs.getString("paciente"));
                cita.setMotivo(rs.getString("motivo_cita"));
                cita.setActivo(rs.getInt("activo"));
                citas.add(cita);
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

        return citas;
    }

    @Override
    public int modificarCita(CitaMedica citaMedica) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_CITA(?,?)}");

            cs.setInt("_id_cita", citaMedica.getIdCita());
            cs.setString("_motivo_cita", citaMedica.getMotivoCita());
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
    public CitaMedica buscarCita(int idCita) {
        CitaMedica cita = new CitaMedica();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CITA(?)}");
            rs = cs.executeQuery();
            rs.next();
            cita.setIdCita(rs.getInt("id_cita"));
            cita.setMotivoCita(rs.getString("motivo_cita"));

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

        return cita;
    }

    //Para el paciente
    @Override
    public ArrayList<CitaMedica> listarCitasXPaciente(int idPac) {
        ArrayList<CitaMedica> citas = new ArrayList<>();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CITAS_X_PACIENTE(?)}");
            cs.setInt("_id_paciente", idPac);
            rs = cs.executeQuery();

            while (rs.next()) {
                CitaMedica cita = new CitaMedica();
                cita.setIdCita(rs.getInt("id_cita"));
                cita.setFecha(rs.getDate("fecha"));
                cita.setIdMedico(rs.getInt("id_medico"));
                cita.setMotivoCita(rs.getString("motivo_cita"));
                citas.add(cita);
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
        return citas;
    }

    @Override
    public int reservarCitaMedica(int idusu, int idmed, int idpro) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_CITA(?,?,?,?)}");
            cs.registerOutParameter("_idCitaMedica", java.sql.Types.INTEGER);
            cs.setInt("_idUsuario", idusu);
            cs.setInt("_idMedico", idmed);
            cs.setInt("_idprograma", idpro);

            cs.executeUpdate();
            //citaMedica.setIdCita(cs.getInt("_idCitaMedica"));
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
    public ArrayList<CitaMedica> listarCitasxPacientexFecha(int idPac, Date fechaIni, Date fechaFin) {
        ArrayList<CitaMedica> citas = new ArrayList<>();
        SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_CITAS_POR_PACIENTE_CON_FECHAS(?,?,?)}");
            cs.setInt("_id_paciente", idPac);
            cs.setDate("_fecha_inicio", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fecha_fin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();
            while (rs.next()) {
                CitaMedica cita = new CitaMedica();
                cita.setIdCita(rs.getInt("id_cita"));
                cita.setFecha(rs.getDate("fecha"));
                cita.setIdMedico(rs.getInt("id_medico"));
                cita.setMotivoCita(rs.getString("motivo_cita"));
                citas.add(cita);
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
        return citas;
    }
    
    public ArrayList<CitaMedica> ListarHorarioPacienteFechaIniFinal(int idUsu, Date fechaIni, Date fechaFin) {//cambios Dannny modificar cita
       ArrayList<CitaMedica> citas = new ArrayList<>();
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIO_PACIENTE_FECHA_INI_FINAL(?,?,?)}");
            cs.setInt("_idusuario", idUsu);
            cs.setDate("_fechaini", new java.sql.Date(fechaIni.getTime()));
            cs.setDate("_fechafin", new java.sql.Date(fechaFin.getTime()));
            rs = cs.executeQuery();

            while (rs.next()) {
                CitaMedica cita = new CitaMedica();
                ProgramaAtencion programa = new ProgramaAtencion();
                programa.setFecha(rs.getDate("fecha"));
                programa.setHora_fin(rs.getTime("hora_fin"));
                programa.setHora_inicio(rs.getTime("hora_inicio"));
                cita.setPrograma(programa);
//                cita.getPrograma().setFecha(rs.getDate("fecha"));
//                cita.getPrograma().setHora_fin(rs.getTime("hora_fin"));
//                cita.getPrograma().setHora_inicio(rs.getTime("hora_inicio"));
                cita.setIdCita(rs.getInt("id_cita"));
                cita.setNombreMedico(rs.getString("nombremedico"));
                cita.setEspecialidadMedico(rs.getString("nombre_especialidad"));
                citas.add(cita);
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
        return citas;
    }
    
    @Override
    public int eliminar(int idcitaMedica){
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_CITAMEDICA(?)}");
            cs.setInt("_id_citaMedica", idcitaMedica);
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
    
}
