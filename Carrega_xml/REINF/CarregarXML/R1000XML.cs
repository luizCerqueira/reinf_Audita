using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Xml;

namespace REINF
{
    public class R1000XML
    {

        public int CarregarXML(string caminho, string database)
        {
            R1000 r1000 = new R1000();
            DaoR1000 daoR1000 = new DaoR1000();
			R1000inclusao r1000inc = new R1000inclusao();
			DaoR1000inclusao daoR1000inc = new DaoR1000inclusao();
			R1000alteracao r1000alt = new R1000alteracao();
			DaoR1000alteracao daoR1000alt = new DaoR1000alteracao();
			R1000exclusao r1000exc = new R1000exclusao();
			DaoR1000exclusao daoR1000exc = new DaoR1000exclusao();
			XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);

            
            while (x.Read())
             {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch(x.Name)
                    {
                        case "evtInfoContri":
                            x.MoveToAttribute("id");
                            r1000.Id = x.Value.ToString();
                            break;
						case "tpAmb":
							r1000.tpAmb = x.ReadString();
							break;
						case "procEmi":
							r1000.procEmi = x.ReadString();
							break;
						case "verProc":
							r1000.verProc = x.ReadString();
							break;
						case "tpInsc":
							r1000.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r1000.nrInsc = x.ReadString();
							break;
						case "inclusao":
							do
							{
								x.Read();
								switch (x.Name) {
									case "iniValid":
										r1000inc.iniValid = DateTime.Parse(x.ReadString());
										break;
									case "fimValid":
										r1000inc.fimValid = DateTime.Parse(x.ReadString());
										break;
									case "classTrib":
										r1000inc.classTrib = x.ReadString();
										break;
									case "indEscrituracao":
										r1000inc.indEscrituracao = x.ReadString();
										break;
									case "indDesoneracao":
										r1000inc.indDesoneracao = x.ReadString();
										break;
									case "indAcordoIsenMulta":
										r1000inc.indAcordoIsenMulta = x.ReadString();
										break;
									case "indSitPJ":
										r1000inc.indSitPJ = x.ReadString();
										break;
									case "nmCtt":
										r1000inc.nmCtt = x.ReadString();
										break;
									case "cpfCtt":
										r1000inc.cpfCtt = x.ReadString();
										break;
									case "foneFixo":
										r1000inc.foneFixo = x.ReadString();
										break;
									case "foneCel":
										r1000inc.foneCel = x.ReadString();
										break;
									case "email":
										r1000inc.email = x.ReadString();
										break;
									case "cnpjSoftHouse":
										r1000inc.cnpjSoftHouse = x.ReadString();
										break;
									case "nmRazao":
										r1000inc.nmRazao = x.ReadString();
										break;
									case "nmCont":
										r1000inc.nmCont = x.ReadString();
										break;
									case "telefone":
										r1000inc.telefone = x.ReadString();
										break;
									case "softHouse":
										x.Read();
										if (x.Name == "email")
										{
											r1000inc.emailSoft = x.ReadString();
										}
										break;
									case "ideEFR":
										r1000inc.ideEFR = x.ReadString();
										break;
									case "cnpjEFR":
										r1000inc.cnpjEFR = x.ReadString();
										break;
									case "R1000":
										r1000inc.R1000 = int.Parse(x.ReadString());
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
									case "iniValid":
										r1000alt.iniValid = DateTime.Parse(x.ReadString());
										break;
									case "fimValid":
										r1000alt.fimValid = DateTime.Parse(x.ReadString());
										break;
									case "classTrib":
										r1000alt.classTrib = x.ReadString();
										break;
									case "indEscrituracao":
										r1000alt.indEscrituracao = x.ReadString();
										break;
									case "indDesoneracao":
										r1000alt.indDesoneracao = x.ReadString();
										break;
									case "indAcordoIsenMulta":
										r1000alt.indAcordoIsenMulta = x.ReadString();
										break;
									case "indSitPJ":
										r1000alt.indSitPJ = x.ReadString();
										break;
									case "nmCtt":
										r1000alt.nmCtt = x.ReadString();
										break;
									case "cpfCtt":
										r1000alt.cpfCtt = x.ReadString();
										break;
									case "foneFixo":
										r1000alt.foneFixo = x.ReadString();
										break;
									case "foneCel":
										r1000alt.foneCel = x.ReadString();
										break;
									case "email":
										r1000alt.email = x.ReadString();
										break;
									case "cnpjSoftHouse":
										r1000alt.cnpjSoftHouse = x.ReadString();
										break;
									case "nmRazao":
										r1000alt.nmRazao = x.ReadString();
										break;
									case "nmCont":
										r1000alt.nmCont = x.ReadString();
										break;
									case "telefone":
										r1000alt.telefone = x.ReadString();
										break;
									case "softHouse":
										do {
											x.Read();
											if (x.Name == "email")
											{
												r1000inc.emailSoft = x.ReadString();
											}
										} while(x.NodeType != XmlNodeType.EndElement && x.Name != "softHouse");
										break;
									case "ideEFR":
										r1000alt.ideEFR = x.ReadString();
										break;
									case "cnpjEFR":
										r1000alt.cnpjEFR = x.ReadString();
										break;
									case "novaValidade":
										x.Read();
										if (x.Name == "iniValid")
										{
											r1000alt.iniValidN = DateTime.Parse(x.ReadString());
										}else if (x.Name == "fimValid")
										{
											r1000alt.fimValidN = DateTime.Parse(x.ReadString());
										}
										break;
									case "fimValidN":
										
										break;
								}
							} while (x.NodeType != XmlNodeType.EndElement && x.Name != "alteracao");
							break;
						case "exclusao":
							do
							{
								x.Read();
								if (x.Name == "iniValid")
								{
									r1000exc.iniValid = DateTime.Parse(x.ReadString());
								}
								else if (x.Name == "fimValid")
								{
									r1000exc.fimValid = DateTime.Parse(x.ReadString());
								}
							} while (x.NodeType != XmlNodeType.EndElement && x.Name != "exclusao");
							break;
							x.Read();
							
							break;					
					}
                }
            }

			//Criar Clausula para utiliza o comando save condicionalmente somente se houverem dados no objeto
			bool verdade = daoR1000.Save(r1000, database, 0, r1000.Id);
			bool verdade2 = daoR1000inc.Save(r1000inc, database, 0, r1000.Id);
			bool verdade3 = daoR1000alt.Save(r1000alt, database, 0, r1000.Id);
			bool verdade4 = daoR1000exc.Save(r1000exc, database, 0, r1000.Id);

			return r1000.Codigo;
		}
    }
}