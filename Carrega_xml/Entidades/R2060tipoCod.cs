using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R2060tipoCod : Entidade
	{
		public string codAtivEcon { get; set; }

		public double vlrRecBrutaAtiv { get; set; }

		public double vlrExcRecBruta { get; set; }

		public double vlrAdicRecBruta { get; set; }

		public double vlrBcCPRB { get; set; }

		public double vlrCPRBapur { get; set; }

		public string codAnaCont { get; set; }

		public int R2060 { get; set; }
	}
}
