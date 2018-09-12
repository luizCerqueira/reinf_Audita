using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R1070inclusao : Entidade
	{
		public string tpProc { get; set; }

		public string nrProc { get; set; }

		public DateTime iniValid { get; set; }

		public DateTime fimValid { get; set; }

		public string indAutoria { get; set; }

		public string codSusp { get; set; }

		public string indSusp { get; set; }

		public DateTime dtDecisao { get; set; }

		public string indDeposito { get; set; }

		public string ufVara { get; set; }

		public string codMunic { get; set; }

		public string idVara { get; set; }

		public int R1070 { get; set; }
	}
}
