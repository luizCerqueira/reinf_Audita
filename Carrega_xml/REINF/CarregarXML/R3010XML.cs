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
    public class R3010XML
    {
        public bool CarregarXML(string caminho, string database, int Id)
        {
            
            R3010 r3010 = new R3010();
            R3010boletim r3010Boletim = new R3010boletim();
            R3010ideEstab r3010IdeEstab = new R3010ideEstab();
            R3010infoProc r3010InfoProc = new R3010infoProc();
            R3010outrasReceitas r3010OutrasReceitas = new R3010outrasReceitas();
            R3010ReceitaIngressos r3010ReceitaIngressos = new R3010ReceitaIngressos();

            DaoR3010 daoR3010 = new DaoR3010();
            DaoR3010boletim daoR3010Boletim = new DaoR3010boletim();
            DaoR3010ideEstab daoR3010IdeEstab = new DaoR3010ideEstab();
            DaoR3010infoProc daoR3010InfoProc = new DaoR3010infoProc();
            DaoR3010outrasReceitas daoR3010OutrasReceitas = new DaoR3010outrasReceitas();
            DaoR3010ReceitaIngressos daoR3010ReceitaIngressos = new DaoR3010ReceitaIngressos();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
						case "evtEspDesportivo":
							x.MoveToAttribute("id");
							r3010.Chave = x.Value.ToString();
							break;
						case "indRetif":
                            r3010.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r3010.nrRecibo = x.ReadString();
                            break;
                        case "dtApuracao":
                            r3010.dtApuracao = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r3010.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r3010.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r3010.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r3010.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r3010.nrInsc = x.ReadString();
                            break;
                        //R3010boletim
                        case "nrBoletim":
                            r3010Boletim.nrBoletim = x.ReadString();
                            break;
                        case "tpCompeticao":
                            r3010Boletim.tpCompeticao = x.ReadString();
                            break;
                        case "categEvento":
                            r3010Boletim.categEvento = x.ReadString();
                            break;
                        case "modDesportiva":
                            r3010Boletim.modDesportiva = x.ReadString();
                            break;
                        case "nomeCompeticao":
                            r3010Boletim.nomeCompeticao = x.ReadString();
                            break;
                        case "cnpjMandante":
                            r3010Boletim.cnpjMandante = x.ReadString();
                            break;
                        case "cnpjVisitante":
                            r3010Boletim.cnpjVisitante = x.ReadString();
                            break;
                        case "nomeVisitante":
                            r3010Boletim.nomeVisitante = x.ReadString();
                            break;
                        case "pracaDesportiva":
                            r3010Boletim.pracaDesportiva = x.ReadString();
                            break;
                        case "codMunic":
                            r3010Boletim.codMunic = x.ReadString();
                            break;
                        case "uf":
                            r3010Boletim.uf = x.ReadString();
                            break;
                        case "qtdePagantes":
                            r3010Boletim.qtdePagantes = int.Parse(x.ReadString());
                            break;
                        case "qtdeNaoPagantes":
                            r3010Boletim.qtdeNaoPagantes = int.Parse(x.ReadString());
                            break;
                        //R3010ideEstab
                        case "tpInscEstab":
                            r3010IdeEstab.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r3010IdeEstab.nrInscEstab = x.ReadString();
                            break;
                        case "vlrReceitaTotal":
                            r3010IdeEstab.vlrReceitaTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrCP":
                            r3010IdeEstab.vlrCP = double.Parse(x.ReadString());
                            break;
                        case "vlrCPSuspTotal":
                            r3010IdeEstab.vlrCPSuspTotal = double.Parse(x.ReadString());
                            break;
                        case "vlrReceitaClubes":
                            r3010IdeEstab.vlrReceitaClubes = double.Parse(x.ReadString());
                            break;
                        case "vlrRetParc":
                            r3010IdeEstab.vlrRetParc = double.Parse(x.ReadString());
                            break;
                        //R3010infoProc
                        case "tpProc":
                            r3010InfoProc.tpProc = x.ReadString();
                            break;
                        case "nrProc":
                            r3010InfoProc.nrProc = x.ReadString();
                            break;
                        case "codSusp":
                            r3010InfoProc.codSusp = x.ReadString();
                            break;
                        case "vlrCPSusp":
                            r3010InfoProc.vlrCPSusp = x.ReadString();
                            break;
                        //R3010outrasReceitas
                        case "tpReceita":
                            r3010OutrasReceitas.tpReceita = x.ReadString();
                            break;
                        case "vlrReceita":
                            r3010OutrasReceitas.vlrReceita = x.ReadString();
                            break;
                        case "descReceita":
                            r3010OutrasReceitas.descReceita = x.ReadString();
                            break;
                        //R3010ReceitaIngressos
                        case "tpIngresso":
                            r3010ReceitaIngressos.tpIngresso = x.ReadString();
                            break;
                        case "descIngr":
                            r3010ReceitaIngressos.descIngr = x.ReadString();
                            break;
                        case "qtdeIngrVenda":
                            r3010ReceitaIngressos.qtdeIngrVenda = int.Parse(x.ReadString());
                            break;
                        case "qtdeIngrVendidos":
                            r3010ReceitaIngressos.qtdeIngrVendidos = int.Parse(x.ReadString());
                            break;
                        case "qtdeIngrDev":
                            r3010ReceitaIngressos.qtdeIngrDev = int.Parse(x.ReadString());
                            break;
                        case "precoIndiv":
                            r3010ReceitaIngressos.precoIndiv = double.Parse(x.ReadString());
                            break;
                        case "vlrTotal":
                            r3010ReceitaIngressos.vlrTotal = double.Parse(x.ReadString());
                            break;
                    }
                }

            }

            daoR3010.Save(r3010, database, Id, r3010.Chave);
            daoR3010Boletim.Save(r3010Boletim, database, Id, r3010.Chave);
            daoR3010IdeEstab.Save(r3010IdeEstab, database, Id, r3010.Chave);
            daoR3010InfoProc.Save(r3010InfoProc, database, Id, r3010.Chave);
            daoR3010OutrasReceitas.Save(r3010OutrasReceitas, database, Id, r3010.Chave);

            return true;
        }
    }
}
