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
	public class R5001XML
	{
		public bool CarregarXML(string caminho, string database, int Id)
		{

			R5001 r5001 = new R5001();
			R5001ideEstab r5001IdeeEstab = new R5001ideEstab();
			R5001RCPRB r5001Rcprb = new R5001RCPRB();
			R5001regOcorrs r5001RegOcorrs = new R5001regOcorrs();
			R5001RPrest r5001RPrest = new R5001RPrest();
			R5001RRecRepAD r5001RRecRepAD = new R5001RRecRepAD();
			R5001RTom r5001RTom = new R5001RTom();

			DaoR5001 daoR5001 = new DaoR5001();
			DaoR5001ideEstab daoR5001IdeeEstab = new DaoR5001ideEstab();
			DaoR5001RCPRB daoR5001RCPRB = new DaoR5001RCPRB();
			DaoR5001regOcorrs daoR5001RegOcorrs = new DaoR5001regOcorrs();
			DaoR5001RPrest daoR5001RPrest = new DaoR5001RPrest();
			DaoR5001RRecRepAD daoR5001RRecRepAD = new DaoR5001RRecRepAD();
			DaoR5001RTom daoR5001RTom = new DaoR5001RTom();

			XmlDocument xml = new XmlDocument();
			XmlTextReader x = new XmlTextReader(caminho);


			while (x.Read())
			{
				if (x.NodeType == XmlNodeType.Element)
				{
					switch (x.Name)
					{
						case "evtTotal":
							x.MoveToAttribute("id");
							r5001.Chave = x.Value.ToString();
							break;
						case "perApur":
							r5001.perApur = x.ReadString();
							break;
						case "tpInsc":
							r5001.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r5001.nrInsc = x.ReadString();
							break;
						case "cdRetorno":
							r5001.cdRetorno = x.ReadString();
							break;
						case "descRetorno":
							r5001.descRetorno = x.ReadString();
							break;
						case "nrProtEntr":
							r5001.nrProtEntr = x.ReadString();
							break;
						case "dhProcess":
							r5001.dhProcess = DateTime.Parse(x.ReadString());
							break;
						case "tpEv":
							r5001.tpEv = x.ReadString();
							break;
						case "idEv":
							r5001.idEv = x.ReadString();
							break;
						case "hash":
							r5001.hash = x.ReadString();
							break;
						case "CRComl":
							r5001.CRComl = x.ReadString();
							break;
						case "vlrCRComl":
							r5001.vlrCRComl = x.ReadString();
							break;
						case "vlrCRComlSusp":
							r5001.vlrCRComlSusp = x.ReadString();
							break;
						case "CRRecEspetDesp":
							r5001.CRRecEspetDesp = x.ReadString();
							break;
						case "vlrReceitaTotal":
							r5001.vlrReceitaTotal = double.Parse(x.ReadString());
							break;
						case "vlrCRRecEspetDesp":
							r5001.vlrCRRecEspetDesp = double.Parse(x.ReadString());
							break;
						case "vlrCRRecEspetDespSusp":
							r5001.vlrCRRecEspetDespSusp = double.Parse(x.ReadString());
							break;
						case "nrRecArqBase":
							r5001.nrRecArqBase = x.ReadString();
							break;
						case "indExistInfo":
							r5001.indExistInfo = x.ReadString();
							break;
						case "indEscrituracao":
							r5001.indEscrituracao = x.ReadString();
							break;
						case "indDesoneracao":
							r5001.indDesoneracao = x.ReadString();
							break;
						case "indAcordoIsenMulta":
							r5001.indAcordoIsenMulta = x.ReadString();
							break;
						case "vlrCPApur":
							r5001.vlrCPApur = double.Parse(x.ReadString());
							break;
						case "vlrTotalRet":
							r5001.vlrTotalRet = double.Parse(x.ReadString());
							break;
						case "vlrRatApur":
							r5001.vlrRatApur = double.Parse(x.ReadString());
							break;
						case "vlrSenarApur":
							r5001.vlrSenarApur = double.Parse(x.ReadString());
							break;
						case "vlrCPSusp":
							r5001.vlrCPSusp = double.Parse(x.ReadString());
							break;
						case "vlrRatSusp":
							r5001.vlrRatSusp = double.Parse(x.ReadString());
							break;
						case "vlrSenarSusp":
							r5001.vlrSenarSusp = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRet":
							r5001.vlrTotalNRet = double.Parse(x.ReadString());
							break;
						//R5001ideEstab
						case "ideEstab":
							do
							{
								x.Read();
								switch (x.Name)
								{
									case "tpInsc":
										r5001IdeeEstab.tpInsc = x.ReadString();
										break;
									case "nrInsc":
										r5001IdeeEstab.nrInsc = x.ReadString();
										break;
								}
							} while (x.NodeType == XmlNodeType.EndElement && x.Name == "ideEstab");
							break;
						//R5001RCPRB
						case "CRCPRB":
							r5001Rcprb.CRCPRB = x.ReadString();
							break;
						case "vlrCRCPRB":
							r5001Rcprb.vlrCRCPRB = double.Parse(x.ReadString());
							break;
						case "vlrCRCPRBSusp":
							r5001Rcprb.vlrCRCPRBSusp = double.Parse(x.ReadString());
							break;
						//R5001regOcorrs
						case "tpOcorr":
							r5001RegOcorrs.tpOcorr = x.ReadString();
							break;
						case "localErroAviso":
							r5001RegOcorrs.localErroAviso = x.ReadString();
							break;
						case "codResp":
							r5001RegOcorrs.codResp = x.ReadString();
							break;
						case "dscResp":
							r5001RegOcorrs.dscResp = x.ReadString();
							break;
						//R5001RPrest
						case "tpInscTomador":
							r5001RPrest.tpInscTomador = x.ReadString();
							break;
						case "nrInscTomador":
							r5001RPrest.nrInscTomador = x.ReadString();
							break;
						case "vlrTotalBaseRet":
							r5001RPrest.vlrTotalBaseRet = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetPrinc":
							r5001RPrest.vlrTotalRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetAdic":
							r5001RPrest.vlrTotalRetAdic = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetPrinc":
							r5001RPrest.vlrTotalNRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetAdic":
							r5001RPrest.vlrTotalNRetAdic = double.Parse(x.ReadString());
							break;
						//R5001RRecRepAD
						case "cnpjAssocDesp":
							r5001RRecRepAD.cnpjAssocDesp = x.ReadString();
							break;
						case "vlrTotalRep":
							r5001RRecRepAD.vlrTotalRep = double.Parse(x.ReadString());
							break;
						case "CRRecRepAD":
							r5001RRecRepAD.CRRecRepAD = x.ReadString();
							break;
						case "vlrCRRecRepAD":
							r5001RRecRepAD.vlrCRRecRepAD = double.Parse(x.ReadString());
							break;
						case "vlrCRRecRepADSusp":
							r5001RRecRepAD.vlrCRRecRepADSusp = double.Parse(x.ReadString());
							break;
						//R5001RTom
						case "cnpjPrestador":
							r5001RTom.cnpjPrestador = x.ReadString();
							break;
						case "cno":
							r5001RTom.cno = x.ReadString();
							break;
						case "CRTom":
							r5001RTom.CRTom = x.ReadString();
							break;
						case "vlrCRTom":
							r5001RTom.vlrCRTom = double.Parse(x.ReadString());
							break;
						case "vlrCRTomSusp":
							r5001RTom.vlrCRTomSusp = double.Parse(x.ReadString());
							break;
						
					}
				}

			}

			daoR5001.Save(r5001, database, Id, r5001.Chave);
			daoR5001IdeeEstab.Save(r5001IdeeEstab, database, Id, r5001.Chave);
			daoR5001RCPRB.Save(r5001Rcprb, database, Id, r5001.Chave);
			daoR5001RegOcorrs.Save(r5001RegOcorrs, database, Id, r5001.Chave);
			daoR5001RPrest.Save(r5001RPrest, database, Id, r5001.Chave);
			daoR5001RRecRepAD.Save(r5001RRecRepAD, database, Id, r5001.Chave);
			daoR5001RTom.Save(r5001RTom, database, Id, r5001.Chave);


			return true;
		}
	}
}
