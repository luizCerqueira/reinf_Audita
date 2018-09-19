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
	public class R2020XML
	{
		public bool CarregarXML(string caminho, string database, int Codigo)
		{
			R2020 r2020 = new R2020();
			R2020ideTomador r2020IdeTomador = new R2020ideTomador();
			R2020nfs r2020Nfs = new R2020nfs();
			R2020infoTpServ r2020InfoTpServ = new R2020infoTpServ();
			R2020infoProcRetPr r2020InfoProcRetPr = new R2020infoProcRetPr();
			R2020infoProcRetAd r2020InfoProcRetAd = new R2020infoProcRetAd();

			DaoR2020 daoR2020 = new DaoR2020();
			DaoR2020ideTomador daoR2020IdeTomador = new DaoR2020ideTomador();
			DaoR2020nfs daoR2020Nfs = new DaoR2020nfs();
			DaoR2020infoTpServ daoR2020InfoTpServ = new DaoR2020infoTpServ();
			DaoR2020infoProcRetPr daoR2020InfoProcRetPr = new DaoR2020infoProcRetPr();
			DaoR2020infoProcRetAd daoR2020InfoProcRetAd = new DaoR2020infoProcRetAd();



			XmlDocument xml = new XmlDocument();
			XmlTextReader x = new XmlTextReader(caminho);


			while (x.Read())
			{
				if (x.NodeType == XmlNodeType.Element)
				{
					switch (x.Name)
					{
						//R2020
						case "evtServPrest":
							x.MoveToAttribute("id");
							r2020.Id = x.Value.ToString();
							break;
						case "indRetif":
							r2020.indRetif = x.ReadString();
							break;
						case "nrRecibo":
							r2020.nrRecibo = x.ReadString();
							break;
						case "perApur":
							r2020.perApur = DateTime.Parse(x.ReadString());
							break;
						case "tpAmb":
							r2020.tpAmb = x.ReadString();
							break;
						case "procEmi":
							r2020.procEmi = x.ReadString();
							break;
						case "verProc":
							r2020.verProc = x.ReadString();
							break;
						case "tpInsc":
							r2020.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r2020.nrInsc = x.ReadString();
							break;
						case "tpInscEstabPrest":
							r2020.tpInscEstabPrest = x.ReadString();
							break;
						case "nrInscEstabPrest":
							r2020.nrInscEstabPrest = x.ReadString();
							break;
						//R2020ideTomador
						case "tpInscTomador":
							r2020IdeTomador.tpInscTomador = x.ReadString();
							break;
						case "nrInscTomador":
							r2020IdeTomador.nrInscTomador = x.ReadString();
							break;
						case "indObra":
							r2020IdeTomador.indObra = int.Parse(x.ReadString());
							break;
						case "vlrTotalBruto":
							r2020IdeTomador.vlrTotalBruto = double.Parse(x.ReadString());
							break;
						case "vlrTotalBaseRet":
							r2020IdeTomador.vlrTotalBaseRet = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetPrinc":
							r2020IdeTomador.vlrTotalRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetAdic":
							r2020IdeTomador.vlrTotalRetAdic = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetPrinc":
							r2020IdeTomador.vlrTotalNRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetAdic":
							r2020IdeTomador.vlrTotalNRetAdic = double.Parse(x.ReadString());
							break;
						//R2020nfs
						case "serie":
							r2020Nfs.serie = x.ReadString();
							break;
						case "numDocto":
							r2020Nfs.numDocto = x.ReadString();
							break;
						case "dtEmissaoNF":
							r2020Nfs.dtEmissaoNF = DateTime.Parse(x.ReadString());
							break;
						case "vlrBruto":
							r2020Nfs.vlrBruto = double.Parse(x.ReadString());
							break;
						case "obs":
							r2020Nfs.obs = x.ReadString();
							break;
						//R2020infoTpServ
						case "tpServico":
							r2020InfoTpServ.tpServico = x.ReadString();
							break;
						case "vlrBaseRet":
							r2020InfoTpServ.vlrBaseRet = double.Parse(x.ReadString());
							break;
						case "vlrRetencao":
							r2020InfoTpServ.vlrRetencao = double.Parse(x.ReadString());
							break;
						case "vlrRetSub":
							r2020InfoTpServ.vlrRetSub = double.Parse(x.ReadString());
							break;
						case "vlrNRetPrinc":
							r2020InfoTpServ.vlrNRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrServico15":
							r2020InfoTpServ.vlrServico15 = double.Parse(x.ReadString());
							break;
						case "vlrServico20":
							r2020InfoTpServ.vlrServico20 = double.Parse(x.ReadString());
							break;
						case "vlrServico25":
							r2020InfoTpServ.vlrServico25 = double.Parse(x.ReadString());
							break;
						case "vlrAdicional":
							r2020InfoTpServ.vlrAdicional = double.Parse(x.ReadString());
							break;
						case "vlrNRetAdic":
							r2020InfoTpServ.vlrNRetAdic = double.Parse(x.ReadString());
							break;
						//R2020infoProcRetPr
						case "tpProcRetPrinc":
							r2020InfoProcRetPr.tpProcRetPrinc = int.Parse(x.ReadString());
							break;
						case "nrProcRetPrinc":
							r2020InfoProcRetPr.nrProcRetPrinc = x.ReadString();
							break;
						case "codSuspPrinc":
							r2020InfoProcRetPr.codSuspPrinc = x.ReadString();
							break;
						case "valorPrinc":
							r2020InfoProcRetPr.valorPrinc = double.Parse(x.ReadString());
							break;
						//R2020infoProcRetAd
						case "tpProcRetAdic":
							r2020InfoProcRetAd.tpProcRetAdic = int.Parse(x.ReadString());
							break;
						case "nrProcRetAdic":
							r2020InfoProcRetAd.nrProcRetAdic = x.ReadString();
							break;
						case "codSuspAdic":
							r2020InfoProcRetAd.codSuspAdic = x.ReadString();
							break;
						case "valorAdic":
							r2020InfoProcRetAd.valorAdic = double.Parse(x.ReadString());
							break;

					}
				}

			}
			daoR2020.Save(r2020, database, Codigo, r2020.Id);
			daoR2020IdeTomador.Save(r2020IdeTomador, database, Codigo, r2020.Id);
			daoR2020Nfs.Save(r2020Nfs, database, Codigo, r2020.Id);
			daoR2020InfoTpServ.Save(r2020InfoTpServ, database, Codigo, r2020.Id);
			daoR2020InfoProcRetPr.Save(r2020InfoProcRetPr, database, Codigo, r2020.Id);
			daoR2020InfoProcRetAd.Save(r2020InfoProcRetAd, database, Codigo, r2020.Id);



			return true;
		}
	}
}
