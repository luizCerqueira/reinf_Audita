using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REINF
{
    public class CarregarXML
    {
        private static int IDR1000 ;

        public CarregarXML(string arquivos, string name, string banco)
        {
            carregar_Xmls_database(arquivos, name, banco);
        }

        protected static void carregar_Xmls_database(string arq, string name, string banco)
        {
            if (name.Trim().Replace("-", "").Contains("R1000"))
            {
                R1000XML R1000 = new R1000XML();
                IDR1000 = R1000.CarregarXML(arq, banco);
            }
            else if (name.Trim().Replace("-", "").Contains("R2010"))
            {
                R1070XML R1070 = new R1070XML();
                R1070.CarregarXML(arq, banco, IDR1000);
            }
            else if (name.Trim().Replace("-", "").Contains("R2020"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2030"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2040"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2050"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2060"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2070"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2098"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R2099"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R3010"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R5001"))
            {

            }
            else if (name.Trim().Replace("-", "").Contains("R9000"))
            {

            }
        }
    }
}
