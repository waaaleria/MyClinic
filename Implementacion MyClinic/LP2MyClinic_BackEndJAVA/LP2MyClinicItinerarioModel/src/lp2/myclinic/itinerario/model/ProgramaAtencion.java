package lp2.myclinic.itinerario.model;

import java.sql.Time;
import java.time.LocalTime;
import java.util.ArrayList;
import java.util.Date;


public class ProgramaAtencion {
    int idProgramaAtencion;
    int idMedico;
    DiaSemana diaSemana;
    Time hora_inicio;
    Time hora_fin;
    Date fecha;
    
    
    public ProgramaAtencion() {
        this.idMedico=0;
    }

    //NUEVO CAMBIO DANNY reserva cita
    public ProgramaAtencion(int idMedico, DiaSemana diaSemana, Time hora_inicio, Time hora_fin, Date fecha) {
        this.idMedico = idMedico;
        this.diaSemana = diaSemana;
        this.hora_inicio = hora_inicio;
        this.hora_fin = hora_fin;
        this.fecha = fecha;
    }

    public int getIdProgramaAtencion() {
        return idProgramaAtencion;
    }

    public void setIdProgramaAtencion(int idProgramaAtencion) {
        this.idProgramaAtencion = idProgramaAtencion;
    }

    public int getIdMedico() {
        return idMedico;
    }

    public void setIdMedico(int idMedico) {
        this.idMedico = idMedico;
    }

    public DiaSemana getDiaSemana() {
        return diaSemana;
    }

    public void setDiaSemana(DiaSemana diaSemana) {
        this.diaSemana = diaSemana;
    }

    //NUEVO CAMBIO DANNY reserva cita
    public Time getHora_inicio() {
        return hora_inicio;
    }
    //NUEVO CAMBIO DANNY reserva cita
    public void setHora_inicio(Time hora_inicio) {
        this.hora_inicio = hora_inicio;
    }
    //NUEVO CAMBIO DANNY reserva cita
    public Time getHora_fin() {
        return hora_fin;
    }
    //NUEVO CAMBIO DANNY reserva cita
    public void setHora_fin(Time hora_fin) {
        this.hora_fin = hora_fin;
    }


    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

 
}
