using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEImagem
    {

        public int int_idImagem { get; set; }
        public int int_idPessoa { get; set; }
        public int int_idCoordenada { get; set; }
        public string str_descImagem { get; set; }
        public string str_pathImagem { get; set; }
        public int int_idModerador { get; set; }
        public DateTime dt_DataImagem { get; set; }
   
    }
}
