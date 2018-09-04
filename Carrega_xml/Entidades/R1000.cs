using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class R1000 : Entidade
    {
        public DateTime iniValid { get; set; }

        public DateTime fimValid { get; set; }

        public string tpAmb { get; set; }

        public string procEmi { get; set; }

        public string verProc { get; set; }

        public string tpInsc { get; set; }

        public string nrInscr { get; set; }

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

        public string ideEFR { get; set; }

        public string cnpjEFR { get; set; }

        public int operacao { get; set; }

        public int pai { get; set; }

        public string tpAtividade { get; set; }

        public string indObra { get; set; }

        public string tpServ { get; set; }

        public string nrCNO { get; set; }

        public int infoCPRB { get; set; }

        public int usuario { get; set; }

        public int transmitido { get; set; }

        public int Chave { get; set; }
    }
}
