package lp2.myclinic.usuarios.dao;

import java.util.ArrayList;
import lp2.myclinic.usuarios.model.Paciente;

public interface PacienteDAO {

    public ArrayList<Paciente> listarTodas();
    public ArrayList<Paciente> listarPacientesPorDniNombre(String dniNombre);
    public int modificarPaciente(String dni, String correoNuevo, String telefonoNuevo, String generonuevo);
}
