using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class participante : Entidade
	{
		public string nrInsc { get; set; }

		public string tpInsc { get; set; }

		public string razao { get; set; }

		public DateTime dataref { get; set; }

		public int ativo { get; set; }

		public string classTrib { get; set; }

		public string indObra { get; set; }

		public string nrCNO { get; set; }

		public string infoCPRB { get; set; }

		public string infoMolestia { get; set; }

		public DateTime dtLaudo { get; set; }

		public string indNIF { get; set; }

		public string nifBenef { get; set; }

		public string relFontePagad { get; set; }

		public string paisResid { get; set; }

		public string dscLograd { get; set; }

		public string nrLograd { get; set; }

		public string complem { get; set; }

		public string bairro { get; set; }

		public string cidade { get; set; }

		public string codPostal { get; set; }

		public string tpServ { get; set; }

		public string codAtivEcon { get; set; }

		public int matriz { get; set; }

		public int usuario { get; set; }

	}
}
