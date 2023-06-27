package lp2.myclinic.atencionmedica.dto;

import java.util.ArrayList;
import java.util.Date;

/**
 *
 * @author Valeria
 */
public class RecetaMedicaDto {
    private int idRecetaMedica;
    private int idCitaMedica;
    private String vigenciaInicial;
    private String vigenciaFinal;
    private ArrayList<LineaRecetaDto> lineaReceta;

    public int getIdRecetaMedica() {
        return idRecetaMedica;
    }

    public void setIdRecetaMedica(int idRecetaMedica) {
        this.idRecetaMedica = idRecetaMedica;
    }

    public int getIdCitaMedica() {
        return idCitaMedica;
    }

    public void setIdCitaMedica(int idCitaMedica) {
        this.idCitaMedica = idCitaMedica;
    }

    public String getVigenciaInicial() {
        return vigenciaInicial;
    }

    public void setVigenciaInicial(String vigenciaInicial) {
        this.vigenciaInicial = vigenciaInicial;
    }

    public String getVigenciaFinal() {
        return vigenciaFinal;
    }

    public void setVigenciaFinal(String vigenciaFinal) {
        this.vigenciaFinal = vigenciaFinal;
    }



    public ArrayList<LineaRecetaDto> getLineaReceta() {
        return lineaReceta;
    }

    public void setLineaReceta(ArrayList<LineaRecetaDto> lineaReceta) {
        this.lineaReceta = lineaReceta;
    }
    
    
}
