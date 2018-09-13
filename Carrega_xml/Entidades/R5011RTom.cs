using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5011RTom : Entidade
	{
		public string cnpjPrestador { get; set; }

		public string cno { get; set; }

		public double vlrTotalBaseRet { get; set; }

		public string CRTom { get; set; }

		public double vlrCRTom { get; set; }

		public double vlrCRTomSusp { get; set; }

		public int R5011infoTotalContrib { get; set; }
	}
}
