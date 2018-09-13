using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R2050 : Entidade
	{
		// Esta classe contém nomes de atributo que não são completamente fiéis à suas contrapartes no xml referente,
		// porém, no processo de coleta dos dados dos xml, os dados serão atribuídos à seus atributos funcionais corretos.

		public string indRetif { get; set; }

        public string nrRecibo { get; set; }

        public DateTime perApur { get; set; }

		public string tpAmb { get; set; }

		public string procEmi { get; set; }

		public string verProc { get; set; }

		public string tpInsc { get; set; }

        public string nrInsc { get; set; }

        public string tpInscEstab { get; set; }

        public string nrInscEstab { get; set; }

        public double vlrRecBrutaTotal { get; set; }

        public double vlrCPApur { get; set; }

        public double vlrRatApur { get; set; }

        public double vlrSenarApur { get; set; }

		public double vlrCPSuspTotal { get; set; }

		public double vlrRatSuspTotal { get; set; }

		public double vlrSenarSuspTotal { get; set; }

		public int R1000 { get; set; }
    }
}
