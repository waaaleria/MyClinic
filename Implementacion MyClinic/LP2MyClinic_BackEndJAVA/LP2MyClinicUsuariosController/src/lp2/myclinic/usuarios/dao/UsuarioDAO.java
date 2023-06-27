/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Interface.java to edit this template
 */
package lp2.myclinic.usuarios.dao;

import java.util.ArrayList;
import lp2.myclinic.usuarios.model.Especialidad;
import lp2.myclinic.usuarios.model.Medico;
import lp2.myclinic.usuarios.model.Rol;
import lp2.myclinic.usuarios.model.Usuario;

/**
 *
 * @author mezav
 */
public interface UsuarioDAO {

    public int VerificarUsuario(String username, String password);

    public ArrayList<Rol> VerificarRolesUsuario(String username, String password);

    Usuario obtenerPorId(int idUsuario);

    public ArrayList<Especialidad> listarEspecialidadesTodas();

    public ArrayList<Medico> listarMedicoxIDEspecialidad(int idespecialidad);

    public int modificarUsuario(int idUsuario, String correoNuevo, String telefonoNuevo, String contraseñaNueva);

    public int obtenerIdPaciente(int idUsuario);
    
    public int HALLAR_ID_USUARIO(String _dni);//nuevo DANNY
    
    public Medico obtener_datos_medico(int id_medico);
}
