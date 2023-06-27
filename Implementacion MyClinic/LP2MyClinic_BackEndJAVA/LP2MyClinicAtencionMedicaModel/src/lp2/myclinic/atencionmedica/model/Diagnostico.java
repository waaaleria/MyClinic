package lp2.myclinic.atencionmedica.model;

import java.util.ArrayList;

public class Diagnostico {
    private int idDiagnostico;
    private int idCitaMedica;
    private String descripcion;
    private String tratamiento;
    
    public Diagnostico() {
    }

    public Diagnostico(int idCitaMedica, String descripcion, String recomendaciones) {
        this.idCitaMedica = idCitaMedica;
        this.descripcion = descripcion;
    }

    public int getIdDiagnostico() {
        return idDiagnostico;
    }

    public void setIdDiagnostico(int idDiagnostico) {
        this.idDiagnostico = idDiagnostico;
    }

    public int getIdCitaMedica() {
        return idCitaMedica;
    }

    public void setIdCitaMedica(int idCitaMedica) {
        this.idCitaMedica = idCitaMedica;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

    public String getTratamiento() {
        return tratamiento;
    }

    public void setTratamiento(String tratamiento) {
        this.tratamiento = tratamiento;
    }

}
