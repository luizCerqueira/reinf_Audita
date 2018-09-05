using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class R5001RTom : Entidade
	{
		public string cnpjPrestador { get; set; }

		public double vlrTotalBaseRet { get; set; }

		public double vlrTotalRetPrinc { get; set; }

		public double vlrTotalRetAdic { get; set; }

		public double vlrTotalNRetPrinc { get; set; }

		public double vlrTotalNRetAdic { get; set; }

		public int R5001 { get; set; }
	}
}
