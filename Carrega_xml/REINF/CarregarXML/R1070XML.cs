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
    public class R1070XML
    {
        public bool CarregarXML(string caminho, string database, int Id)
        {
            R1070 r1070 = new R1070();
            R1070infoSusp infoSusp = new R1070infoSusp();
            DaoR1070 daoR1070 = new DaoR1070();
            DaoR1070infoSusp daoinfoSusp = new DaoR1070infoSusp();
            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtTabProcesso":
                            x.MoveToAttribute("id");
                            r1070.Chave = x.Value.ToString();
                            infoSusp.Chave = x.Value.ToString();
                            break;
                        case "tpProc":
                            r1070.tpProc = x.ReadString();
                            break;
                        case "nrProc":
                            r1070.nrProc = x.ReadString();
                            break;
                        case "iniValid":
                            r1070.iniValid = Convert.ToDateTime(x.ReadString());
                            break;
                        case "fimValid":
                            r1070.fimValid = Convert.ToDateTime(x.ReadString());
                            break;
                        case "indAutoria":
                            r1070.indAutoria = x.ReadString();
                            break;
                        case "ufVara":
                            r1070.ufVara = x.ReadString();
                            break;
                        case "codMunic":
                            r1070.codMunic = x.ReadString();
                            break;
                        case "idVara":
                            r1070.idVara = x.ReadString();
                            break;


                       //Começo do 1070infoSusp
                        case "codSusp":
                            infoSusp.codSusp = x.ReadString();
                            break;
                        case "indSusp":
                            infoSusp.indSusp = x.ReadString();
                            break;
                        case "dtDecisao":
                            infoSusp.dtDecisao = Convert.ToDateTime(x.ReadString());
                            break;
                        case "indDeposito":
                            infoSusp.indDeposito = x.ReadString();
                            break;

                    }
                }
            }

            daoR1070.Save(r1070, database, Id, r1070.Chave);
            daoinfoSusp.Save(infoSusp, database, r1070.Id, infoSusp.Chave);



            return true;
        }
    }
}
