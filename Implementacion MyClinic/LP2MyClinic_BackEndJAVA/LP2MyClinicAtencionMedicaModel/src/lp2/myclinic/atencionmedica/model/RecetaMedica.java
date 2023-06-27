package lp2.myclinic.atencionmedica.model;

import java.util.ArrayList;
import java.util.Date;

public class RecetaMedica {

    private int idRecetaMedica;
    private int idCitaMedica;
    private Date vigenciaInicial;
    private Date vigenciaFinal;
    private ArrayList<LineaReceta> lineaReceta;
    
    public RecetaMedica() {
    }

    public RecetaMedica(int idCitaMedica, Date vigenciaInicial, Date vigenciaFinal) {
        this.idCitaMedica = idCitaMedica;
        this.vigenciaInicial = vigenciaInicial;
        this.vigenciaFinal = vigenciaFinal;
    }

    public int getIdCitaMedica() {
        return idCitaMedica;
    }

    public void setIdCitaMedica(int idCitaMedica) {
        this.idCitaMedica = idCitaMedica;
    }

    public Date getVigenciaInicial() {
        return vigenciaInicial;
    }

    public void setVigenciaInicial(Date vigenciaInicial) {
        this.vigenciaInicial = vigenciaInicial;
    }

    public Date getVigenciaFinal() {
        return vigenciaFinal;
    }

    public void setVigenciaFinal(Date vigenciaFinal) {
        this.vigenciaFinal = vigenciaFinal;
    }

    public int getIdRecetaMedica() {
        return idRecetaMedica;
    }

    public void setIdRecetaMedica(int idRecetaMedica) {
        this.idRecetaMedica = idRecetaMedica;
    }

    public ArrayList<LineaReceta> getLineaReceta() {
        return lineaReceta;
    }

    public void setLineaReceta(ArrayList<LineaReceta> lineaReceta) {
        this.lineaReceta = lineaReceta;
    }

}
