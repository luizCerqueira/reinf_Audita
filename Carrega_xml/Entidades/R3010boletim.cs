using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R3010boletim : Entidade
	{
		public string nrBoletim { get; set; }

		public string tpCompeticao { get; set; }

		public string categEvento { get; set; }

		public string modDesportiva { get; set; }

		public string nomeCompeticao { get; set; }

		public string cnpjMandante { get; set; }

		public string cnpjVisitante { get; set; }

		public string nomeVisitante { get; set; }

		public string pracaDesportiva { get; set; }

		public string codMunic { get; set; }

		public string uf { get; set; }

		public int qtdePagantes { get; set; }

		public int qtdeNaoPagantes { get; set; }

		public int R3010ideEstab { get; set; }
	}
}
