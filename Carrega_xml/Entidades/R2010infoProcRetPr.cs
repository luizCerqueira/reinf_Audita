using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2010infoProcRetPr
    {
        public int tpProcRetPrinc { get; set; }

        public string nrProcRetPrinc { get; set; }

        public string codSuspPrinc { get; set; }

        public double valorPrinc { get; set; }

        public int R2010 { get; set; } //CHAVE ESTRANGEIRA
    }
}
