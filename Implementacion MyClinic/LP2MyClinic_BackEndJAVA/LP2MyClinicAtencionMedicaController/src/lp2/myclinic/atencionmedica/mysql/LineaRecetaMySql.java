package lp2.myclinic.atencionmedica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dao.LineaRecetaDAO;
import lp2.myclinic.atencionmedica.dto.LineaRecetaDto;
import lp2.myclinic.atencionmedica.model.LineaReceta;
import lp2.myclinic.config.DBManager;
import lp2.myclinic.medicinas.model.Medicamento;

public class LineaRecetaMySql implements LineaRecetaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;

    @Override
    public int insertarLineaRecetaMedica(LineaRecetaDto lineaReceta) { //INSERTAR_LINEA_RECETA
        int resultado = 0;
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_LINEA_RECETA(?,?,?,?,?)}");
            cs.registerOutParameter("_id_linea_receta", java.sql.Types.INTEGER);
            cs.setInt("_id_receta_medica", lineaReceta.getIdRecetaMedica());
            cs.setInt("_id_medicamento", lineaReceta.getIdMedicamento());
            cs.setString("_dosis", lineaReceta.getDosis());
            cs.setString("_frecuencia", lineaReceta.getFrecuencia());
            cs.executeUpdate();
            lineaReceta.setIdLineaReceta(cs.getInt("_id_linea_receta"));
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
    public ArrayList<LineaRecetaDto> listarLineaRecetaMedica(int idRecetaMedica) { //LISTAR_LINEA_RECETA_MEDICA
        ArrayList<LineaRecetaDto> lineas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_LINEA_RECETA_MEDICA(?)}");
            cs.setInt("_id_receta_medica", idRecetaMedica);
            rs = cs.executeQuery();

            while (rs.next()) {
                LineaRecetaDto linea = new LineaRecetaDto();
                linea.setIdLineaReceta(rs.getInt("id_linea_receta"));
                linea.setNombreMedicamento(rs.getString("nombre_comercial"));
                linea.setDosis(rs.getString("dosis"));
                linea.setFrecuencia(rs.getString("frecuencia"));
                lineas.add(linea);
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
        return lineas;
    }

    @Override
    public ArrayList<LineaReceta> listarRecetaxCita(int id_cita) { //LISTAR_RECETAXCITA
        ArrayList<LineaReceta> Lineas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECETAXCITA(?)}");
            cs.setInt("_id_cita", id_cita);
            rs = cs.executeQuery();

            while (rs.next()) {
                LineaReceta Linea = new LineaReceta();
                Medicamento medica = new Medicamento();
                medica.setIdMedicamento(rs.getInt("id_medicamento"));
                Linea.setMedicamento(medica);
                Linea.setDosis(rs.getString("dosis"));
                Linea.setFrecuencia(rs.getString("frecuencia"));
                Lineas.add(Linea);
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
        return Lineas;
    }
}
