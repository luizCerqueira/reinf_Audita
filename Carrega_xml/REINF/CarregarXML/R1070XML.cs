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
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R1070 r1070 = new R1070();
            DaoR1070 daoR1070 = new DaoR1070();
            R1070alteracao r1070Alteracao = new R1070alteracao();
            DaoR1070alteracao daoR1070Alteracao = new DaoR1070alteracao();
            R1070inclusao r1070Inclusao = new R1070inclusao();
            DaoR1070inclusao daoR1070Inclusao = new DaoR1070inclusao();
            R1070exclusao r1070Exclusao = new R1070exclusao();
            DaoR1070exclusao daoR1070Exclusao = new DaoR1070exclusao();



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
                            r1070.Id = x.Value.ToString();
                            break;
                        case "tpAmb":
                            r1070.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r1070.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r1070.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r1070.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r1070.nrInsc = x.ReadString();
                            break;
                        case "inclusao":
                            do
                            {
                                x.Read();
                                switch (x.Name)
                                {
                                    case "tpProc":
                                        r1070Inclusao.tpProc = x.ReadString();
                                        break;
                                    case "nrProc":
                                        r1070Inclusao.nrProc = x.ReadString();
                                        break;
                                    case "iniValid":
                                        r1070Inclusao.iniValid = DateTime.Parse(x.ReadString());
                                        break;
                                    case "fimValid":
                                        r1070Inclusao.fimValid = DateTime.Parse(x.ReadString());
                                        break;
                                    case "indAutoria":
                                        r1070Inclusao.indAutoria = x.ReadString();
                                        break;
                                    case "codSusp":
                                        r1070Inclusao.codSusp = x.ReadString();
                                        break;
                                    case "indSusp":
                                        r1070Inclusao.indSusp = x.ReadString();
                                        break;
                                    case "dtDecisao":
                                        r1070Inclusao.dtDecisao = DateTime.Parse(x.ReadString());
                                        break;
                                    case "indDeposito":
                                        r1070Inclusao.indDeposito = x.ReadString();
                                        break;
                                    case "ufVara":
                                        r1070Inclusao.ufVara = x.ReadString();
                                        break;
                                    case "codMunic":
                                        r1070Inclusao.codMunic = x.ReadString();
                                        break;
                                    case "idVara":
                                        r1070Inclusao.idVara = x.ReadString();
                                        break;
                                }
                            } while (x.NodeType != XmlNodeType.EndElement && x.Name != "inclusao");
                            break;
                        case "alteracao":
                            do
                            {
                                x.Read();
                                switch (x.Name)
                                {
                                    case "tpProc":
                                        r1070Alteracao.tpProc = x.ReadString();
                                        break;
                                    case "nrProc":
                                        r1070Alteracao.nrProc = x.ReadString();
                                        break;
                                    case "iniValid":
                                        r1070Alteracao.iniValid = DateTime.Parse(x.ReadString());
                                        break;
                                    case "fimValid":
                                        r1070Alteracao.fimValid = DateTime.Parse(x.ReadString());
                                        break;
                                    case "indAutoria":
                                        r1070Alteracao.indAutoria = x.ReadString();
                                        break;
                                    case "codSusp":
                                        r1070Alteracao.codSusp = x.ReadString();
                                        break;
                                    case "indSusp":
                                        r1070Alteracao.indSusp = x.ReadString();
                                        break;
                                    case "dtDecisao":
                                        r1070Alteracao.dtDecisao = DateTime.Parse(x.ReadString());
                                        break;
                                    case "indDeposito":
                                        r1070Alteracao.indDeposito = x.ReadString();
                                        break;
                                    case "ufVara":
                                        r1070Alteracao.ufVara = x.ReadString();
                                        break;
                                    case "codMunic":
                                        r1070Alteracao.codMunic = x.ReadString();
                                        break;
                                    case "idVara":
                                        r1070Alteracao.idVara = x.ReadString();
                                        break;
                                    case "novaValidade":
										do {
											x.Read();
											switch (x.Name)
											{
												case "iniValid":
													r1070Alteracao.iniValidN = DateTime.Parse(x.ReadString());
													break;
												case "fimValid":
													r1070Alteracao.fimValidN = DateTime.Parse(x.ReadString());
													break;
											}
										} while(x.NodeType != XmlNodeType.EndElement && x.Name != "novaValidade");
										break;
                                }
                            } while (x.NodeType != XmlNodeType.EndElement && x.Name != "alteracao");
                            break;
                        case "exclusao":
							do {
								x.Read();
								switch (x.Name)
								{
									case "iniValid":
										r1070Exclusao.iniValid = DateTime.Parse(x.ReadString());
										break;
									case "fimValid":
										r1070Exclusao.fimValid = DateTime.Parse(x.ReadString());
										break;
								}
							} while (x.NodeType != XmlNodeType.EndElement && x.Name != "exclusao");
                            break;
                    }
                }
   
            }

			daoR1070.Save(r1070, database, Codigo, r1070.Id);
			daoR1070Inclusao.Save(r1070Inclusao, database, Codigo, r1070.Id);
			daoR1070Alteracao.Save(r1070Alteracao, database, Codigo, r1070.Id);
			daoR1070Exclusao.Save(r1070Exclusao, database, Codigo, r1070.Id);

			return true;
        }
    }
}
