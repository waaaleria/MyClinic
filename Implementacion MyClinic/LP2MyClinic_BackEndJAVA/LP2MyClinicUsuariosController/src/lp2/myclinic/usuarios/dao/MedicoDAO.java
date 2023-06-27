package lp2.myclinic.usuarios.dao;

import java.util.ArrayList;
import lp2.myclinic.usuarios.dto.MedicoDTO;
import lp2.myclinic.usuarios.model.Medico;

public interface MedicoDAO {

    public ArrayList<Medico> listarTodas();

    public ArrayList<Medico> listarPorNombreEspecialidad(String nombreEspecialidad);

    public MedicoDTO buscarMedico(int idUsuario);

    public MedicoDTO buscarMedicoConEspecialidad(int idUsuario);

    public int modificarMedico(int idUsuario, String correoNuevo, String telefonoNuevo);

    public Medico tomarDatosMedico(int idMedico);
}
