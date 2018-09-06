using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R3010ReceitaIngressos : Entidade
	{
		public string tpIngresso { get; set; }

		public string descIngr { get; set; }

		public int qtdeIngrVenda { get; set; }

		public int qtdeIngrVendidos { get; set; }

		public int qtdeIngrDev { get; set; }

		public double precoIndiv { get; set; }

		public double vlrTotal { get; set; }

		public int R3010boletim { get; set; }
	}
}
