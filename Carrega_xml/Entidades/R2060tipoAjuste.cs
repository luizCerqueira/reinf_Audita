using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class R2060tipoAjuste : Entidade
	{
		public int tpAjuste { get; set; }

		public int codAjuste { get; set; }

		public double vlrAjuste { get; set; }

		public string descAjuste { get; set; }

		public DateTime dtAjuste { get; set; }

		public int R2060tipoCod { get; set; }
	}
}
