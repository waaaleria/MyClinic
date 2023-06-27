package lp2.myclinic.usuarios.model;

import java.util.Date;

public class Paciente extends Usuario{
    private int idPaciente;
    private Date primeraVisita;
    private Date ultimaVisita;

    public Paciente() {
    }

    public Paciente(int idPaciente, Date primeraVisita, Date ultimaVisita, String DNI, String nombre, String apellido, int edad, String correo, String genero, String telefono, String contraseña, Rol rol) {
        super(DNI, nombre, apellido, edad, correo, genero, telefono, contraseña, rol);
        this.idPaciente = idPaciente;
        this.primeraVisita = primeraVisita;
        this.ultimaVisita = ultimaVisita;
    }

  
    public int getIdPaciente() {
        return idPaciente;
    }

    public void setIdPaciente(int idPaciente) {
        this.idPaciente = idPaciente;
    }

    public Date getPrimeraVisita() {
        return primeraVisita;
    }

    public void setPrimeraVisita(Date primeraVisita) {
        this.primeraVisita = primeraVisita;
    }

    public Date getUltimaVisita() {
        return ultimaVisita;
    }

    public void setUltimaVisita(Date ultimaVisita) {
        this.ultimaVisita = ultimaVisita;
    }
    
    
}
