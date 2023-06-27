package lp2.myclinic.medicinas.model;

public class Medicamento {
    private int idMedicamento;
    private String nombreLaboratorio;
    private String nombreComercial;
    private String descripcion;
    private float precio;
    private Componente componente;

    public Medicamento() {
    }

    public Medicamento(String nombreLaboratorio, String nombreComercial, String descripcionMedicamento, float precio, Componente componente) {
        this.nombreLaboratorio = nombreLaboratorio;
        this.nombreComercial = nombreComercial;
        this.descripcion = descripcionMedicamento;
        this.precio = precio;
        this.componente = componente;
    }

    public int getIdMedicamento() {
        return idMedicamento;
    }

    public void setIdMedicamento(int idMedicamento) {
        this.idMedicamento = idMedicamento;
    }

    public String getNombreLaboratorio() {
        return nombreLaboratorio;
    }

    public void setNombreLaboratorio(String nombreLaboratorio) {
        this.nombreLaboratorio = nombreLaboratorio;
    }

    public String getNombreComercial() {
        return nombreComercial;
    }

    public void setNombreComercial(String nombreComercial) {
        this.nombreComercial = nombreComercial;
    }

    public float getPrecio() {
        return precio;
    }

    public void setPrecio(float precio) {
        this.precio = precio;
    }

    public Componente getComponente() {
        return componente;
    }

    public void setComponente(Componente componente) {
        this.componente = componente;
    }

    public String getDescripcion() {
        return descripcion;
    }

    public void setDescripcion(String descripcion) {
        this.descripcion = descripcion;
    }
    
    
}
