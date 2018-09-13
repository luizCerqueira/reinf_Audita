using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5011RPrest : Entidade
	{
		public string tpInscTomador { get; set; }

		public string nrInscTomador { get; set; }

		public double vlrTotalBaseRet { get; set; }

		public double vlrTotalRetPrinc { get; set; }

		public double vlrTotalRetAdic { get; set; }

		public double vlrTotalNRetPrinc { get; set; }

		public double vlrTotalNRetAdic { get; set; }

		public int R5011infoTotalContrib { get; set; }
	}
}
