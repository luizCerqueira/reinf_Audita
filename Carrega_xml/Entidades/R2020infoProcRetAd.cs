using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2020infoProcRetAd : Entidade
	{
        public int tpProcRetAdic { get; set; }

        public string nrProcRetAdic { get; set; }

        public string codSuspAdic { get; set; }

        public double valorAdic { get; set; }

        public int R2020ideTomador { get; set; } //estrangeira
    }
}
