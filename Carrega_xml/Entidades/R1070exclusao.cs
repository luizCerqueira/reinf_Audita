using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R1070exclusao : Entidade
	{
		public string tpProc { get; set; }

		public string nrProc { get; set; }

		public DateTime iniValid { get; set; }

		public DateTime fimValid { get; set; }

		public int R1070 { get; set; }
	}
}
