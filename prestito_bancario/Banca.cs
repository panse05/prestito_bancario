using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Banca
    {
        private string _nome;
        private List<Cliente> _clienti;
        private List<Prestito> _prestiti;

        public Banca(string Nome)
        {
            this.Nome = Nome;
            this.Clienti = new List<Cliente>();
            this.Prestiti = new List<Prestito>();
        }

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

        public void AddPrestito(Prestito Prestito)
        {
            this.Prestiti.Add(Prestito);
        }

        public double TotalePrestiti(string CodiceFiscale)
        {
            return this.Prestiti.FindAll(p => p.Intestatario.CodiceFiscale == CodiceFiscale).Sum(p => p.Ammontare);
        }

        public List<Prestito> SearchPrestiti(string CodiceFiscale)
        {
            return this.Prestiti.FindAll(p => p.Intestatario.CodiceFiscale == CodiceFiscale);
        }

        public void AddCliente(Cliente Cliente)
        {
            this.Clienti.Add(Cliente);
        }
        public void RemoveCliente(string CodiceFiscale)
        {
            this.Clienti.RemoveAll(x => x.CodiceFiscale == CodiceFiscale);
        }
        public Cliente SearchCliente(string CodiceFiscale)
        {
            return this.Clienti.Find(x => x.CodiceFiscale == CodiceFiscale);
        }
        public List<Prestito> GetPrestitiCliente(string CodiceFiscale)
        {
            return this.Prestiti.FindAll(p => p.Intestatario.CodiceFiscale == CodiceFiscale);
        }
    }
}
