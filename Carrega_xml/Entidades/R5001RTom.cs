using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5001RTom : Entidade
	{
		public string cnpjPrestador { get; set; }

		public string cno { get; set; }//Adicionado

		public double vlrTotalBaseRet { get; set; }

		public string CRTom { get; set; }//Adicionado

		public double vlrCRTom { get; set; }//Adicionado

		public double vlrCRTomSusp { get; set; }//Adicionado

		public double vlrTotalRetPrinc { get; set; }

		public double vlrTotalRetAdic { get; set; }

		public double vlrTotalNRetPrinc { get; set; }

		public double vlrTotalNRetAdic { get; set; }

		public int R5001ideEstab { get; set; }//Alterado
	}
}
