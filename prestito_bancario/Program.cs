using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente x = new Cliente("Mario", "Rossi", "MRORSI78B14FN470F", 54000);
            Cliente y = new Cliente("Luca", "Bianchi", "LCABAC78B14FN470F", 54000);

            Banca b = new Banca("EuroBanca spa");

            b.AddCliente(x);
            b.AddCliente(x);

            Prestito p1 = new Prestito(5000, 500, new DateTime(2019, 1, 10), new DateTime(2020, 1, 10), x);
            Prestito p2 = new Prestito(15000, 500, new DateTime(2019, 1, 10), new DateTime(2023, 1, 10), x);

            b.AddPrestito(p1);
            b.AddPrestito(p2);

            List<Prestito> prestiti = b.SearchPrestiti("MRORSI78B14FN470F");

            foreach (Prestito p in prestiti)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("-------------------------------");
            }

            double tot = b.TotalePrestiti("MRORSI78B14FN470F");
        }


    }
}
