using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Xml.Linq;
using System.Xml;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = (@"C:\Users\k\Desktop\Luiz\Projetos\Reinf_Xml\testexmls\R-1000-ID1019399790000002018061211533500000.xml");
            R1000 r = new R1000();
            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(a);


            while (x.Read())
            {
                if (x.NodeType == XmlNodeType.Element && x.Name == "tpAmb")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "procEmi")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "verProc")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "tpInsc")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "nrInsc")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "iniValid")
                    Console.WriteLine(Convert.ToDateTime((x.ReadString())));
                if (x.NodeType == XmlNodeType.Element && x.Name == "fimValid")
                    Console.WriteLine(Convert.ToDateTime((x.ReadString())));
                if (x.NodeType == XmlNodeType.Element && x.Name == "classTrib")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "indEscrituracao")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "indDesoneracao")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "indAcordoIsenMulta")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "indSitPJ")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "nmCtt")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "cpfCtt")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "foneFixo")
                    Console.WriteLine((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "email")
                    Console.WriteLine((x.ReadString()));
            }

            x.Close();

            Console.ReadLine();

        }
    }
}
