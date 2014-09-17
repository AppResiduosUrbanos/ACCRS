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
    public class DALPessoa
    {
        static SqlConnection conexion = new SqlConnection();
        static SqlDataAdapter comando = null;
        SqlDataReader dr = null;
        string str_error;
        SqlCommand cmd = new SqlCommand();
        Conexao cn = new Conexao();
        int resultado = 0;

        public DataTable GetPessoas()
        {

            DataSet dts = new DataSet();

            conexion = cn.Conectar();

            cmd = new SqlCommand("getPessoas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //DataTable dtTable = new DataTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd);
            da.Fill(dts, "pessoas");
            return (dts.Tables["pessoas"]);

        }

        public DataTable GetPerfilPessoa()
        {

            DataSet dts = new DataSet();

            conexion = cn.Conectar();

            cmd = new SqlCommand("getPerfilPessoa", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //DataTable dtTable = new DataTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd);
            da.Fill(dts, "PerfPer");
            return (dts.Tables["PerfPer"]);

        }

        public DataTable GetTipoDocumento()
        {

            DataSet dts = new DataSet();

            conexion = cn.Conectar();

            cmd = new SqlCommand("getTipoDocumento", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            //DataTable dtTable = new DataTable();
            SqlDataAdapter da;
            da = new SqlDataAdapter(cmd);
            da.Fill(dts, "TipDoc");
            return (dts.Tables["TipDoc"]);

        }

        public BEPessoa GetPessoa(string numDoc)
        {
            try
            {
                conexion = cn.Conectar();

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                //conexion = cn.Conectar();

                conexion.Open();
                SqlCommand cmd = new SqlCommand("getPessoa", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numDoc", numDoc);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BEPessoa pessoa = new BEPessoa();
                    pessoa.int_idPessoa = int.Parse(dr["idPessoa"].ToString());
                    pessoa.str_nome = dr["nome"].ToString();
                    pessoa.str_sobrenome = dr["sobrenome"].ToString();
                    pessoa.str_email = (dr["email"].ToString());
                    pessoa.str_telefone = dr["telefone"].ToString();
                    pessoa.str_endereco = dr["endereco"].ToString();

                    return pessoa;
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void incluirPessoa(BEPessoa pessoa)
        {

            try
            {

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                cmd = new SqlCommand("InserirPessoa", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", pessoa.str_nome);
                cmd.Parameters.AddWithValue("@sobrenome", pessoa.str_sobrenome);
                cmd.Parameters.AddWithValue("@telefone", pessoa.str_telefone);
                cmd.Parameters.AddWithValue("@email", pessoa.str_email);
                cmd.Parameters.AddWithValue("@endereco", pessoa.str_endereco);
                cmd.Parameters.AddWithValue("@cpf", pessoa.int_cpf);
                cmd.Parameters.AddWithValue("@idTipDoc", pessoa.int_idTipDoc);
                cmd.Parameters.AddWithValue("@numDoc", pessoa.str_numDoc);
                cmd.Parameters.AddWithValue("@cidade", pessoa.str_cidade);

                conexion.Open();

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                conexion.Close();
            }

        }

        public string deletarPessoa(int codigo)
        {

            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("DeletarPessoa", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPessoa", codigo);
                cmd.ExecuteNonQuery();
                return null; // success 
            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                conexion.Close();
            }
        }

        public string atualizarPessoa(BEPessoa pessoa)
        {
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("AtualizarPessoa", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idPessoa", pessoa.int_idPessoa);
                cmd.Parameters.AddWithValue("@nome", pessoa.str_nome);
                cmd.Parameters.AddWithValue("@sobrenome", pessoa.str_sobrenome);
                cmd.Parameters.AddWithValue("@telefone", pessoa.str_email);
                cmd.Parameters.AddWithValue("@email", pessoa.str_email);
                cmd.Parameters.AddWithValue("@endereco", pessoa.str_endereco);

                cmd.ExecuteNonQuery();
                return null; // success 
            }
            catch (Exception ex)
            {
                throw ex;  // retorna mensagem de erro
            }
            finally
            {
                conexion.Close();
            }
        }

        public DataTable Logueo(string email, string senha)
        {
            try
            {
                conexion = cn.Conectar();
                DataTable dt = new DataTable();

                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }

                //conexion = cn.Conectar();

                conexion.Open();
                SqlCommand cmd = new SqlCommand("logueo", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
