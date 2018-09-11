using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2020ideTomador : Entidade
	{
        public string tpInscTomador { get; set; }

        public string nrInscTomador { get; set; }

        public int indObra { get; set; }

        public double vlrTotalBruto { get; set; }

        public double vlrTotalBaseRet { get; set; }

        public double vlrTotalRetPrinc { get; set; }

        public double vlrTotalRetAdic { get; set; }

        public double vlrTotalNRetPrinc { get; set; }

        public double vlrTotalNRetAdic { get; set; }
        
        //public string codAnaCont { get; set; }

        public int R2020 { get; set; }
    }
}
