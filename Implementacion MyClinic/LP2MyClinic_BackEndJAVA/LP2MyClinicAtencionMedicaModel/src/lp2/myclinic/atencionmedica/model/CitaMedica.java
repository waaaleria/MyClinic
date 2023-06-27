package lp2.myclinic.atencionmedica.model;

import java.util.ArrayList;
import java.util.Date;
import lp2.myclinic.itinerario.model.Horario;
import lp2.myclinic.itinerario.model.ProgramaAtencion;

public class CitaMedica {

    private int idCita;
    private int idMedico;
    private int idPaciente;
    private String motivoCita;
    private ProgramaAtencion programa;
    private ArrayList<Diagnostico> diagnosticos;
    private RecetaMedica recetaMedica;
    private Horario horario;
    private Date fecha;
    private String nombreMedico;
    private String especialidadMedico;
    
    
    public String getNombreMedico() {
        return nombreMedico;
    }

    public void setNombreMedico(String nombreMedico) {
        this.nombreMedico = nombreMedico;
    }

    public String getEspecialidadMedico() {
        return especialidadMedico;
    }

    public void setEspecialidadMedico(String especialidadMedico) {
        this.especialidadMedico = especialidadMedico;
    }

    public CitaMedica() {
    }

    // Revisar este constructor
    public CitaMedica(int idMedico, int idPaciente, String motivoCita, 
            ProgramaAtencion programa, ArrayList<Diagnostico> diagnosticos, 
            RecetaMedica recetaMedica) {
        this.idMedico = idMedico;
        this.idPaciente = idPaciente;
        this.motivoCita = motivoCita;
        this.programa = programa;
        this.diagnosticos = diagnosticos;
        this.recetaMedica = recetaMedica;
    }

    public int getIdCita() {
        return idCita;
    }

    public void setIdCita(int idCita) {
        this.idCita = idCita;
    }

    public int getIdMedico() {
        return idMedico;
    }

    public void setIdMedico(int idMedico) {
        this.idMedico = idMedico;
    }

    public int getIdPaciente() {
        return idPaciente;
    }

    public void setIdPaciente(int idPaciente) {
        this.idPaciente = idPaciente;
    }

    public String getMotivoCita() {
        return motivoCita;
    }

    public void setMotivoCita(String motivoCita) {
        this.motivoCita = motivoCita;
    }

    public ProgramaAtencion getPrograma() {
        return programa;
    }

    public void setPrograma(ProgramaAtencion programa) {
        this.programa = programa;
    }

    public ArrayList<Diagnostico> getDiagnosticos() {
        return diagnosticos;
    }

    public void setDiagnosticos(ArrayList<Diagnostico> diagnosticos) {
        this.diagnosticos = diagnosticos;
    }

    public RecetaMedica getRecetaMedica() {
        return recetaMedica;
    }

    public void setRecetaMedica(RecetaMedica recetaMedica) {
        this.recetaMedica = recetaMedica;
    }
    
        public Horario getHorario() {
        return horario;
    }

    public void setHorario(Horario horario) {
        this.horario = horario;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }
}
