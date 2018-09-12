using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5001RRecRepAD : Entidade
	{
		public string cnpjAssocDesp { get; set; }

		public double vlrTotalRep { get; set; }

		public string CRRecRepAD { get; set; }//Adicionado

		//public double vlrTotalRet { get; set; } Removido

		public double vlrCRRecRepAD { get; set; }//Adicionado

		public double vlrCRRecRepADSusp { get; set; }//Adicionado

		//public double vlrTotalNRet { get; set; } Removido

		public int R5001ideEstab { get; set; }//Alterado
	}
}
