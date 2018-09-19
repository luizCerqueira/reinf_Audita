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
    public class R2060XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2060 r2060 = new R2060();
            R2060infoProc r2060InfoProc = new R2060infoProc();
            R2060tipoAjuste r2060TipoAjuste = new R2060tipoAjuste();
            R2060tipoCod r2060TipoCod = new R2060tipoCod();

            DaoR2060 daoR2060 = new DaoR2060();
            DaoR2060infoProc daoR2060InfoProc= new DaoR2060infoProc();
            DaoR2060tipoAjuste daoR2060TipoAjuste = new DaoR2060tipoAjuste();
            DaoR2060tipoCod daoR2060TipoCod = new DaoR2060tipoCod();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtCPRB":
                            x.MoveToAttribute("id");
                            r2060.Id = x.Value.ToString();
                            break;
                        case "indRetif":
                            r2060.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r2060.nrRecibo = x.ReadString();
                            break;
                        case "perApur":
                            r2060.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2060.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2060.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2060.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2060.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2060.nrInsc = x.ReadString();
                            break;
                        case "tpInscEstab":
                            r2060.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r2060.nrInscEstab = x.ReadString();
                            break;
                        case "vlrRecBrutaTotal":
                            r2060.vlrRecBrutaTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrCPApurTotal":
                            r2060.vlrCPApurTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrCPRBSuspTotal":
                            r2060.vlrCPRBSuspTotal = double.Parse(x.ReadString());
                            break;
                        //R2060infoProc
                        case "tpProc":
                            r2060InfoProc.tpProc = int.Parse(x.ReadString());
                            break;
                        case "nrProc":
                            r2060InfoProc.nrProc = x.ReadString();
                            break;
                        case "codSusp":
                            r2060InfoProc.codSusp = x.ReadString();
                            break;
                        case "vlrCPRBSusp":
                            r2060InfoProc.vlrCPRBSusp = double.Parse(x.ReadString());
                            break;
                        //R2060tipoAjuste
                        case "tpAjuste":
                            r2060TipoAjuste.tpAjuste = int.Parse(x.ReadString());
                            break;
                        case "codAjuste":
                            r2060TipoAjuste.codAjuste = int.Parse(x.ReadString());
                            break;
                        case "vlrAjuste":
                            r2060TipoAjuste.vlrAjuste = double.Parse(x.ReadString());
                            break;
                        case "descAjuste":
                            r2060TipoAjuste.descAjuste = x.ReadString();
                            break;
                        case "dtAjuste":
                            r2060TipoAjuste.dtAjuste = DateTime.Parse(x.ReadString());
                            break;
                        //R2060tipoCod
                        case "codAtivEcon":
                            r2060TipoCod.codAtivEcon = x.ReadString();
                            break;
                        case "vlrRecBrutaAtiv":
                            r2060TipoCod.vlrRecBrutaAtiv = double.Parse(x.ReadString());
                            break;
                        case "vlrExcRecBruta":
                            r2060TipoCod.vlrExcRecBruta = double.Parse(x.ReadString());
                            break;
                        case "vlrAdicRecBruta":
                            r2060TipoCod.vlrAdicRecBruta = double.Parse(x.ReadString());
                            break;
                        case "vlrBcCPRB":
                            r2060TipoCod.vlrBcCPRB = double.Parse(x.ReadString());
                            break;
                        case "vlrCPRBapur":
                            r2060TipoCod.vlrCPRBapur = double.Parse(x.ReadString());
                            break;
                    }
                }

            }

			daoR2060.Save(r2060, database, Codigo, r2060.Id);
			daoR2060InfoProc.Save(r2060InfoProc, database, Codigo, r2060.Id);
			daoR2060TipoAjuste.Save(r2060TipoAjuste, database, Codigo, r2060.Id);
			daoR2060TipoCod.Save(r2060TipoCod, database, Codigo, r2060.Id);


			return true;
        }
    }
}
