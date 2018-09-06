using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	class R2070infoProcJud : Entidade
	{
		public string nrProcJud { get; set; }

		public string codSusp { get; set; }

		public int indOrigemRecursos { get; set; }

		public string cnpjOrigemRecursos { get; set; }

		public double vlrDespCustas { get; set; }

		public double vlrDespAdvogados { get; set; }

		public int R2070pgtoResidBR { get; set; }
	}
}
