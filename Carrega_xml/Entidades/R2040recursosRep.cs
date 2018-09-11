using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2040recursosRep : Entidade
	{
        public string cnpjAssocDesp { get; set; }

        public double vlrTotalRep { get; set; }

        public double vlrTotalRet { get; set; }

        public double vlrTotalNRet { get; set; }


        //GRUPO infoProc
        
        public int tpProc { get; set; } //ALTERADO

        public string nrProc { get; set; } //ALTERADO

        public string codSusp { get; set; }

        public double vlrNRet { get; set; } //INCLUIDO

        //public string codAnaCont { get; set; }

        public int R2040 { get; set; }
    }
}
