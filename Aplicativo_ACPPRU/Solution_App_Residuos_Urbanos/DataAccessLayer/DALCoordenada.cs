using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BusinessEntities;

namespace DataAccessLayer
{
    public class DALCoordenada
    {
        SqlConnection conexion = null;
        SqlDataAdapter comando = null;
        SqlDataReader dr = null;
        string str_error;
        SqlCommand cmd;
        Conexao cn = new Conexao();
        int resultado = 0;

        public List<BECoordenada> ObterCorrdenadas()
        {
            List<BECoordenada> listCoordenadas = new List<BECoordenada>();
        

            try
            {
                conexion = cn.Conectar();
                
                cmd = new SqlCommand("pr_Listar_Coordenadas", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                // imprime o codigo do cliente para cada registro
                BECoordenada BECoordenada = null;

                while (dr.Read())
                {
                    BECoordenada = new BECoordenada();
                    BECoordenada.str_latitud = dr.GetString(0);
                    BECoordenada.str_longitud = dr.GetString(1);

                    listCoordenadas.Add(BECoordenada);
                }
            }
            catch (Exception ex)
            {
                str_error = ex.Message;
            }
            finally
            {
                // fecha o reader
                if (dr != null)
                {
                    dr.Close();
                }
                // fecha a conexão
                if (cn != null)
                {
                    conexion.Close();
                }
            }
            return listCoordenadas;
        }
    }
}
