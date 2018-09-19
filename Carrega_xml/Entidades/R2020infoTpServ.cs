using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2020infoTpServ : Entidade
	{
        public string tpServico { get; set; }

        public double vlrBaseRet { get; set; }

        public double vlrRetencao { get; set; }

        public double vlrRetSub { get; set; }

        public double vlrNRetPrinc { get; set; }

        public double vlrServico15 { get; set; }

        public double vlrServico20 { get; set; }

        public double vlrServico25 { get; set; }

        public double vlrAdicional { get; set; }

        public double vlrNRetAdic { get; set; }

        public int R2020nfs { get; set; }    
    }
}
