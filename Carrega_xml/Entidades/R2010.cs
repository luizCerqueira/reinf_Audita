using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2010 : Entidade
	{
        public string tpAmb { get; set; }

        public string procEmi { get; set; }

        public string verProc { get; set; }

        public string indRetif { get; set; }

        public string nrRecibo { get; set; }

        public DateTime perApur { get; set; }

        public string tpInscContri { get; set; }

        public string nrInscContri { get; set; }

        public string tpInscEstab { get; set; }

        public string nrInscEstab { get; set; }

        public string indObra { get; set; }

        public string cnpjPrestador { get; set; }

        public double vlrTotalBruto { get; set; }

        public double vlrTotalBaseRet { get; set; }

        public double vlrTotalRetPrinc { get; set; }

        public double vlrTotalRetAdic { get; set; }

        public double vlrTotalNRetPrinc { get; set; }

        public double virTotalNRetAdic { get; set; }

        public string codAnacont { get; set; }

        public int indCPRB { get; set; }

        public int R1000 { get; set; } //Estrangeira
    }
}
