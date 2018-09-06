using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class R2060nfs : Entidade
	{
		public string serie { get; set; }

		public string numDocto { get; set; }

		public DateTime dtEmissaoNF { get; set; }

		public double vlrBruto { get; set; }

		public int R2060tipoCod { get; set; }
	}
}
