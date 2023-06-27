/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package lp2.myclinic.atencionmedica.dto;

/**
 *
 * @author Valeria
 */
public class LineaRecetaDto {
    private int idLineaReceta;
    private int idRecetaMedica;
    private int idMedicamento;
    private String nombreMedicamento;
    private String dosis;
    private String frecuencia;

    public LineaRecetaDto() {
    }

    public int getIdRecetaMedica() {
        return idRecetaMedica;
    }

    public void setIdRecetaMedica(int idRecetaMedica) {
        this.idRecetaMedica = idRecetaMedica;
    }

    
    public int getIdLineaReceta() {
        return idLineaReceta;
    }

    public void setIdLineaReceta(int idLineaReceta) {
        this.idLineaReceta = idLineaReceta;
    }

    public int getIdMedicamento() {
        return idMedicamento;
    }

    public void setIdMedicamento(int idMedicamento) {
        this.idMedicamento = idMedicamento;
    }

    public String getNombreMedicamento() {
        return nombreMedicamento;
    }

    public void setNombreMedicamento(String nombreMedicamento) {
        this.nombreMedicamento = nombreMedicamento;
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
    
    
}
