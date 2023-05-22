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
            Cliente x = new Cliente("Mario", "Rossi", "MRORSI78B14FN470F", 34500);
            Cliente y = new Cliente("Luca", "Bianchi", "LCABAC78B14FN470F", 54000);
            Cliente z = new Cliente("Andrea", "Verdi", "NDRVRD89A13B", 75000);
            Cliente prova = new Cliente("Cuco", "Cachi", "POMERIGGIOSANTO", 9999999999999);

            Banca b1 = new Banca("EuroBanca spa");

            b1.AddCliente(x);
            b1.AddCliente(y);
            b1.AddCliente(z);

            b1.AddCliente(prova);
            b1.RemoveClienteCod("POMERIGGIOSANTO");

            b1.AddCliente(prova);
            b1.RemoveCliente(prova);

            Prestito p1 = new Prestito(5000, 500, new DateTime(2019, 1, 10), new DateTime(2020, 1, 10), x);
            Prestito p2 = new Prestito(15000, 700, new DateTime(2020, 5, 24), new DateTime(2023, 4, 1), y);
            Prestito p3 = new Prestito(35000, 1000, new DateTime(2022, 8, 31), new DateTime(2023, 8, 29), z);
            Prestito p4 = new Prestito(234520, 5000, new DateTime(2021, 3, 21), new DateTime(2027, 12, 23), z);

            b1.AddPrestito(p1);
            b1.AddPrestito(p2);
            b1.AddPrestito(p3);
            b1.AddPrestito(p4);

            Console.WriteLine("Inserire il codice fiscale del cliente desiderato: ");
            string codfis = Console.ReadLine();

            List<Prestito> prestiti = b1.SearchPrestiti(codfis);

            foreach (Prestito p in prestiti)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine("-------------------------------");
                Console.ReadKey();
            }

            double tot = b1.TotalePrestiti(codfis);
            Console.WriteLine("Importo totale: " + tot.ToString() + " €");
            Console.ReadKey();
        }


    }
}
