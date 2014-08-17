using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BEPonto
    {

        public int int_idPonto { get; set; }
        public int int_descPonto { get; set; }
        public int int_idCantPonto { get; set; }
        public int int_idEstadoPonto { get; set; }
        public DateTime dt_dataInicio { get; set; }
        public DateTime dt_dataFin { get; set; }
    }
}
