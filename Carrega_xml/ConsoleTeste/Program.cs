using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;
using System.Xml.Linq;
using System.Xml;
using System.IO;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = (@"C:\Users\k\Desktop\Luiz\Projetos\Reinf_Xml\testexmls\R-1000-ID1019399790000002018061211533500000.xml");
            R1000 r = new R1000();
            DaoR1000 dao = new DaoR1000();
            XmlDocument xml = new XmlDocument();
            XmlTextReader x = new XmlTextReader(a);
            
            
            while (x.Read())
            {

                if (x.NodeType == XmlNodeType.Element && x.Name == "tpAmb")
                    r.tpAmb = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "procEmi")
                     r.procEmi  = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "verProc")
                    r.verProc = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "tpInsc")
                    r.tpInsc = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "nrInsc")
                    r.nrInscr = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "iniValid")
                    r.iniValid = Convert.ToDateTime((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "fimValid")
                    r.fimValid = Convert.ToDateTime((x.ReadString()));
                if (x.NodeType == XmlNodeType.Element && x.Name == "classTrib")
                    r.classTrib = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "indEscrituracao")
                    r.indEscrituracao = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "indDesoneracao")
                    r.indDesoneracao = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "indAcordoIsenMulta")
                    r.indAcordoIsenMulta = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "indSitPJ")
                    r.indSitPJ = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "nmCtt")
                    r.nmCtt = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "cpfCtt")
                    r.cpfCtt = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "foneFixo")
                    r.foneFixo = x.ReadString();
                if (x.NodeType == XmlNodeType.Element && x.Name == "email")
                    r.email = x.ReadString();
            }
            
<<<<<<< HEAD
            //dao.Save(r,"NG",0);
            
=======
            dao.Save(r,"NG",0);
			dao.Save(r,"NG", r.Id);
>>>>>>> f345179fd69028cbd7ad3a2dd64c36fc91888791
            x.Close();
            

            

        }
    }
}
