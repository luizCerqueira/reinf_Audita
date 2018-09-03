using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAO;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            R1000 r = new R1000();
            DaoR1000 teste = new DaoR1000();
            teste.Save(r, "teste");
            Console.WriteLine("Retorno: " + r.Id);
            Console.ReadLine(); 
        }
    }
}
