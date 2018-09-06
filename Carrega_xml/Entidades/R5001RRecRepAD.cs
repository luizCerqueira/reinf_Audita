using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5001RRecRepAD : Entidade
	{
		public string cnpjAssocDesp { get; set; }

		public double vlrTotalRep { get; set; }

		public double vlrTotalRet { get; set; }

		public double vlrTotalNRet { get; set; }

		public int R5001 { get; set; }
	}
}
