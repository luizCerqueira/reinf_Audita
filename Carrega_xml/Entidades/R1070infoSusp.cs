using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R1070infoSusp : Entidade
	{
		public string codSusp { get; set; }

		public string indSusp { get; set; }

		public DateTime dtDecisao { get; set; }

		public string indDeposito { get; set; }

		public int R1070 { get; set; }
	}
}
