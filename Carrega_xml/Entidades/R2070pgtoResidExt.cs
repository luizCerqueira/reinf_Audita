using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R2070pgtoResidExt : Entidade
	{
		public DateTime dtPagto { get; set; }

		public int tpRendimento { get; set; }

		public string formaTributacao { get; set; }

		public double vlrPgto { get; set; }

		public double vlrRet { get; set; }

		public int R2070ideEstab { get; set; }
	}
}
