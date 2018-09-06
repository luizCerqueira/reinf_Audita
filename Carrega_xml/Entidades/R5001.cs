using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R5001 : Entidade
	{
		public string perApur { get; set; }

		public string tpInsc { get; set; }

		public string nrInsc { get; set; }

		public string cdRetorno { get; set; }

		public string descRetorno { get; set; }

		public DateTime dhProcess { get; set; }

		public string tpEv { get; set; }

		public string idEv { get; set; }

		public string HASH { get; set; }

		public string nrRecArqBase { get; set; }

		public string indExistInfo { get; set; }

		public string indEscrituracao { get; set; }

		public string indDesoneracao { get; set; }

		public string indAcordoIsenMulta { get; set; }

		public double vlrCPApur { get; set; }

		public double vlrTotalRet { get; set; }

		public double vlrRatApur { get; set; }

		public double vlrSenarApur { get; set; }

		public double vlrCPSusp { get; set; }

		public double vlrRatSusp { get; set; }

		public double vlrSenarSusp { get; set; }

		public double vlrTotalNRet { get; set; }

		public int R1000 { get; set; }
	}
}
