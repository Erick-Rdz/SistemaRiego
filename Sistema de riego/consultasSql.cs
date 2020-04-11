using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_riego
{
    public class consultasSql
    {
        conexion cn = new conexion();

        public DataTable MostrarTrabajadores()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarTrabajadores", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public Boolean IniciarSesion(String usuario,String password)
        {
            SqlCommand cmd = new SqlCommand("SELECT NombreUsuario, Password FROM Administrador WHERE NombreUsuario='" + usuario + "' AND password='" + password + "'", cn.LeerCadena());

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

            return false; 
        }
        public DataTable MostrarRiegos()
        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarRiegos", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        
        public DataTable MostrarHectareas()        {
            SqlDataAdapter da = new SqlDataAdapter("SP_MostrarHectareas", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable MostrarInventario()
        {
            SqlDataAdapter mi = new SqlDataAdapter("SP_MostrarInventario", cn.LeerCadena());
            mi.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable im = new DataTable();
            mi.Fill(im);
            return im;

        }

        public void insertarTrabajador()
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Trabajadores VALUES('ERICK', 'RODRIGUEZ', '1111111', 'calle PRIVADA'); ", cn.LeerCadena());
            SqlDataReader dr = cmd.ExecuteReader();
        }
    }
}
