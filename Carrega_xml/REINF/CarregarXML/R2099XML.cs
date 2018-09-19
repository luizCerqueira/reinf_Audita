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
    public class R2099XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2099 r2099 = new R2099();

            DaoR2099 daoR2099 = new DaoR2099();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtFechaEvPer":
                            x.MoveToAttribute("id");
                            r2099.Id = x.Value.ToString();
                            break;
                        case "perApur":
                            r2099.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2099.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2099.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2099.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2099.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2099.nrInsc = x.ReadString();
                            break;
                        case "nmResp":
                            r2099.nmResp = x.ReadString();
                            break;
                        case "cpfResp":
                            r2099.cpfResp = x.ReadString();
                            break;
                        case "telefone":
                            r2099.telefone = x.ReadString();
                            break;
                        case "email":
                            r2099.email = x.ReadString();
                            break;
                        case "evtServTm":
                            r2099.evtServTm = x.ReadString();
                            break;
                        case "evtServPr":
                            r2099.evtServPr = x.ReadString();
                            break;
                        case "evtAssDespRec":
                            r2099.evtAssDespRec = x.ReadString();
                            break;
                        case "evtAssDespRep":
                            r2099.evtAssDespRep = x.ReadString();
                            break;
                        case "evtComProd":
                            r2099.evtComProd = x.ReadString();
                            break;
                        case "evtCPRB":
                            r2099.evtCPRB = x.ReadString();
                            break;
                        case "evtPgtos":
                            r2099.evtPgtos = x.ReadString();
                            break;
                        case "compSemMovto":
                            r2099.compSemMovto = x.ReadString();
                            break;

                    }
                }

            }

			daoR2099.Save(r2099, database, Codigo, r2099.Id);

			return true;
        }
    }
}
