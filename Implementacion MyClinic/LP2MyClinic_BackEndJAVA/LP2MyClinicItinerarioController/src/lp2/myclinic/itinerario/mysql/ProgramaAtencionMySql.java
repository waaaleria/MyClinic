package lp2.myclinic.itinerario.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.Time;
import java.util.ArrayList;
import java.util.Date;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.itinerario.dao.ProgramaAtencionDAO;
import lp2.myclinic.itinerario.model.DiaSemana;
import lp2.myclinic.itinerario.model.ProgramaAtencion;

public class ProgramaAtencionMySql implements ProgramaAtencionDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;
    private String ti;

    public int insertar(ProgramaAtencion programa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_PROGRAMA_ATENCION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_programa", java.sql.Types.INTEGER);
            cs.setTime("_hora_inicio", programa.getHora_inicio());//NUEVO CAMBIO DANNY reserva cita
            cs.setTime("_hora_fin", programa.getHora_fin());//NUEVO CAMBIO DANNY reserva cita
            cs.setDate("_fecha", new java.sql.Date(programa.getFecha().getTime()));
            cs.setString("_dia_semana", programa.getDiaSemana().toString());

            cs.executeUpdate();
            programa.setIdProgramaAtencion(cs.getInt("_id_ProgramaAtencion"));
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

    public int modificar(ProgramaAtencion programa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call MODIFICAR_PROGRAMA_ATENCION(?,?,?)}");
            cs.setInt("_id_programa", programa.getIdProgramaAtencion());
            cs.setTime("_hora_inicio", programa.getHora_inicio());//NUEVO CAMBIO DANNY reserva cita
            cs.setTime("_hora_fin", programa.getHora_fin());//NUEVO CAMBIO DANNY reserva cita
            cs.setDate("_fecha", new java.sql.Date(programa.getFecha().getTime()));
            cs.setString("_dia_semana", programa.getDiaSemana().toString());

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

    public ArrayList<ProgramaAtencion> listarTodas() {
        ArrayList<ProgramaAtencion> programas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_PROGRAMA_ATENCION_TODOS()}");
            rs = cs.executeQuery();

            while (rs.next()) {
                ProgramaAtencion programa = new ProgramaAtencion();
                programa.setIdProgramaAtencion(rs.getInt("id_programa"));
                programa.setFecha(rs.getDate("fecha_fin"));
                programa.setHora_inicio(rs.getTime("hora_inicio"));//NUEVO CAMBIO DANNY reserva cita
                programa.setHora_fin(rs.getTime("hora_fin"));//NUEVO CAMBIO DANNY reserva cita
                programas.add(programa);
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
        return programas;
    }

    public ArrayList<ProgramaAtencion> listarPorFechaMedico(int idMedico, Date fechaPrograma) {
        ArrayList<ProgramaAtencion> programas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIOS_X_FECHA_MEDICO(?,?)}");
            cs.setInt("_id_medico", idMedico);
            cs.setDate("_fecha", new java.sql.Date(fechaPrograma.getTime()));
            
            rs = cs.executeQuery();

            while (rs.next()) {
                ProgramaAtencion programa = new ProgramaAtencion();
                programa.setIdProgramaAtencion(rs.getInt("id_programa"));
                programa.setFecha(rs.getDate("fecha"));
                programa.setIdMedico(rs.getInt("id_medico"));
                programa.setDiaSemana(DiaSemana.values()[rs.getInt("id_dia_semana") - 1]);
                programa.setHora_inicio(rs.getTime("hora_inicio"));//NUEVO CAMBIO DANNY reserva cita
                programa.setHora_fin(rs.getTime("hora_fin"));//NUEVO CAMBIO DANNY reserva cita
                programas.add(programa);
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
        return programas;
    }

    @Override
    public ProgramaAtencion buscarProgramaPorIdCita(int idCita) {
        ProgramaAtencion programa = new ProgramaAtencion();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_PROGRAMA_POR_IDCITA(?)}");
            cs.setInt("_id_cita", idCita);
            rs = cs.executeQuery();

            programa.setIdProgramaAtencion(rs.getInt("id_programa"));
            programa.setIdMedico(rs.getInt("id_medico"));
            programa.setDiaSemana(DiaSemana.values()[rs.getInt("id_dia_semana") - 1]);
            programa.setHora_inicio(rs.getTime("hora_inicio"));//NUEVO CAMBIO DANNY reserva cita
            programa.setHora_fin(rs.getTime("hora_fin"));//NUEVO CAMBIO DANNY reserva cita
            programa.setFecha(rs.getDate("fecha"));

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

        return programa;
    }

    @Override
    public int eliminar(int idPrograma) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_PROGRAMA_ATENCION(?,?,?)}");
            cs.setInt("_idPrograma", idPrograma);
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
    
    public int insertarListaProgramas(ProgramaAtencion programa) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_HORARIOS_PROGRAMAATENCION(?,?,?,?,?)}");
            cs.registerOutParameter("_id_programa", java.sql.Types.INTEGER);
            cs.setInt("_id_medico", programa.getIdMedico());
            cs.setTime("_HORA_INICIO", programa.getHora_inicio());
            cs.setTime("_HORA_FIN", programa.getHora_fin());
            
            cs.setDate("_FECHA", new java.sql.Date(programa.getFecha().getTime()));

            
            cs.executeUpdate();
            resultado = 1;
            programa.setIdProgramaAtencion(cs.getInt("id_programa"));
            
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
    
      public ArrayList<ProgramaAtencion> listarProgramasMedicos(int idMedico) {
        ArrayList<ProgramaAtencion> programas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_HORARIOS_X_ID_MEDICO(?)}");
            cs.setInt("_id_medico", idMedico);
            rs = cs.executeQuery();

            while (rs.next()) {
                ProgramaAtencion programa = new ProgramaAtencion();
                programa.setIdProgramaAtencion(rs.getInt("id_programa"));
                programa.setIdMedico(rs.getInt("id_medico"));
                programa.setFecha(rs.getDate("fecha"));
                programa.setHora_inicio(rs.getTime("hora_inicio"));
                programa.setHora_fin(rs.getTime("hora_fin"));
                programa.setDiaSemana(DiaSemana.values()[rs.getInt("id_dia_semana") - 1]);

                //programa.getDiaSemana().setIdDiaSemana(rs.getInt("id_dia_semana"));
                programas.add(programa);
            }

        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        } finally {
            try {rs.close(); } catch (Exception ex) { System.out.println(ex.getMessage());}
            try {con.close();} catch (Exception ex) { System.out.println(ex.getMessage());}
        }
        return programas;
    }
}
