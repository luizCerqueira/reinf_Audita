using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R1070alteracao : Entidade
	{
		// Esta classe contém nomes de atributo que não são completamente fiéis à suas contrapartes no xml referente,
		// porém, no processo de coleta dos dados dos xml, os dados serão atribuídos à seus atributos funcionais corretos.

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

		public DateTime iniValidN { get; set; }//Representa o valor iniValid do grupo novaValidade

		public DateTime fimValidN { get; set; }//Representa o valor fimValid do grupo novaValidade

		public int R1070 { get; set; }
	}
}
