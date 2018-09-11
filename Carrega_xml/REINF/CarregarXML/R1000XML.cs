using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Xml;

namespace REINF
{
    public class R1000XML
    {

        public int CarregarXML(string caminho, string database)
        {
            R1000 r1000 = new R1000();
            DaoR1000 daoR1000 = new DaoR1000();
            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);

            
            while (x.Read())
             {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch(x.Name)
                    {
                        case "evtInfoContri":
                            x.MoveToAttribute("id");
                            r1000.Chave = x.Value.ToString();
                            break;
						case "iniValid":
							r1000.iniValid = Convert.ToDateTime(x.ReadString());
							break;
						case "fimValid":
							r1000.fimValid = Convert.ToDateTime(x.ReadString());
							break;
						case "tpAmb":
                            r1000.tpAmb = x.ReadString();   
                            break;
                        case "procEmi":
                            r1000.procEmi = x.ReadString();
                            break;
						case "verProc":
							r1000.verProc = x.ReadString();
							break;
						case "tpInsc":
							r1000.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r1000.nrInsc = x.ReadString();
							break;
						case "classTrib":
							r1000.classTrib = x.ReadString();
							break;
						case "indEscrituracao":
							r1000.indEscrituracao = x.ReadString();
							break;
						case "indDesoneracao":
							r1000.indDesoneracao = x.ReadString();
							break;
						case "indAcordoIsenMulta":
							r1000.indAcordoIsenMulta = x.ReadString();
							break;
						case "indSitPJ":
							r1000.indSitPJ = x.ReadString();
							break;
						case "nmCtt":
							r1000.nmCtt = x.ReadString();
							break;
						case "cpfCtt":
							r1000.cpfCtt = x.ReadString();
							break;
						case "foneFixo":
							r1000.foneFixo = x.ReadString();
							break;
						case "foneCel":
							r1000.foneCel = x.ReadString();
							break;
						case "email":
							r1000.email = x.ReadString();
							break;
						case "ideEFR":
							r1000.ideEFR = x.ReadString();
							break;
						case "cnpjEFR":
							r1000.cnpjEFR = x.ReadString();
							break;
						case "tpAtividade":
							r1000.tpAtividade = x.ReadString();
							break;
						case "indObra":
							r1000.indObra = x.ReadString();
							break;
						case "tpServ":
							r1000.tpServ = x.ReadString();
							break;
						case "":
							r1000.nrCNO = x.ReadString();
							break;
					}
                }
            }


            bool verdade = daoR1000.Save(r1000, database, 0, r1000.Chave);
            
            return r1000.Id;
        }
    }
}
