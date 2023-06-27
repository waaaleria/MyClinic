package lp2.myclinic.config;

import java.sql.Connection;
import java.sql.DriverManager;

public class DBManager {
    private static DBManager dbManager;
    private String url = "jdbc:mysql://" +
    "database-lp2-myclinic.cte9bdh9qq5q.us-east-1.rds.amazonaws.com" +
            ":3306/PRUEBA?useSSL=false";
    private String user = "admin";
    private String password = "Arf22$&dfs";
    private Connection con;
    
    private synchronized static void createInstance(){
        if(dbManager == null){
            dbManager = new DBManager();
        }
    }
    
    public Connection getConnection(){
        try{
            //Registrar el driver JDBC
            Class.forName("com.mysql.cj.jdbc.Driver");
            //Realizar la conexión
            con = DriverManager.getConnection(url,user,password);
        }catch(Exception ex){
            System.out.println(ex.getMessage());
        }
        return con;
    }
    
    public static DBManager getInstance(){
        if(dbManager == null){
            createInstance();
        }
        return dbManager;
    }
    
}