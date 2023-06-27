package lp2.myclinic.medicinas.model;

public class Componente {
    
    private int idComponente;
    private String nombreComponente;
    private String descripcion;
    
    public Componente() {
    }

    public Componente(String nombreComponente) {
        this.nombreComponente = nombreComponente;
    }

    public int getIdComponente() {
        return idComponente;
    }

    public void setIdComponente(int idComponente) {
        this.idComponente = idComponente;
    }

    public String getNombreComponente() {
        return nombreComponente;
    }

    public void setNombreComponente(String nombreComponente) {
        this.nombreComponente = nombreComponente;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }

}
