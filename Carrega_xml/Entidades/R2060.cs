﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R2060 : Entidade
	{
		public string tpAmb { get; set; }

		public string procEmi { get; set; }

		public string verProc { get; set; }

		public string indRetif { get; set; }

		public string nrRecibo { get; set; }

		public DateTime perApur { get; set; }

		public string tpInscContri { get; set; }

		public string nrInscContri { get; set; }

		public string tpInscEstab { get; set; }

		public string nrInscEstab { get; set; }

		public double vlrRecBrutaTotal { get; set; }

		public double vlrCPApurTotal { get; set; }

		public double vlrCPRBSuspTotal { get; set; }

		public int tpProcesso { get; set; }

		public string nrProcesso { get; set; }

		public string codSusp { get; set; }

		public int R1000 { get; set; }

	}
}
