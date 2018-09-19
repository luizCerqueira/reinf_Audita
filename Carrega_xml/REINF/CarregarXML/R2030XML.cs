using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace REINF
{
    public class R2030XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2030 r2030 = new R2030();
            R2030infoRecurso r2030InfoRecurso = new R2030infoRecurso();
            R2030recursosRec r2030RecursosRec = new R2030recursosRec();

            DaoR2030 daoR2030 = new DaoR2030();
            DaoR2030infoRecurso daoR2030InfoRecurso = new DaoR2030infoRecurso();
            DaoR2030recursosRec daoR2030RecursosRec = new DaoR2030recursosRec();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtAssocDespRec":
                            x.MoveToAttribute("id");
                            r2030.Id = x.Value.ToString();
                            break;
                        case "indRetif":
                            r2030.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r2030.nrRecibo = x.ReadString();
                            break;
                        case "perApur":
                            r2030.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2030.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2030.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2030.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2030.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2030.nrInsc = x.ReadString();
                            break;
                        case "tpInscEstab":
                            r2030.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r2030.nrInscEstab = x.ReadString();
                            break;
                        //R2030infoRecurso
                        case "tpRepasse":
                            r2030InfoRecurso.tpRepasse = int.Parse(x.ReadString());
                            break;
                        case "descRecurso":
                            r2030InfoRecurso.descRecurso = x.ReadString();
                            break;
                        case "vlrBruto":
                            r2030InfoRecurso.vlrBruto = double.Parse(x.ReadString());
                            break;
                        case "vlrRetApur":
                            r2030InfoRecurso.vlrRetApur = double.Parse(x.ReadString());
                            break;
                        //R2030recursosRec
                        case "cnpjOrigRecurso":
                            r2030RecursosRec.cnpjOrigRecurso = x.ReadString();
                            break;
                        case "vlrTotalRec":
                            r2030RecursosRec.vlrTotalRec = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalRet":
                            r2030RecursosRec.vlrTotalRet = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalNRet":
                            r2030RecursosRec.vlrTotalNRet = double.Parse(x.ReadString());
                            break;
                        case "tpProc":
                            r2030RecursosRec.tpProc = int.Parse(x.ReadString());
                            break;
                        case "nrProc":
                            r2030RecursosRec.nrProc = x.ReadString();
                            break;
                        case "codSusp":
                            r2030RecursosRec.codSusp = x.ReadString();
                            break;
                        case "vlrNRet":
                            r2030RecursosRec.vlrNRet = double.Parse(x.ReadString());
                            break;
                    }
                }

            }

			daoR2030.Save(r2030, database, Codigo, r2030.Id);
			daoR2030InfoRecurso.Save(r2030InfoRecurso, database, Codigo, r2030.Id);
			daoR2030RecursosRec.Save(r2030RecursosRec, database, Codigo, r2030.Id);


			return true;
        }
    }
}
