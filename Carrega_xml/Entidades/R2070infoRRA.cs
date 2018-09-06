using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R2070infoRRA : Entidade
	{
		public int tpProcRRA { get; set; }

		public string nrProcRRA { get; set; }

		public string codSusp { get; set; }

		public string natRRA { get; set; }

		public int qtdMesesRRA { get; set; }

		public double vlrDespCustas { get; set; }

		public double vlrDespAdvogados { get; set; }

		public int R2070pgtoResidBR { get; set; }
	}
}
