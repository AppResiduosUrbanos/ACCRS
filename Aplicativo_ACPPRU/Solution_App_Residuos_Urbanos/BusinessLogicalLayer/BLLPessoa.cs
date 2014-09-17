using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities;

namespace BusinessLogicalLayer
{
    public class BLLPessoa
    {
        DALPessoa dalPessoa = new DALPessoa();
        BEPessoa _pessoa = new BEPessoa();

        public DataTable GetPessoas()
        {
            return dalPessoa.GetPessoas();
        }

        public DataTable GetPerfilPessoa()
        {
            return dalPessoa.GetPerfilPessoa();
        }

        public DataTable GetTipoDocumento()
        {
            return dalPessoa.GetTipoDocumento();
        }

        public BEPessoa GetPessoa(string numDoc)
        {
            return dalPessoa.GetPessoa(numDoc);
        }

        public void IncluirPessoa(BEPessoa pessoa)
        {
            dalPessoa.incluirPessoa(pessoa);
        }

        public string DeletarPessoa(int codigo)
        {
            return dalPessoa.deletarPessoa(codigo);
        }

        public string AtualizarPessoa(BEPessoa pessoa)
        {
            return dalPessoa.atualizarPessoa(pessoa);
        }

        public DataTable Logueo(string email, string senha)
        {
            return dalPessoa.Logueo(email, senha);
        }

    }
}
