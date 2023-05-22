using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prestito_bancario
{
    public class Cliente
    {
        private string _nome;
        private string _cognome;
        private string _codiceFiscale;
        private double _stipendio;
        
        public Cliente() { }

        public Cliente(string Nome, string Cognome, string CodiceFiscale, double Stipendio)
        {
            this.Nome = Nome;
            this.Cognome = Cognome;
            this.CodiceFiscale = CodiceFiscale;
            this.Stipendio = Stipendio;
        }

        public string Nome 
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Cognome 
        {
            get { return _cognome; }
            set { _cognome = value; }
        }

        public string CodiceFiscale 
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }

        public double Stipendio
        {
            get { return _stipendio; }
            set{ _stipendio = value; }
        }


        
    }
}
