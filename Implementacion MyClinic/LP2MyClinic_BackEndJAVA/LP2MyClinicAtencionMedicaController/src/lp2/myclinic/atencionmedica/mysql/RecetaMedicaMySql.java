package lp2.myclinic.atencionmedica.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Date;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import lp2.myclinic.atencionmedica.dao.LineaRecetaDAO;
import lp2.myclinic.atencionmedica.dao.RecetaMedicaDAO;
import lp2.myclinic.atencionmedica.dto.LineaRecetaDto;
import lp2.myclinic.atencionmedica.dto.RecetaMedicaDto;
import lp2.myclinic.atencionmedica.model.LineaReceta;
import lp2.myclinic.atencionmedica.model.RecetaMedica;
import lp2.myclinic.config.DBManager;

public class RecetaMedicaMySql implements RecetaMedicaDAO {

    private Connection con;
    private CallableStatement cs;
    private ResultSet rs;
    private LineaRecetaDAO daoLineaReceta = new LineaRecetaMySql();

    @Override
    public int insertarRecetaMedica(RecetaMedicaDto recetaMedica) {
        int resultado = 0;
        SimpleDateFormat sdf = new SimpleDateFormat("dd-MM-yyyy");

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call INSERTAR_RECETA_MEDICA(?,?,?,?)}");
            cs.registerOutParameter("_id_receta_medica", java.sql.Types.INTEGER);
            cs.setInt("_id_cita", recetaMedica.getIdCitaMedica());
            cs.setDate("_vigencia_inicio", new java.sql.Date(sdf.parse(recetaMedica.getVigenciaInicial()).getTime()));
            cs.setDate("_vigencia_fin", new java.sql.Date(sdf.parse(recetaMedica.getVigenciaFinal()).getTime()));
            cs.executeUpdate();

            resultado = cs.getInt("_id_receta_medica");
            System.out.println(resultado);
            for (LineaRecetaDto linea : recetaMedica.getLineaReceta()) {
                linea.setIdRecetaMedica(resultado);
                int res = daoLineaReceta.insertarLineaRecetaMedica(linea);
                System.out.println(res);
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
    public RecetaMedica buscarRecetaMedicaPorIdCita(int idCita) {
        RecetaMedica receta = new RecetaMedica();

        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call BUSCAR_RECETA_MEDICA(?)}");
            cs.setInt("_id_cita", idCita);
            rs = cs.executeQuery();
            rs.next();
            receta.setIdRecetaMedica(rs.getInt("id_receta_medica"));
            receta.setVigenciaFinal(rs.getDate("vigencia_fin"));

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

        return receta;
    }
    
    @Override
    public ArrayList<RecetaMedica> listarRecetaMedicaPorCitaDetalle(int idCita) {
        ArrayList<RecetaMedica> recetas = new ArrayList<>();
        try {
            con = DBManager.getInstance().getConnection();
            cs = con.prepareCall("{call LISTAR_RECETA_MEDICA_X_CITA(?)}");
            cs.setInt("_id_cita", idCita);
            rs = cs.executeQuery();

            while (rs.next()) {
                RecetaMedica receta = new RecetaMedica();
                receta.setIdRecetaMedica(rs.getInt("id_receta_medica"));
                receta.setVigenciaFinal(rs.getDate("vigencia_fin"));
                recetas.add(receta);
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
        return recetas;
    }
}
