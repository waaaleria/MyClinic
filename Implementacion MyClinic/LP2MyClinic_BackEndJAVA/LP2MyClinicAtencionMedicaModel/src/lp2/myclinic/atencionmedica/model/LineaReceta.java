package lp2.myclinic.atencionmedica.model;

import lp2.myclinic.medicinas.model.Medicamento;

public class LineaReceta {

    private int idLineaReceta;
    private Medicamento medicamento;
    private String dosis;
    private String frecuencia;
    private int idRecetaMedica;

    public LineaReceta(Medicamento medicamento, String dosis, String frecuencia) {
        this.medicamento = medicamento;
        this.dosis = dosis;
        this.frecuencia = frecuencia;
    }

    public LineaReceta() {
    }

    public int getIdLineaReceta() {
        return idLineaReceta;
    }

    public void setIdLineaReceta(int idLineaReceta) {
        this.idLineaReceta = idLineaReceta;
    }

    public Medicamento getMedicamento() {
        return medicamento;
    }

    public void setMedicamento(Medicamento medicamento) {
        this.medicamento = medicamento;
    }

    public String getDosis() {
        return dosis;
    }

    public void setDosis(String dosis) {
        this.dosis = dosis;
    }

    public String getFrecuencia() {
        return frecuencia;
    }

    public void setFrecuencia(String frecuencia) {
        this.frecuencia = frecuencia;
    }

    public int getIdRecetaMedica() {
        return idRecetaMedica;
    }

    public void setIdRecetaMedica(int idRecetaMedica) {
        this.idRecetaMedica = idRecetaMedica;
    }
    
}
