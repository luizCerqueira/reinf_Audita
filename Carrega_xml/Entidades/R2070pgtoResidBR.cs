using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class R2070pgtoResidBR : Entidade
	{
		public int tipoPgtoResidBR { get; set; }

		public DateTime dtPagto { get; set; }

		public double vlrRendTributavel { get; set; }

		public double vlrRet { get; set; }

		public string indSuspExig { get; set; }

		public string indDecTerceiro { get; set; }

		public double vlrIRRF { get; set; }

		public double vlrCompAnoCalend { get; set; }

		public double vlrCompAnoAnt { get; set; }

		public int R2070ideEstab { get; set; }
	}
}
