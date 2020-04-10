using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_riego
{
    public class mostrarTrabajadores
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
    }
}
