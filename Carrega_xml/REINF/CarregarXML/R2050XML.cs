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
    public class R2050XML
    {
        public bool CarregarXML(string caminho, string database, int Id)
        {
            R2050 r2050 = new R2050();
            R2050infoProc r2050InfoProc = new R2050infoProc();
            R2050tipoCom r2050TipoCom = new R2050tipoCom();

            DaoR2050 daoR2050 = new DaoR2050();
            DaoR2050infoProc daoR2050InfoProc = new DaoR2050infoProc();
            DaoR2050tipoCom daoR2050TipoCom = new DaoR2050tipoCom();
            
            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtComProd":
                            x.MoveToAttribute("id");
                            r2050.Chave = x.Value.ToString();
                            break;
                        case "indRetif":
                            r2050.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r2050.nrRecibo = x.ReadString();
                            break;
                        case "perApur":
                            r2050.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2050.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2050.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2050.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2050.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2050.nrInsc = x.ReadString();
                            break;
                        case "tpInscEstab":
                            r2050.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r2050.nrInscEstab = x.ReadString();
                            break;
                        case "vlrRecBrutaTotal":
                            r2050.vlrRecBrutaTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrCPApur":
                            r2050.vlrCPApur = double.Parse(x.ReadString());
                            break;
                        case "vlrRatApur":
                            r2050.vlrRatApur = double.Parse(x.ReadString());
                            break;
                        case "vlrSenarApur":
                            r2050.vlrSenarApur = double.Parse(x.ReadString());
                            break;
                        case "vlrCPSuspTotal":
                            r2050.vlrCPSuspTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrRatSuspTotal":
                            r2050.vlrRatSuspTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrSenarSuspTotal":
                            r2050.vlrSenarSuspTotal = double.Parse(x.ReadString());
                            break;
                        //R2050infoProc
                        case "tpProc":
                            r2050InfoProc.tpProc = int.Parse(x.ReadString());
                            break;
                        case "nrProc":
                            r2050InfoProc.nrProc = x.ReadString();
                            break;
                        case "codSusp":
                            r2050InfoProc.codSusp = x.ReadString();
                            break;
                        case "vlrCPSusp":
                            r2050InfoProc.vlrCPSusp = double.Parse(x.ReadString());
                            break;
                        case "vlrRatSusp":
                            r2050InfoProc.vlrRatSusp = double.Parse(x.ReadString());
                            break;
                        case "vlrSenarSusp":
                            r2050InfoProc.vlrSenarSusp = double.Parse(x.ReadString());
                            break;
                        //R2050tipoCom
                        case "indCom":
                            r2050TipoCom.indCom = int.Parse(x.ReadString());
                            break;
                        case "vlrRecBruta":
                            r2050TipoCom.vlrRecBruta = int.Parse(x.ReadString());
                            break;

                    }
                }

            }

            daoR2050.Save(r2040, database, Id, r2050.Chave);
            daoR2050InfoProc.Save(r2050InfoProc, database, Id, r2050.Chave);
            daoR2050TipoCom.Save(r2050TipoCom, database, Id, r2050.Chave);


            return true;
        }
    }
}
