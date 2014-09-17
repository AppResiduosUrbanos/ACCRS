using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEPessoa
    {

        public int int_idPessoa { get; set; }
        public int int_idPerfilPessoa { get; set; }
        public string str_nome { get; set; }
        public string str_sobrenome { get; set; }
        public string str_email { get; set; }
        public string str_senha { get; set; }
        public string str_telefone { get; set; }
        public int int_idTipDoc { get; set; }
        public string str_numDoc { get; set; }
        public string str_cidade { get; set; }
        public string str_endereco { get; set; }
        public int int_cpf { get; set; }
    }
}
