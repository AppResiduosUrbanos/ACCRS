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
    public class DALImagem
    {
        SqlConnection conexion = null;
        SqlDataAdapter comando = null;
        SqlDataReader dr = null;
        string str_error;
        SqlCommand cmd;
        Conexao cn = new Conexao();
        int resultado = 0;

        public List<BEImagem> ObterImagens()
        {
            List<BEImagem> listImagens = new List<BEImagem>();


            try
            {
                conexion = cn.Conectar();

                cmd = new SqlCommand("pr_listarImagenes", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                // imprime o codigo do cliente para cada registro
                BEImagem BEImagem = null;
                int posicion = 0;
                while (dr.Read())
                {
                    BEImagem = new BEImagem();
                    BEImagem.int_idImagem = dr.GetInt32(0);
                    BEImagem.int_idPessoa = dr.GetInt32(1);
                    BEImagem.int_idCoordenada = dr.GetInt32(2);
                    BEImagem.str_descImagem = dr.GetString(3);
                    BEImagem.int_estadoImagem = dr.GetInt32(4);
                    BEImagem.str_pathImagem = dr.GetString(5);
                    BEImagem.int_idModerador = dr.GetInt32(6);
                    BEImagem.dt_DataImagem = dr.GetDateTime(7);
                    BEImagem.int_posicion = posicion++;
                    listImagens.Add(BEImagem);
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
            return listImagens;
        }
    }
}
