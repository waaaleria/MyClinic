package lp2.myclinic.usuarios.model;

public class Rol {
    private int idRol;
    private String cargo;

    public Rol(String cargo) {
        this.cargo = cargo;
    }

    public Rol() {
        //throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

    public int getIdRol() {
        return idRol;
    }

    public void setIdRol(int idRol) {
        this.idRol = idRol;
    }

    public String getCargo() {
        return cargo;
    }

    public void setCargo(String cargo) {
        this.cargo = cargo;
    }
    
    
    
    
}
