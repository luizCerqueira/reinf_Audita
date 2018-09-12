using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class R1000alteracao : Entidade
	{
		// Esta classe contém nomes de atributo que não são completamente fiéis à suas contrapartes no xml referente,
		// porém, no processo de coleta dos dados dos xml, os dados serão atribuídos à seus atributos funcionais corretos.

		public DateTime iniValid { get; set; }

		public DateTime fimValid { get; set; }

		public string classTrib { get; set; }

		public string indEscrituracao { get; set; }

		public string indDesoneracao { get; set; }

		public string indAcordoIsenMulta { get; set; }

		public string indSitPJ { get; set; }

		public string nmCtt { get; set; }

		public string cpfCtt { get; set; }

		public string foneFixo { get; set; }

		public string foneCel { get; set; }

		public string email { get; set; }

		public string cnpjSoftHouse { get; set; }

		public string nmRazao { get; set; }

		public string nmCont { get; set; }

		public string telefone { get; set; }

		public string emailSoft { get; set; }//Representa o valor email do grupo softHouse

		public string ideEFR { get; set; }

		public string cnpjEFR { get; set; }

		public DateTime iniValidN { get; set; }//Representa o valor iniValid do grupo novaValidade

		public DateTime fimValidN { get; set; }//Representa o valor fimValid do grupo novaValidade

		public int R1000 { get; set; }
	}
}
