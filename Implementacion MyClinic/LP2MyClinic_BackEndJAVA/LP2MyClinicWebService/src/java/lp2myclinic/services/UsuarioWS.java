package lp2myclinic.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import lp2.myclinic.usuarios.dao.AdministradorDAO;

import lp2.myclinic.usuarios.dao.MedicoDAO;
import lp2.myclinic.usuarios.dao.PacienteDAO;
import lp2.myclinic.usuarios.dao.UsuarioDAO;
import lp2.myclinic.usuarios.dto.MedicoDTO;
import lp2.myclinic.usuarios.model.Administrador;
import lp2.myclinic.usuarios.model.Especialidad;
import lp2.myclinic.usuarios.model.Medico;
import lp2.myclinic.usuarios.model.Paciente;
import lp2.myclinic.usuarios.model.Rol;
import lp2.myclinic.usuarios.model.Usuario;
import lp2.myclinic.usuarios.mysql.AdministradorMySql;

import lp2.myclinic.usuarios.mysql.MedicoMySql;
import lp2.myclinic.usuarios.mysql.PacienteMySql;
import lp2.myclinic.usuarios.mysql.UsuarioMySQL;

@WebService(serviceName = "UsuarioWS")
public class UsuarioWS {

    private MedicoDAO daoMedico = new MedicoMySql();
    private PacienteDAO daoPaciente = new PacienteMySql();
    private UsuarioDAO daoUsuario = new UsuarioMySQL();
    private AdministradorDAO daoAdministrador = new AdministradorMySql();

    //MEDICOS
    @WebMethod(operationName = "listarMedicosTodos")//LISTAR_MEDICOS_TODOS
    public ArrayList<Medico> listarMedicosTodos() {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            medicos = daoMedico.listarTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicos;
    }

    @WebMethod(operationName = "listarMedicosPorNombreEspecialidad")//LISTAR_MEDICO_NOMBRE_X_ESPECIALIDAD
    public ArrayList<Medico> listarMedicosPorNombreEspecialidad(String nombreEsp) {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            medicos = daoMedico.listarPorNombreEspecialidad(nombreEsp);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicos;
    }

    @WebMethod(operationName = "buscarMedico") //BUSCAR_MEDICO
    public MedicoDTO buscarMedico(@WebParam(name = "idUsuario") int idUsuario) {
        MedicoDTO medico = new MedicoDTO();
        try {
            medico = daoMedico.buscarMedico(idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medico;
    }

    @WebMethod(operationName = "buscarMedicoConEspecialidad") //BUSCAR_MEDICO_CON_ESPECIALIDAD
    public MedicoDTO buscarMedicoConEspecialidad(@WebParam(name = "idUsuario") int idUsuario) {
        MedicoDTO medico = new MedicoDTO();
        try {
            medico = daoMedico.buscarMedicoConEspecialidad(idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medico;
    }

    @WebMethod(operationName = "modificarMedico")//MODIFICAR_MEDICO
    public int modificarMedico(int idUsuario, String correoNuevo, String telefonoNuevo) {
        int resultado = 0;
        try {
            resultado = daoMedico.modificarMedico(idUsuario, correoNuevo, telefonoNuevo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarPacientesPorDniNombre")//LISTAR_PACIENTES_X_DNI_NOMBRE
    public ArrayList<Paciente> listarPacientesPorDniNombre(String dniNombre) {
        ArrayList<Paciente> pacientes = new ArrayList<>();
        try {
            pacientes = daoPaciente.listarPacientesPorDniNombre(dniNombre);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return pacientes;
    }

    @WebMethod(operationName = "verificarRolesDeUsuario") //VERIFICAR_USUARIO_v2
    public ArrayList<Rol> verificarRolesDeUsuario(String user, String password) {
        ArrayList<Rol> roles = new ArrayList<>();
        try {
            roles = daoUsuario.VerificarRolesUsuario(user, password);
            //roles = daoUsuario.VerificarUsuario2(usuario.getDni(), usuario.getContraseña());
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return roles;
    }

    @WebMethod(operationName = "verificarCuentaUsuario") //VERIFICAR_USUARIO
    public int verificarCuentaUsuario(String user, String passwor) {
        int resultado = 0;
        try {
            resultado = daoUsuario.VerificarUsuario(user, passwor);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "obtenerUsuarioPorId") //OBTENER_USUARIO_X_ID
    public Usuario obtenerUsuarioPorId(int idUsuario) {
        Usuario usuario = new Usuario();
        try {
            usuario = daoUsuario.obtenerPorId(idUsuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return usuario;
    }

    @WebMethod(operationName = "modificarPaciente")//MODIFICAR_PERFIL_PACIENTE
    public int modificarPaciente(String dni, String correoNuevo, String telefonoNuevo, String generonuevo) {
        int resultado = 0;
        try {
            resultado = daoPaciente.modificarPaciente(dni, correoNuevo, telefonoNuevo, generonuevo);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "listarAdministradoresTodos")//LISTAR_ADMINISTRADOR_TODOS
    public ArrayList<Administrador> listarAdministradoresTodos() {
        ArrayList<Administrador> administradores = new ArrayList<>();
        try {
            administradores = daoAdministrador.listarAdministradores();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return administradores;
    }

    @WebMethod(operationName = "listarEspecialidadesTodas")//LISTAR_ESPECIALIDADES_TODOS
    public ArrayList<Especialidad> listarEspecialidadesTodas() {
        ArrayList<Especialidad> especialidades = new ArrayList<>();
        try {
            especialidades = daoUsuario.listarEspecialidadesTodas();
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return especialidades;
    }

    @WebMethod(operationName = "listarMedicoXidEspecialidad")//BUSCAR_MEDICO_x_ID_ESPECIALIDAD
    public ArrayList<Medico> listarMedicoXidEspecialidad(int idespecialidad) {
        ArrayList<Medico> medicos = new ArrayList<>();
        try {
            medicos = daoUsuario.listarMedicoxIDEspecialidad(idespecialidad);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medicos;
    }

    @WebMethod(operationName = "modificarUsuario")//MODIFICAR_PERFIL_PACIENTE
    public int modificarUsuario(int dni, String correoNuevo, String telefonoNuevo, String contraseñaNueva) {
        int resultado = 0;
        try {
            resultado = daoUsuario.modificarUsuario(dni, correoNuevo, telefonoNuevo, contraseñaNueva);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "obtenerIdPaciente")//MODIFICAR_PERFIL_PACIENTE
    public int obtenerIdPaciente(int id_usuario) {
        int resultado = 0;
        try {
            resultado = daoUsuario.obtenerIdPaciente(id_usuario);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }

    @WebMethod(operationName = "tomarDatosMedico") //BUSCAR_MEDICO
    public Medico tomarDatosMedico(@WebParam(name = "idMedico") int idMedico) {
        Medico medico = new Medico();
        try {
            medico = daoMedico.tomarDatosMedico(idMedico);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medico;
    }
    
    @WebMethod(operationName = "halalr_id_usuario")//HALLAR_ID_USUARIO
    public int halalr_id_usuario(String _dni) {
        ArrayList<Usuario> usuarios = new ArrayList<>();
        int resultado=0;
        try {
            resultado = daoUsuario.HALLAR_ID_USUARIO(_dni);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return resultado;
    }
    
    @WebMethod(operationName = "obtener_datos_medico")//HALLAR_ID_USUARIO
    public Medico obtener_datos_medico(int id_medico) {
        Medico medico = new Medico();
        try {
            medico = daoUsuario.obtener_datos_medico(id_medico);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
        return medico;
    }
}
