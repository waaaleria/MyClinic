package lp2.myclinic.usuarios.model;

import lp2.myclinic.itinerario.model.ProgramaAtencion;

public class Medico extends Usuario {

    private int idMedico;
    private int experiencia;
    private String estudios;
    private String cmp;
    private Especialidad especialidad;
    private ProgramaAtencion programa;

    public Medico() {
    }

    public Medico(int idMedico, int experiencia, String estudios, String cmp, Especialidad especialidad, ProgramaAtencion programa, String dni, String nombre, String apellido, int edad, String correo, String genero, String telefono, String contraseña, Rol rol) {
        super(dni, nombre, apellido, edad, correo, genero, telefono, contraseña, rol);
        this.idMedico = idMedico;
        this.experiencia = experiencia;
        this.estudios = estudios;
        this.cmp = cmp;
        this.especialidad = especialidad;
        this.programa = programa;
    }

    public Medico(int experiencia, String estudios, String cmp, Especialidad especialidad) {
        this.experiencia = experiencia;
        this.estudios = estudios;
        this.cmp = cmp;
        this.especialidad = especialidad;
    }

    public int getIdMedico() {
        return idMedico;
    }

    public void setIdMedico(int idMedico) {
        this.idMedico = idMedico;
    }

    public int getExperiencia() {
        return experiencia;
    }

    public void setExperiencia(int experiencia) {
        this.experiencia = experiencia;
    }

    public String getEstudios() {
        return estudios;
    }

    public void setEstudios(String estudios) {
        this.estudios = estudios;
    }

    public String getCmp() {
        return cmp;
    }

    public void setCmp(String cmp) {
        this.cmp = cmp;
    }

    public Especialidad getEspecialidad() {
        return especialidad;
    }

    public void setEspecialidad(Especialidad especialidad) {
        this.especialidad = especialidad;
    }

    public ProgramaAtencion getPrograma() {
        return programa;
    }

    public void setPrograma(ProgramaAtencion programa) {
        this.programa = programa;
    }

}
