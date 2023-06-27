package lp2.myclinic.atencionmedica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dao.DiagnosticoDAO;
import lp2.myclinic.atencionmedica.model.Diagnostico;
import lp2.myclinic.config.DBManager;

public class DiagnosticoMySql implements DiagnosticoDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private Statement st;
    
    @Override
    public ArrayList<Diagnostico> listarDiagnosticosPorCita(int idCita) {
        ArrayList<Diagnostico> diagnosticos = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_DIAGNOSTICOS(?)}");
            cs.setInt("_id_cita", idCita);
            rs = cs.executeQuery();
            while (rs.next()) {
                Diagnostico diagnostico = new Diagnostico();
                diagnostico.setIdDiagnostico(rs.getInt("id_diagnostico"));
                diagnostico.setDescripcion(rs.getString("descripcion"));
                diagnostico.setTratamiento(rs.getString("tratamiento"));
                diagnosticos.add(diagnostico);
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
        return diagnosticos;
    }

    @Override
    public int asignarDiagnosticosACita(ArrayList<Diagnostico> diagnosticos) {
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();

            for (Diagnostico diagnostico : diagnosticos) {
                cs = con.prepareCall("{call INSERTAR_DIAGNOSTICO(?,?,?,?)}");

                cs.registerOutParameter("_id_diagnostico", java.sql.Types.INTEGER);
                cs.setInt("_id_cita", diagnostico.getIdCitaMedica());
                cs.setString("_descripcion", diagnostico.getDescripcion());
                cs.setString("_tratamiento", diagnostico.getTratamiento());
                cs.executeUpdate();
            }

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
    public int eliminarDiagnostico(int idDiagnostico) {

        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call ELIMINAR_DIAGNOSTICO(?)}");
            cs.setInt("_id_diagnostico", idDiagnostico);
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
