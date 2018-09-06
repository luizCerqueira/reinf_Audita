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
            R1000softHouse r1000softHouse = new R1000softHouse();
            DaoR1000 daoR1000 = new DaoR1000();
          //DaoR1000softHouse daoR1000softHouse = new DaoR1000softHouse();
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
                            r1000.Chave = x.Value.ToString();
                            break;
                        case "tpAmb":
                            r1000.tpAmb = x.ReadString();   
                            break;
                        case "procEmi":
                            r1000.procEmi = x.ReadString();
                            break;
                    }
                }
            }


            //daoR1000.Save(r1000, database, 0, "");
            //daoR1000softHouse.Save(r1000softHouse, database, r1000.Id, "")

            return r1000.Id;
        }
    }
}
