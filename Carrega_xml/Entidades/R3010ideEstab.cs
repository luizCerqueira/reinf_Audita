using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R3010ideEstab : Entidade
	{
		public string tpInscEstab { get; set; }//Alterado

		public string nrInscEstab { get; set; }//Alterado

		public double vlrReceitaTotal { get; set; }

		public double vlrCP { get; set; }

		public double vlrCPSuspTotal { get; set; }

		public double vlrReceitaClubes { get; set; }

		public double vlrRetParc { get; set; }

		public int R3010 { get; set; }
	}
}
