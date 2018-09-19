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
    public class R2098XML
    {
        public bool CarregarXML(string caminho, string database, int Codigo)
        {
            R2098 r2098 = new R2098();

            DaoR2098 daoR2098 = new DaoR2098();

            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(caminho);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element)
                {
                    switch (x.Name)
                    {
                        case "evtReabreEvPer":
                            x.MoveToAttribute("id");
                            r2098.Id = x.Value.ToString();
                            break;
                        case "perApur":
                            r2098.perApur = DateTime.Parse(x.ReadString());
                            break;
                        case "tpAmb":
                            r2098.tpAmb = x.ReadString();
                            break;
                        case "procEmi":
                            r2098.procEmi = x.ReadString();
                            break;
                        case "verProc":
                            r2098.verProc = x.ReadString();
                            break;
                        case "tpInsc":
                            r2098.tpInsc = x.ReadString();
                            break;
                        case "nrInsc":
                            r2098.nrInsc = x.ReadString();
                            break;
                    }
                }

            }

			daoR2098.Save(r2098, database, Codigo, r2098.Id);

			return true;
        }
    }
}
