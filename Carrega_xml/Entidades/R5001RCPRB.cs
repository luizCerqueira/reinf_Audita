using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5001RCPRB : Entidade
	{
		//public string codRec { get; set; } Removido

		public string CRCPRB { get; set; }

		public double vlrCRCPRB { get; set; }//Alterado

		public double vlrCRCPRBSusp { get; set; }//Aterado

		public string R5001ideEstab { get; set; }//Alterado
	}
}
