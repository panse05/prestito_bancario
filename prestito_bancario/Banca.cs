using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Banca
    {
        //attributi
        private string _nome;
        private List<Cliente> _clienti;
        private List<Prestito> _prestiti;

        //costruttore
        public Banca(string Nome)
        {
            this.Nome = Nome;
            this.Clienti = new List<Cliente>();
            this.Prestiti = new List<Prestito>();
        }

        //properties
        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public List<Cliente> Clienti 
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

        public List<Prestito> Prestiti 
        {
            get { return _prestiti; }
            set { _prestiti = value; }
        }

        //metodi
        public void AddCliente(Cliente Cliente)
        {
            this.Clienti.Add(Cliente);
        }
        public void RemoveCliente(Cliente Cliente)
        {
            this.Clienti.Remove(Cliente);
        }
        public void RemoveClienteCod(string CodiceFiscale)
        {
            this.Clienti.RemoveAll(x => x.CodiceFiscale == CodiceFiscale);
        }
              

        public void AddPrestito(Prestito Prestito)
        {
            this.Prestiti.Add(Prestito);
        }

        public void RemovePrestito(Prestito Prestito)
        {
            this.Prestiti.Add(Prestito);
        }

        public double TotalePrestiti(string CodiceFiscale) //datoci il codice fiscale 
        {
            double totale = 0; //creiamo la variabile del totale

            foreach (Prestito prestito in Prestiti) //per ogni prestito salvato nella banca 
            {
                if (prestito.Intestatario.CodiceFiscale ==CodiceFiscale) //se il codice fiscale corrisponde
                {
                    totale += prestito.Importo; //va a sommare tutti gli importi associati a quel codice
                }
            }

            return totale; //mi ritorna il totale
        }

        public List<Prestito> SearchPrestiti(string CodiceFiscale)
        {
            List<Prestito> risultati = new List<Prestito>(); //crea una nuova lista di prestiti chiamata "risultati" 

            foreach (Prestito prestito in Prestiti) //per ogni prestito salvato nella banca 
            {
                if (prestito.Intestatario.CodiceFiscale == CodiceFiscale) //controlla in tutti se il codice fiscale corrisponde 
                {
                    risultati.Add(prestito); //se sì, mi aggiunge questo prestito nella lista risultati 
                }
            }

            return risultati; //mi ritorna la lista
        }

        
    }
}
