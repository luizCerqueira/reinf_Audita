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
    public class R2040XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2040 r2040 = new R2040();
            R2040infoRecurso r2040InfoRecurso = new R2040infoRecurso();
            R2040recursosRep r2040RecursosRep = new R2040recursosRep();

            DaoR2040 daoR2040 = new DaoR2040();
            DaoR2040infoRecurso daoR2040InfoRecurso = new DaoR2040infoRecurso();
            DaoR2040recursosRep daoR2040RecursosRep = new DaoR2040recursosRep();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtAssocDespRep":
                            x.MoveToAttribute("id");
                            r2040.Id = x.Value.ToString();
                            break;
                        case "indRetif":
                            r2040.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r2040.nrRecibo = x.ReadString();
                            break;
                        case "perApur":
                            r2040.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2040.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2040.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2040.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2040.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2040.nrInsc = x.ReadString();
                            break;
                        case "tpInscEstab":
                            r2040.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r2040.nrInscEstab = x.ReadString();
                            break;
                        //R2040infoRecurso
                        case "tpRepasse":
                            r2040InfoRecurso.tpRepasse = int.Parse(x.ReadString());
                            break;
                        case "descRecurso":
                            r2040InfoRecurso.descRecurso = x.ReadString();
                            break;
                        case "vlrBruto":
                            r2040InfoRecurso.vlrBruto = double.Parse(x.ReadString());
                            break;
                        case "vlrRetApur":
                            r2040InfoRecurso.vlrRetApur = double.Parse(x.ReadString());
                            break;
                        //R2040recursosRep
                        case "cnpjAssocDesp":
                            r2040RecursosRep.cnpjAssocDesp = x.ReadString();
                            break;
                        case "vlrTotalRep":
                            r2040RecursosRep.vlrTotalRep = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalRet":
                            r2040RecursosRep.vlrTotalRet = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalNRet":
                            r2040RecursosRep.vlrTotalNRet = double.Parse(x.ReadString());
                            break;
                        case "tpProc":
                            r2040RecursosRep.tpProc = int.Parse(x.ReadString());
                            break;
                        case "nrProc":
                            r2040RecursosRep.nrProc = x.ReadString();
                            break;
                        case "codSusp":
                            r2040RecursosRep.codSusp = x.ReadString();
                            break;
                        case "vlrNRet":
                            r2040RecursosRep.vlrNRet = double.Parse(x.ReadString());
                            break;
                    }
                }

            }

			daoR2040.Save(r2040, database, Codigo, r2040.Id);
			daoR2040InfoRecurso.Save(r2040InfoRecurso, database, Codigo, r2040.Id);
			daoR2040RecursosRep.Save(r2040RecursosRep, database, Codigo, r2040.Id);


			return true;
        }
    }
}
