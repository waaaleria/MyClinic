package lp2.myclinic.medicinas.model;

import java.util.Date;

public class Inventario {
    private int idInventario;
    private String codigoLote;
    private Date fechaCaducidad;
    private Date fechaIngreso;
    private int stock;
    private Medicamento medicamento;

    public Inventario() {
    }

    public Inventario(String codigo_lote, Date fecha_caducidad, Date fecha_ingreso, int cantidad) {
        this.codigoLote = codigo_lote;
        this.fechaCaducidad = fecha_caducidad;
        this.fechaIngreso = fecha_ingreso;
        this.stock = cantidad;
    }

    public int getIdInventario() {
        return idInventario;
    }

    public void setIdInventario(int idInventario) {
        this.idInventario = idInventario;
    }


    public String getCodigoLote() {
        return codigoLote;
    }

    public void setCodigoLote(String codigoLote) {
        this.codigoLote = codigoLote;
    }

    public Date getFechaCaducidad() {
        return fechaCaducidad;
    }

    public void setFechaCaducidad(Date fechaCaducidad) {
        this.fechaCaducidad = fechaCaducidad;
    }

    public Date getFechaIngreso() {
        return fechaIngreso;
    }

    public void setFechaIngreso(Date fechaIngreso) {
        this.fechaIngreso = fechaIngreso;
    }

    public int getStock() {
        return stock;
    }

    public void setStock(int stock) {
        this.stock = stock;
    }

    public Medicamento getMedicamento() {
        return medicamento;
    }

    public void setMedicamento(Medicamento medicamento) {
        this.medicamento = medicamento;
    }
}
