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
	public class R9000XML
	{
		public bool CarregarXML(string caminho, string database, int Codigo)
		{

			R9000 r9000 = new R9000();
			
			DaoR9000 daoR9000 = new DaoR9000();
			

			XmlDocument xml = new XmlDocument();
			XmlTextReader x = new XmlTextReader(caminho);


			while (x.Read())
			{
				if (x.NodeType == XmlNodeType.Element)
				{
					switch (x.Name)
					{
						case "evtExclusao":
							x.MoveToAttribute("id");
							r9000.Id = x.Value.ToString();
							break;
						case "tpAmb":
							r9000.tpAmb = x.ReadString();
							break;
						case "procEmi":
							r9000.procEmi = x.ReadString();
							break;
						case "verProc":
							r9000.verProc = x.ReadString();
							break;
						case "tpInsc":
							r9000.tpInsc = x.ReadString();
							break;
						case "nrInsc":
							r9000.nrInsc = x.ReadString();
							break;
						case "tpEvento":
							r9000.tpEvento = x.ReadString();
							break;
						case "nrRecEvt":
							r9000.nrRecEvt = x.ReadString();
							break;
						case "perApur":
							r9000.perApur = DateTime.Parse(x.ReadString());
							break;


					}
				}

			}

			daoR9000.Save(r9000, database, Codigo, r9000.Id);

			return true;
		}
	}
}
