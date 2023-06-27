package lp2.myclinic.usuarios.model;

import lp2.myclinic.itinerario.model.ProgramaAtencion;

public class Administrador extends Usuario{
    private int idAdministrador;
    private String codigoTrabajo;
    private String tipo; // Admin
    private int experiencia;
    private ProgramaAtencion programa;

    public Administrador() {
    }

    
    public Administrador(String codigoTrabajo, String tipo, int experiencia, ProgramaAtencion programa, String dni, String nombre, String apellido, int edad, String correo, String genero, String telefono, String contraseña, Rol rol) {
        super(dni, nombre, apellido, edad, correo, genero, telefono, contraseña, rol);
        this.codigoTrabajo = codigoTrabajo;
        this.tipo = tipo;
        this.experiencia = experiencia;
        this.programa = programa;
    }

    public int getIdAdministrador() {
        return idAdministrador;
    }

    public void setIdAdministrador(int idAdministrador) {
        this.idAdministrador = idAdministrador;
    }

    public String getCodigoTrabajo() {
        return codigoTrabajo;
    }

    public void setCodigoTrabajo(String codigoTrabajo) {
        this.codigoTrabajo = codigoTrabajo;
    }

    public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }

    public int getExperiencia() {
        return experiencia;
    }

    public void setExperiencia(int experiencia) {
        this.experiencia = experiencia;
    }

    public ProgramaAtencion getPrograma() {
        return programa;
    }

    public void setPrograma(ProgramaAtencion programa) {
        this.programa = programa;
    }
    
    
    
}
