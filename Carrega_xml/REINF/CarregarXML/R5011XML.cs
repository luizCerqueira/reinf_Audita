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
	public class R5011XML
	{
		public bool CarregarXML(string caminho, string database, int Id)
		{

			R5011 r5011 = new R5011();
			R5011infoRecEv r5011InfoRecEv = new R5011infoRecEv();
			R5011infoTotalContrib r5011InfoTotalContrib = new R5011infoTotalContrib();
			R5011RComl r5011RComl = new R5011RComl();
			R5011RCPRB r5011Rcprb = new R5011RCPRB();
			R5011RPrest r5011RPrest = new R5011RPrest();
			R5011RRecRepAD r5011RRecRepAD = new R5011RRecRepAD();
			R5011RTom r5011RTom = new R5011RTom();

			DaoR5011 daoR5011 = new DaoR5011();
			DaoR5011infoRecEv daoR5011InfoRecEv = new DaoR5011infoRecEv();
			DaoR5011infoTotalContrib daoR5011InfoTotalContrib = new DaoR5011infoTotalContrib();
			DaoR5011RComl daoR5011RComl = new DaoR5011RComl();
			DaoR5011RCPRB daoR5011RCPRB = new DaoR5011RCPRB();
			DaoR5011RPrest daoR5011RPrest = new DaoR5011RPrest();
			DaoR5011RRecRepAD daoR5011RRecRepAD = new DaoR5011RRecRepAD();
			DaoR5011RTom daoR5011RTom = new DaoR5011RTom();

			XmlDocument xml = new XmlDocument();
			XmlTextReader x = new XmlTextReader(caminho);


			while (x.Read())
			{
				if (x.NodeType == XmlNodeType.Element)
				{
					switch (x.Name)
					{
						case "evtTotalContrib":
							x.MoveToAttribute("id");
							r5011.Chave = x.Value.ToString();
							break;
						case "perApur":
							r5011.perApur = DateTime.Parse(x.ReadString());
							break;
						case "tpInsc":
							r5011.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r5011.nrInsc = x.ReadString();
							break;
						case "cdRetorno":
							r5011.cdRetorno = x.ReadString();
							break;
						case "descRetorno":
							r5011.descRetorno = x.ReadString();
							break;
						case "tpOcorr":
							r5011.tpOcorr = x.ReadString();
							break;
						case "localErroAviso":
							r5011.localErroAviso = x.ReadString();
							break;
						case "codResp":
							r5011.codResp = x.ReadString();
							break;
						case "dscResp":
							r5011.dscResp = x.ReadString();
							break;
						//R5011infoRecEv
						case "nrProtEntr":
							r5011InfoRecEv.nrProtEntr = x.ReadString();
							break;
						case "dhProcess":
							r5011InfoRecEv.dhProcess = DateTime.Parse(x.ReadString());
							break;
						case "tpEv":
							r5011InfoRecEv.tpEv = x.ReadString();
							break;
						case "idEv":
							r5011InfoRecEv.idEv = x.ReadString();
							break;
						case "hash":
							r5011InfoRecEv.hash = x.ReadString();
							break;
						//R5011infoTotalContrib
						case "nrRecArqBase":
							r5011InfoTotalContrib.nrRecArqBase = x.ReadString();
							break;
						case "indExistInfo":
							r5011InfoTotalContrib.indExistInfo = int.Parse(x.ReadString());
							break;
						//R5011RComl
						case "CRComl":
							r5011RComl.CRComl = x.ReadString();
							break;
						case "vlrCRComl":
							r5011RComl.vlrCRComl = double.Parse(x.ReadString());
							break;
						case "vlrCRComlSusp":
							r5011RComl.vlrCRComlSusp = double.Parse(x.ReadString());
							break;
						//R5011RCPRB
						case "CRCPRB":
							r5011Rcprb.CRCPRB = x.ReadString();
							break;
						case "vlrCRCPRB":
							r5011Rcprb.vlrCRCPRB = double.Parse(x.ReadString());
							break;
						case "vlrCRCPRBSusp":
							r5011Rcprb.vlrCRCPRBSusp = double.Parse(x.ReadString());
							break;
						//R5011RTom
						case "R5011RTom":
							do
							{
								x.Read();
								switch(x.Name){ 
								case "cnpjPrestador":
									r5011RTom.cnpjPrestador = x.ReadString();
									break;
								case "cno":
									r5011RTom.cno = x.ReadString();
									break;
								case "vlrTotalBaseRet":
									r5011RTom.vlrTotalBaseRet = double.Parse(x.ReadString());
									break;
								case "CRTom":
									r5011RTom.CRTom = x.ReadString();
									break;
								case "vlrCRTom":
									r5011RTom.vlrCRTom = double.Parse(x.ReadString());
									break;
								case "vlrCRTomSusp":
									r5011RTom.vlrCRTomSusp = double.Parse(x.ReadString());
									break;
								} 
								
							} while (x.NodeType == XmlNodeType.EndElement && x.Name == "R5011RTom");
							break;
						//R5011RPrest
						case "tpInscTomador":
							r5011RPrest.tpInscTomador = x.ReadString();
							break;
						case "nrInscTomador":
							r5011RPrest.nrInscTomador = x.ReadString();
							break;
						case "vlrTotalBaseRet":
							r5011RPrest.vlrTotalBaseRet = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetPrinc":
							r5011RPrest.vlrTotalRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalRetAdic":
							r5011RPrest.vlrTotalRetAdic = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetPrinc":
							r5011RPrest.vlrTotalNRetPrinc = double.Parse(x.ReadString());
							break;
						case "vlrTotalNRetAdic":
							r5011RPrest.vlrTotalNRetAdic = double.Parse(x.ReadString());
							break;
						//R5011RRecRepAD
						case "CRRecRepAD":
							r5011RRecRepAD.CRRecRepAD = x.ReadString();
							break;
						case "vlrCRRecRepAD":
							r5011RRecRepAD.vlrCRRecRepAD = double.Parse(x.ReadString());
							break;
						case "vlrCRRecRepADSusp":
							r5011RRecRepAD.vlrCRRecRepADSusp = double.Parse(x.ReadString());
							break;
						
					}
				}

			}

			daoR5011.Save(r5011, database, Id, r5011.Chave);
			
			daoR5011RCPRB.Save(r5011Rcprb, database, Id, r5011.Chave);
			
			daoR5011RPrest.Save(r5011RPrest, database, Id, r5011.Chave);
			daoR5011RRecRepAD.Save(r5011RRecRepAD, database, Id, r5011.Chave);
			daoR5011RTom.Save(r5011RTom, database, Id, r5011.Chave);


			return true;
		}
	}
}
