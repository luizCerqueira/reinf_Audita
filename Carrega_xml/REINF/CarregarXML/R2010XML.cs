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
    public class R2010XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2010 r2010 = new R2010();
            DaoR2010 daoR2010 = new DaoR2010();
            R2010infoProcRetAd r2010InfoProcRetAd = new R2010infoProcRetAd();
            DaoR2010infoProcRetAd daoR2010InfoProcRetAd = new DaoR2010infoProcRetAd();
            R2010infoProcRetPr r2010InfoProcRetPr = new R2010infoProcRetPr();
            DaoR2010infoProcRetPr daoR2010InfoProcRetPr = new DaoR2010infoProcRetPr();
            R2010infoTpServ r2010InfoTpServ = new R2010infoTpServ();
            DaoR2010infoTpServ daoR2010InfoTpServ = new DaoR2010infoTpServ();
            R2010nfs r2010Nfs = new R2010nfs();
            DaoR2010nfs daoR2010Nfs = new DaoR2010nfs();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtServTom":
                            x.MoveToAttribute("id");
                            r2010.Id = x.Value.ToString();
                            break;
                        case "indRetif":
                            r2010.indRetif = x.ReadString();
                            break;
                        case "nrRecibo":
                            r2010.nrRecibo = x.ReadString();
                            break;
                        case "perApur":
                            r2010.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2010.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2010.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2010.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2010.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2010.nrInsc = x.ReadString();
                            break;
                        case "tpInscEstab":
                            r2010.tpInscEstab = x.ReadString();
                            break;
                        case "nrInscEstab":
                            r2010.nrInscEstab = x.ReadString();
                            break;
                        case "indObra":
                            r2010.indObra = x.ReadString();
                            break;
                        case "cnpjPrestador":
                            r2010.cnpjPrestador = x.ReadString();
                            break;
                        case "vlrTotalBruto":
                            r2010.vlrTotalBruto = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalBaseRet":
                            r2010.vlrTotalBaseRet = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalRetPrinc":
                            r2010.vlrTotalRetPrinc = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalRetAdic":
                            r2010.vlrTotalRetAdic = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalNRetPrinc":
                            r2010.vlrTotalNRetPrinc = double.Parse(x.ReadString());
                            break;
                        case "vlrTotalNRetAdic":
                            r2010.vlrTotalNRetAdic = double.Parse(x.ReadString());
                            break;
                        case "indCPRB":
                            r2010.indCPRB = int.Parse(x.ReadString());
                            break;
                        //R2010infoProcRetAd
                        case "tpProcRetAdic":
                            r2010InfoProcRetAd.tpProcRetAdic = int.Parse(x.ReadString());
                            break;
                        case "nrProcRetAdic":
                            r2010InfoProcRetAd.nrProcRetAdic = x.ReadString();
                            break;
                        case "codSuspAdic":
                            r2010InfoProcRetAd.codSuspAdic = x.ReadString();
                            break;
                        case "valorAdic":
                            r2010InfoProcRetAd.valorAdic = double.Parse(x.ReadString());
                            break;
                        //R2010infoProcRetPr
                        case "tpProcRetPrinc":
                            r2010InfoProcRetPr.tpProcRetPrinc = int.Parse(x.ReadString());
                            break;
                        case "nrProcRetPrinc":
                            r2010InfoProcRetPr.nrProcRetPrinc = x.ReadString();
                            break;
                        case "codSuspPrinc":
                            r2010InfoProcRetPr.codSuspPrinc = x.ReadString();
                            break;
                        case "valorPrinc":
                            r2010InfoProcRetPr.valorPrinc = double.Parse(x.ReadString());
                            break;
                        //R2010infoTpServ
                        case "tpServico":
                            r2010InfoTpServ.tpServico = x.ReadString();
                            break;
                        case "vlrBaseRet":
                            r2010InfoTpServ.vlrBaseRet = double.Parse(x.ReadString());
                            break;
                        case "vlrRetencao":
                            r2010InfoTpServ.vlrRetencao = double.Parse(x.ReadString());
                            break;
                        case "vlrRetSub":
                            r2010InfoTpServ.vlrRetSub = double.Parse(x.ReadString());
                            break;
                        case "vlrNRetPrinc":
                            r2010InfoTpServ.vlrNRetPrinc = double.Parse(x.ReadString());
                            break;
                        case "vlrServicos15":
                            r2010InfoTpServ.vlrServicos15 = double.Parse(x.ReadString());
                            break;
                        case "vlrServicos20":
                            r2010InfoTpServ.vlrServicos20 = double.Parse(x.ReadString());
                            break;
                        case "vlrServicos25":
                            r2010InfoTpServ.vlrServicos25 = double.Parse(x.ReadString());
                            break;
                        case "vlrAdicional":
                            r2010InfoTpServ.vlrAdicional = double.Parse(x.ReadString());
                            break;
                        case "vlrNRetAdic":
                            r2010InfoTpServ.vlrNRetAdic = double.Parse(x.ReadString());
                            break;
                        //R2010nfs
                        case "serie":
                            r2010Nfs.serie = x.ReadString();
                            break;
                        case "numDocto":
                            r2010Nfs.numDocto = x.ReadString();
                            break;
                        case "dtEmissaoNF":
                            r2010Nfs.dtEmissaoNF = DateTime.Parse(x.ReadString());
                            break;
                        case "vlrBruto":
                            r2010Nfs.vlrBruto = double.Parse(x.ReadString());
                            break;
                        case "obs":
                            r2010Nfs.obs = x.ReadString();
                            break;
                    }
                }

            }
			daoR2010.Save(r2010, database, Codigo, r2010.Id);
			daoR2010InfoProcRetAd.Save(r2010InfoProcRetAd, database, Codigo, r2010.Id);
			daoR2010InfoProcRetPr.Save(r2010InfoProcRetPr, database, Codigo, r2010.Id);
			daoR2010InfoTpServ.Save(r2010InfoTpServ, database, Codigo, r2010.Id);
			daoR2010Nfs.Save(r2010Nfs, database, Codigo, r2010.Id);


			return true;
        }
    }
}
