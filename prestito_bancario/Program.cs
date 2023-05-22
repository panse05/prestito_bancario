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
            //riferendoci alla classe "cliente" ne andiamo a creare 4 dando il nome della variabile e i 4 parametri di cui hanno bisogno
            Cliente x = new Cliente("Mario", "Rossi", "MRORSI78B14FN470F", 34500);
            Cliente y = new Cliente("Luca", "Bianchi", "LCABAC78B14FN470F", 54000);
            Cliente z = new Cliente("Andrea", "Verdi", "NDRVRD89A13B", 75000);
            Cliente w = new Cliente("Alessandro", "Azzurri", "LSSNDRZZRR05A12", 100500);

            //riferendoci alla classe "banca" andiamo a crearne 1 dandogli il nome
            Banca b1 = new Banca("EuroBanca spa");

            //ci permette di aggiungere uno o più clienti all banca
            b1.AddCliente(x);
            b1.AddCliente(y);
            b1.AddCliente(z);


            //prove per far vedere che possiamo rimuovere il cliente tramite il codice fiscale 
            b1.AddCliente(w);
            b1.RemoveClienteCod("LSSNDRZZRR05A12");

            //prove per far vedere che possiamo rimuovere il cliente tramite il nome della variabile
            b1.AddCliente(w);
            b1.RemoveCliente(w);

            //riferendoci alla classe "prestito" ne andiamo a creare 5 dandogli tutti i parametri di cui hanno bisogno tra cui il cliente che l'ha richiesto 
            Prestito p1 = new Prestito(5000, 500, new DateTime(2019, 1, 10), new DateTime(2020, 1, 10), x);
            Prestito p2 = new Prestito(15000, 700, new DateTime(2020, 5, 24), new DateTime(2023, 4, 1), y);
            Prestito p3 = new Prestito(35000, 1000, new DateTime(2022, 8, 31), new DateTime(2023, 8, 29), z);
            Prestito p4 = new Prestito(234520, 5000, new DateTime(2021, 3, 21), new DateTime(2027, 12, 23), z);
            Prestito pprova = new Prestito(1, 1, new DateTime(2021, 3, 21), new DateTime(2027, 12, 23), x);

            //ci permette di aggiungere uno o più prestiti alla banca
            b1.AddPrestito(p1);
            b1.AddPrestito(p2);
            b1.AddPrestito(p3);
            b1.AddPrestito(p4);
            
            //prova per far vedere che possiamo rimuovere il prestito tramite il nome della variabile
            b1.AddPrestito(pprova);
            b1.RemovePrestito(pprova);

            //chiede all'utente di inserire il codice fiscale che poi viene nella stringa "codfis"
            Console.WriteLine("Inserire il codice fiscale del cliente desiderato: ");
            string codfis = Console.ReadLine();

            int dd = 0;

            //se il codice fiscale inserito è nullo non ti restituisce niente e ti avvisa del fatto che hai inserito un codice non valido
            if(codfis == "") 
            {
                Console.WriteLine("Inserire un codice valido!");
                Console.ReadKey();
            }
            else //funzionerà se e solo se il codice fiscale inserito è valido 
            {
                List<Prestito> prestiti = b1.SearchPrestiti(codfis);
                Console.WriteLine("");

                foreach (Prestito p in prestiti)
                {
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("-------------------------------");
                    dd = dd + 1;
                    Console.ReadKey();
                }

                if(dd == 0)
                {
                    Console.WriteLine("Il codice inserito non ha avuto risultati");
                    Console.ReadKey();
                }
                else if (dd > 0)
                {
                    double tot = b1.TotalePrestiti(codfis);
                    Console.WriteLine("Importo totale: " + tot.ToString() + " euro");
                    Console.ReadKey();
                }

                
            }


            
        }


    }
}
